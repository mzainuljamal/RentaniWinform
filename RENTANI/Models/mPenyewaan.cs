using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using RentaniApp.Helpers;

namespace RentaniApp.Models
{
    public class Penyewaan
    {
        public int IdPenyewaan { get; set; }
        public int IdPenyewa { get; set; }
        public int IdAlat { get; set; }
        public DateTime TglMulai { get; set; }
        public DateTime TglSelesai { get; set; }
        public int DurasiHari { get; set; }
        public decimal TotalHarga { get; set; }
        public string Status { get; set; }
        public string Catatan { get; set; }

        public Penyewaan() { }

        public static bool HapusSemuaDataEksperimen()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                using var trans = conn.BeginTransaction();

                string query = "TRUNCATE TABLE penyewaan RESTART IDENTITY CASCADE";
                using (var cmd = new NpgsqlCommand(query, conn, trans))
                {
                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                MessageBox.Show("Semua data penyewaan dan pembayaran berhasil dihapus bersih untuk eksperimen!", "Sukses Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengosongkan database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static int AmbilIdPenyewaDariUser(int idUser)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string query = "SELECT id_penyewa FROM penyewa WHERE id_user = @id_user LIMIT 1";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id_user", idUser);
                object res = cmd.ExecuteScalar();
                return res != null ? Convert.ToInt32(res) : idUser;
            }
            catch
            {
                return idUser;
            }
        }

        public decimal HitungTotal(decimal hargaPerHariAlat)
        {
            TimeSpan selisih = TglSelesai.Date - TglMulai.Date;
            this.DurasiHari = selisih.Days <= 0 ? 1 : selisih.Days;
            this.TotalHarga = this.DurasiHari * hargaPerHariAlat;
            return this.TotalHarga;
        }

        public void Verifikasi(bool ok)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                using var trans = conn.BeginTransaction();

                string queryData = "SELECT id_alat, tgl_mulai, tgl_selesai, status FROM penyewaan WHERE id_penyewaan = @id";
                int idAlat = 0;
                DateTime tglMulai = DateTime.MinValue;
                DateTime tglSelesai = DateTime.MinValue;
                string statusLama = "";

                using (var cmdData = new NpgsqlCommand(queryData, conn, trans))
                {
                    cmdData.Parameters.AddWithValue("id", this.IdPenyewaan);
                    using var reader = cmdData.ExecuteReader();
                    if (reader.Read())
                    {
                        idAlat = Convert.ToInt32(reader["id_alat"]);

                        var tglMulaiRaw = reader["tgl_mulai"];
                        if (tglMulaiRaw is DateOnly doMulai)
                            tglMulai = doMulai.ToDateTime(TimeOnly.MinValue);
                        else
                            tglMulai = Convert.ToDateTime(tglMulaiRaw);

                        var tglSelesaiRaw = reader["tgl_selesai"];
                        if (tglSelesaiRaw is DateOnly doSelesai)
                            tglSelesai = doSelesai.ToDateTime(TimeOnly.MinValue);
                        else
                            tglSelesai = Convert.ToDateTime(tglSelesaiRaw);

                        statusLama = reader["status"].ToString();
                    }
                }

