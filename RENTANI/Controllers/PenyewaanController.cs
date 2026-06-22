using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using RentaniApp.Helpers;
using RentaniApp.Models;

namespace RentaniApp.Controllers
{
    public class PenyewaanController
    {
        public DataTable AmbilSemuaPengajuanSewa()
        {
            try
            {
                return Penyewaan.AmbilSemuaDataSewa();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengambil pengajuan sewa: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public bool ProsesVerifikasi(int idPenyewaan, bool apakahDisetujui)
        {
            try
            {
                Penyewaan sewa = new Penyewaan { IdPenyewaan = idPenyewaan };
                sewa.Verifikasi(apakahDisetujui);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memproses verifikasi: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool KirimPengajuanSewa(int idAlat, DateTime tglMulai, DateTime tglSelesai, int idMetode, string catatanTambahan, decimal hargaPerHari, bool langsung)
        {
            try
            {
                if (tglSelesai.Date < tglMulai.Date)
                {
                    MessageBox.Show("Tanggal selesai tidak boleh mendahului tanggal mulai!", "Validasi Gagal",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!AppSession.IsLoggedIn())
                {
                    MessageBox.Show("Sesi login berakhir. Silakan login kembali.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                int idUserAktif = AppSession.CurrentUser.Id;

                int idPenyewa = CariIdPenyewaDariUser(idUserAktif);
                if (idPenyewa == 0)
                {
                    MessageBox.Show("Profil Penyewa tidak ditemukan di database!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Penyewaan sewaBaru = new Penyewaan
                {
                    IdPenyewa = idPenyewa,
                    IdAlat = idAlat,
                    TglMulai = tglMulai.Date,
                    TglSelesai = tglSelesai.Date,
                    Catatan = catatanTambahan
                };

                sewaBaru.HitungTotal(hargaPerHari);

                return sewaBaru.BuatPesanan(idMetode, langsung, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan sistem: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private int CariIdPenyewaDariUser(int idUser)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();
            string query = "SELECT id_penyewa FROM penyewa WHERE id_user = @id_user";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_user", idUser);

            object result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public DataTable AmbilRiwayatSewaPenyewa(int idUser)
        {
            try
            {
                int idPenyewaAsli = CariIdPenyewaDariUser(idUser);
                if (idPenyewaAsli == 0)
                {
                    idPenyewaAsli = idUser;
                }
                return Penyewaan.AmbilRiwayatSewaPenyewa(idPenyewaAsli);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengambil riwayat sewa: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
    }
}