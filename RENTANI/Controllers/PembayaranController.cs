using System;
using System.Data;
using System.Windows.Forms;
using RentaniApp.Models;

namespace RentaniApp.Controllers
{
    public class PembayaranController
    {
        public DataTable AmbilDaftarPembayaran()
        {
            try
            {
                return Pembayaran.AmbilSemuaDataPembayaran();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data pembayaran: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        // Sudah diganti dari 'ProcessVerifikasiAdmin' menjadi 'ProsesVerifikasiAdmin'
        public bool ProsesVerifikasiAdmin(IPembayaran strategiPembayaran, int idPenyewaan, int idBayar)
        {
            try
            {
                return strategiPembayaran.Verifikasi(idPenyewaan, idBayar);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memproses verifikasi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable AmbilRiwayatSewaController()
        {
            try
            {
                return Pembayaran.AmbilRiwayatSewa();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat riwayat: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
    }
}