                if (ok && statusLama != "Disetujui" && statusLama != "Berlangsung")
                {
                    string queryCekStok = @"
                        SELECT a.stok - COALESCE(COUNT(p.id_penyewaan), 0) AS tersedia
                        FROM alat a
                        LEFT JOIN penyewaan p ON a.id_alat = p.id_alat 
                          AND p.status IN ('Disetujui', 'Berlangsung')
                          AND p.tgl_mulai <= @tgl_selesai 
                          AND p.tgl_selesai >= @tgl_mulai
                        WHERE a.id_alat = @id_alat
                        GROUP BY a.stok";

                    int stokTersedia = 0;
                    using (var cmdCek = new NpgsqlCommand(queryCekStok, conn, trans))
                    {
                        cmdCek.Parameters.AddWithValue("id_alat", idAlat);
                        cmdCek.Parameters.AddWithValue("tgl_mulai", tglMulai.Date);
                        cmdCek.Parameters.AddWithValue("tgl_selesai", tglSelesai.Date);
                        object res = cmdCek.ExecuteScalar();
                        stokTersedia = res != null ? Convert.ToInt32(res) : 0;
                    }

                    if (stokTersedia <= 0)
                    {
                        MessageBox.Show("Gagal menyetujui! Stok alat ini sudah habis terpakai atau dibooking oleh penyewa lain pada jadwal tersebut.", "Stok Habis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        trans.Rollback();
                        return;
                    }
                }

                this.Status = ok ? "Disetujui" : "Ditolak";

                string queryUpdateSewa = "UPDATE penyewaan SET status = @status WHERE id_penyewaan = @id";
                using (var cmdUpdate = new NpgsqlCommand(queryUpdateSewa, conn, trans))
                {
                    cmdUpdate.Parameters.AddWithValue("status", this.Status);
                    cmdUpdate.Parameters.AddWithValue("id", this.IdPenyewaan);
                    cmdUpdate.ExecuteNonQuery();
                }

                string statusBayarBaru = ok ? "Lunas" : "Ditolak";
                string queryUpdateBayar = "UPDATE pembayaran SET status = @status WHERE id_penyewaan = @id";
                using (var cmdBayar = new NpgsqlCommand(queryUpdateBayar, conn, trans))
                {
                    cmdBayar.Parameters.AddWithValue("status", statusBayarBaru);
                    cmdBayar.Parameters.AddWithValue("id", this.IdPenyewaan);
                    cmdBayar.ExecuteNonQuery();
                }

                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memproses verifikasi: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool BuatPesanan(int idMetode, bool langsung, string pathBukti = null)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                using var trans = conn.BeginTransaction();

                string queryCekStok = @"
                    SELECT a.stok - COALESCE(COUNT(p.id_penyewaan), 0) AS tersedia
                    FROM alat a
                    LEFT JOIN penyewaan p ON a.id_alat = p.id_alat 
                      AND p.status IN ('Disetujui', 'Berlangsung')
                      AND p.tgl_mulai <= @tgl_selesai 
                      AND p.tgl_selesai >= @tgl_mulai
                    WHERE a.id_alat = @id_alat
                    GROUP BY a.stok";

                int stokTersedia = 0;
                using (var cmdCek = new NpgsqlCommand(queryCekStok, conn, trans))
                {
                    cmdCek.Parameters.AddWithValue("id_alat", this.IdAlat);
                    cmdCek.Parameters.AddWithValue("tgl_mulai", this.TglMulai.Date);
                    cmdCek.Parameters.AddWithValue("tgl_selesai", this.TglSelesai.Date);
                    object res = cmdCek.ExecuteScalar();
                    stokTersedia = res != null ? Convert.ToInt32(res) : 0;
                }

                if (stokTersedia <= 0)
                {
                    MessageBox.Show("Maaf, stok alat sudah tidak tersedia untuk tanggal tersebut!", "Gagal Sewa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    trans.Rollback();
                    return false;
                }

                this.Status = langsung ? "Disetujui" : "Menunggu";

                string querySewa = @"INSERT INTO penyewaan (id_penyewa, id_alat, tgl_mulai, tgl_selesai, durasi_hari, total_harga, status, catatan)
                                     VALUES (@id_penyewa, @id_alat, @tgl_mulai, @tgl_selesai, @durasi_hari, @total_harga, @status, @catatan)
                                     RETURNING id_penyewaan";

                int idSewaBaru = 0;
                using (var cmdSewa = new NpgsqlCommand(querySewa, conn, trans))
                {
                    cmdSewa.Parameters.AddWithValue("id_penyewa", this.IdPenyewa);
                    cmdSewa.Parameters.AddWithValue("id_alat", this.IdAlat);
                    cmdSewa.Parameters.AddWithValue("tgl_mulai", this.TglMulai.Date);
                    cmdSewa.Parameters.AddWithValue("tgl_selesai", this.TglSelesai.Date);
                    cmdSewa.Parameters.AddWithValue("durasi_hari", this.DurasiHari);
                    cmdSewa.Parameters.AddWithValue("total_harga", this.TotalHarga);
                    cmdSewa.Parameters.AddWithValue("status", this.Status);
                    cmdSewa.Parameters.AddWithValue("catatan", this.Catatan ?? (object)DBNull.Value);

                    idSewaBaru = Convert.ToInt32(cmdSewa.ExecuteScalar());
                }

                string statusBayarAwal = langsung ? "Lunas" : "Menunggu Konfirmasi";
                object tglBayarAwal = langsung ? (object)DateTime.Now : DBNull.Value;
                object buktiAwal = !string.IsNullOrEmpty(pathBukti) ? (object)pathBukti : DBNull.Value;

                string queryPembayaran = @"INSERT INTO pembayaran (id_penyewaan, id_metode, jumlah, status, tgl_bayar, bukti_transfer)
                                           VALUES (@id_sewa, @id_metode, @jumlah, @status_bayar, @tgl_bayar, @bukti)";

                using (var cmdBayar = new NpgsqlCommand(queryPembayaran, conn, trans))
                {
                    cmdBayar.Parameters.AddWithValue("id_sewa", idSewaBaru);
                    cmdBayar.Parameters.AddWithValue("id_metode", idMetode);
                    cmdBayar.Parameters.AddWithValue("jumlah", this.TotalHarga);
                    cmdBayar.Parameters.AddWithValue("status_bayar", statusBayarAwal);
                    cmdBayar.Parameters.AddWithValue("tgl_bayar", tglBayarAwal);
                    cmdBayar.Parameters.AddWithValue("bukti", buktiAwal);
                    cmdBayar.ExecuteNonQuery();
                }

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal melakukan query database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool BatalkanPesananPenyewa(int idPenyewaan)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                using var trans = conn.BeginTransaction();

                string querySewa = "UPDATE penyewaan SET status = 'Dibatalkan' WHERE id_penyewaan = @id_penyewaan";
                using (var cmdSewa = new NpgsqlCommand(querySewa, conn, trans))
                {
                    cmdSewa.Parameters.AddWithValue("id_penyewaan", idPenyewaan);
                    cmdSewa.ExecuteNonQuery();
                }

                string queryBayar = "UPDATE pembayaran SET status = 'Dibatalkan' WHERE id_penyewaan = @id_penyewaan";
                using (var cmdBayar = new NpgsqlCommand(queryBayar, conn, trans))
                {
                    cmdBayar.Parameters.AddWithValue("id_penyewaan", idPenyewaan);
                    cmdBayar.ExecuteNonQuery();
                }

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal query batal pesanan ke database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable AmbilSemuaDataSewa()
        {
            DataTable dt = new DataTable();
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string query = @"
                SELECT p.id_penyewaan AS IdPenyewaan, 
                       u.nama AS NamaPenyewa, 
                       a.nama_alat AS NamaAlat, 
                       p.tgl_mulai AS TglMulai, 
                       p.tgl_selesai AS TglSelesai, 
                       p.total_harga AS TotalHarga, 
                       p.status AS Status
                FROM penyewaan p
                JOIN penyewa py ON p.id_penyewa = py.id_penyewa
                JOIN ""user"" u ON py.id_user = u.id_user
                JOIN alat a ON p.id_alat = a.id_alat
                ORDER BY p.id_penyewaan DESC";

            using var cmd = new NpgsqlCommand(query, conn);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static Dictionary<string, object> AmbilStatistikBeranda(int idUser)
        {
            var statistik = new Dictionary<string, object>
            {
                ["SewaAktif"] = 0,
                ["MenungguVerifikasi"] = 0,
                ["Selesai"] = 0,
                ["TotalBelanja"] = 0L
            };

            int idPenyewa = AmbilIdPenyewaDariUser(idUser);

            using var conn = DbHelper.GetConnection();
            conn.Open();

            string qSewaAktif = "SELECT COUNT(*) FROM penyewaan WHERE id_penyewa = @id AND status = 'Berlangsung'";
            using (var cmd = new NpgsqlCommand(qSewaAktif, conn))
            {
                cmd.Parameters.AddWithValue("id", idPenyewa);
                statistik["SewaAktif"] = Convert.ToInt32(cmd.ExecuteScalar());
            }

            string qMenunggu = "SELECT COUNT(*) FROM penyewaan WHERE id_penyewa = @id AND status = 'Menunggu'";
            using (var cmd = new NpgsqlCommand(qMenunggu, conn))
            {
                cmd.Parameters.AddWithValue("id", idPenyewa);
                statistik["MenungguVerifikasi"] = Convert.ToInt32(cmd.ExecuteScalar());
            }

            string qSelesai = "SELECT COUNT(*) FROM penyewaan WHERE id_penyewa = @id AND status = 'Selesai'";
            using (var cmd = new NpgsqlCommand(qSelesai, conn))
            {
                cmd.Parameters.AddWithValue("id", idPenyewa);
                statistik["Selesai"] = Convert.ToInt32(cmd.ExecuteScalar());
            }

            string qTotalBelanja = "SELECT COALESCE(SUM(total_harga), 0) FROM penyewaan WHERE id_penyewa = @id AND (status = 'Selesai' OR status = 'Disetujui')";
            using (var cmd = new NpgsqlCommand(qTotalBelanja, conn))
            {
                cmd.Parameters.AddWithValue("id", idPenyewa);
                statistik["TotalBelanja"] = Convert.ToInt64(cmd.ExecuteScalar());
            }

            return statistik;
        }

        public static Dictionary<string, object> AmbilRingkasanBisnisAdmin()
        {
            var ringkasan = new Dictionary<string, object>
            {
                ["TotalAlat"] = 0,
                ["PengajuanBaru"] = 0,
                ["Pendapatan"] = 0M
            };

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                string qAlat = "SELECT COUNT(*) FROM alat";
                using (var cmd = new NpgsqlCommand(qAlat, conn))
                {
                    ringkasan["TotalAlat"] = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string qSewa = "SELECT COUNT(*) FROM penyewaan WHERE status = 'Menunggu'";
                using (var cmd = new NpgsqlCommand(qSewa, conn))
                {
                    ringkasan["PengajuanBaru"] = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string qIncome = "SELECT COALESCE(SUM(jumlah), 0) FROM pembayaran WHERE status = 'Lunas' OR status = 'Disetujui'";
                using (var cmd = new NpgsqlCommand(qIncome, conn))
                {
                    ringkasan["Pendapatan"] = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
            catch (Exception) { }

            return ringkasan;
        }

        public static DataTable AmbilRiwayatSewaPenyewa(int idUser)
        {
            DataTable dt = new DataTable();
            int idPenyewa = AmbilIdPenyewaDariUser(idUser);

            using var conn = DbHelper.GetConnection();
            conn.Open();

            string query = @"
                SELECT p.id_penyewaan AS ""IdTransaksi"", 
                       a.nama_alat AS ""NamaAlatPertanian"", 
                       u_pemilik.nama AS ""Pemilik"", 
                       CONCAT(TO_CHAR(p.tgl_mulai, 'YYYY-MM-DD'), ' - ', TO_CHAR(p.tgl_selesai, 'YYYY-MM-DD')) AS ""PeriodeSewa"",
                       p.total_harga AS ""TotalBiaya"", 
                       p.status AS ""StatusAlat""
                FROM penyewaan p
                JOIN alat a ON p.id_alat = a.id_alat
                JOIN ""user"" u_pemilik ON a.id_pemilik = u_pemilik.id_user
                WHERE p.id_penyewa = @id_penyewa
                ORDER BY p.id_penyewaan DESC";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_penyewa", idPenyewa);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}