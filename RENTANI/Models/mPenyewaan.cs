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
        public int? IdRating { get; set; }
        public string KomentarUlasan { get; set; }
        public DateTime? TglUlasan { get; set; }

        public Penyewaan() { }

        // FUNGSI PENYELAMAT: Mengubah ID User dari login session menjadi ID Penyewa asli di database
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
            this.Status = ok ? "Disetujui" : "Ditolak";
            UpdateStatusKeDb();
        }

        public bool BuatPesanan(int idMetode)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                using var trans = conn.BeginTransaction();

                this.Status = "Menunggu";

                string querySewa = @"INSERT INTO penyewaan (id_penyewa, id_alat, tgl_mulai, tgl_selesai, durasi_hari, total_harga, status, catatan)
                                     VALUES (@id_penyewa, @id_alat, @tgl_mulai, @tgl_selesai, @durasi_hari, @total_harga, @status, @catatan)
                                     RETURNING id_penyewaan";

                int idSewaBaru = 0;
                using (var cmdSewa = new NpgsqlCommand(querySewa, conn, trans))
                {
                    cmdSewa.Parameters.AddWithValue("id_penyewa", this.IdPenyewa);
                    cmdSewa.Parameters.AddWithValue("id_alat", this.IdAlat);
                    cmdSewa.Parameters.AddWithValue("tgl_mulai", this.TglMulai);
                    cmdSewa.Parameters.AddWithValue("tgl_selesai", this.TglSelesai);
                    cmdSewa.Parameters.AddWithValue("durasi_hari", this.DurasiHari);
                    cmdSewa.Parameters.AddWithValue("total_harga", this.TotalHarga);
                    cmdSewa.Parameters.AddWithValue("status", this.Status);
                    cmdSewa.Parameters.AddWithValue("catatan", this.Catatan ?? (object)DBNull.Value);

                    idSewaBaru = Convert.ToInt32(cmdSewa.ExecuteScalar());
                }

                string queryPembayaran = @"INSERT INTO pembayaran (id_penyewaan, id_metode, jumlah, status, tgl_bayar)
                                           VALUES (@id_sewa, @id_metode, @jumlah, 'Menunggu Konfirmasi', @tgl_bayar)";

                using (var cmdBayar = new NpgsqlCommand(queryPembayaran, conn, trans))
                {
                    cmdBayar.Parameters.AddWithValue("id_sewa", idSewaBaru);
                    cmdBayar.Parameters.AddWithValue("id_metode", idMetode);
                    cmdBayar.Parameters.AddWithValue("jumlah", this.TotalHarga);
                    cmdBayar.Parameters.AddWithValue("tgl_bayar", DateTime.Now);
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

        private void UpdateStatusKeDb()
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();
            string query = "UPDATE penyewaan SET status = @status WHERE id_penyewaan = @id";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("status", this.Status);
            cmd.Parameters.AddWithValue("id", this.IdPenyewaan);
            cmd.ExecuteNonQuery();
        }

        public static DataTable AmbilSemuaDataSewa()
        {
            DataTable dt = new DataTable();
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string query = @"
                SELECT p.id_penyewaan AS ""IdPenyewaan"", 
                       u.nama AS ""NamaPenyewa"", 
                       a.nama_alat AS ""NamaAlat"", 
                       p.tgl_mulai AS ""TglMulai"", 
                       p.tgl_selesai AS ""TglSelesai"", 
                       p.total_harga AS ""TotalHarga"", 
                       p.status AS ""Status""
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

        // FIX TOTAL: Mengubah filtering dari id_user yang salah menjadi id_penyewa asli
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

            string qMenunggu = "SELECT COUNT(*) FROM penyewaan WHERE id_penyewa = @id AND (status = 'Menunggu' OR status = 'Disetujui')";
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

        public static DataTable AmbilSemuaUlasanAdmin()
        {
            DataTable dt = new DataTable();
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string query = @"
                SELECT u.nama AS ""NamaPenyewa"", 
                       a.nama_alat AS ""NamaAlat"", 
                       p.komentar_ulasan AS ""KomentarUlasan"", 
                       p.tgl_ulasan AS ""TglUlasan"",
                       COALESCE(p.id_rating, 5) AS ""SkorRating""
                FROM penyewaan p
                JOIN penyewa py ON p.id_penyewa = py.id_penyewa
                JOIN ""user"" u ON py.id_user = u.id_user
                JOIN alat a ON p.id_alat = a.id_alat
                WHERE p.komentar_ulasan IS NOT NULL AND p.komentar_ulasan <> ''
                ORDER BY p.tgl_ulasan DESC";

            using var cmd = new NpgsqlCommand(query, conn);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static Dictionary<string, object> AmbilRingkasanUlasanAdmin()
        {
            var ringkasan = new Dictionary<string, object>
            {
                ["TotalUlasan"] = 0,
                ["RatingRataRata"] = 0.0
            };

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                string query = @"
                    SELECT COUNT(komentar_ulasan) AS total_ulasan,
                           COALESCE(AVG(id_rating), 0.0) AS rata_rata
                    FROM penyewaan
                    WHERE komentar_ulasan IS NOT NULL AND komentar_ulasan <> ''";

                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ringkasan["TotalUlasan"] = Convert.ToInt32(reader["total_ulasan"]);
                    ringkasan["RatingRataRata"] = Convert.ToDouble(reader["rata_rata"]);
                }
            }
            catch (Exception)
            {
            }

            return ringkasan;
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
            catch (Exception)
            {
            }

            return ringkasan;
        }

        // FIX TOTAL: Konversi otomatis ID User ke ID Penyewa agar query di Grid tidak kosong atau salah target
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
                JOIN ""user"" u_pemilik ON a.id_user = u_pemilik.id_user
                WHERE p.id_penyewa = @id_penyewa
                ORDER BY p.id_penyewaan DESC";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_penyewa", idPenyewa);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static bool BatalkanPesananPenyewa(int idPenyewaan)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                string query = "UPDATE penyewaan SET status = 'Dibatalkan' WHERE id_penyewaan = @id AND status = 'Menunggu'";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id", idPenyewaan);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}