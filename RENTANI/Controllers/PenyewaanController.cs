using System;
using System.Data;
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
                System.Windows.Forms.MessageBox.Show($"Gagal mengambil pengajuan sewa: {ex.Message}", "Error",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
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
                System.Windows.Forms.MessageBox.Show($"Gagal memproses verifikasi: {ex.Message}", "Error",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}