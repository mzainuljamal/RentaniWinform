using System;
using System.Data;
using System.Windows.Forms;
using RentaniApp.Controllers;
using RentaniApp.Helpers;

namespace RentaniApp.Views.vPenyewa
{
    public partial class ucPenyewaanSaya : UserControl
    {
        private readonly PenyewaanController _controller = new PenyewaanController();
        private int _idUserSaatIni;

        public ucPenyewaanSaya()
        {
            InitializeComponent();
            if (AppSession.IsLoggedIn())
            {
                _idUserSaatIni = AppSession.CurrentUser.Id;
            }
        }

        public void SetIdPenyewa(int idUser)
        {
            _idUserSaatIni = idUser;
            MuatDataRiwayatSewa();
        }

        private void ucPenyewaanSaya_Load(object sender, EventArgs e)
        {
            MuatDataRiwayatSewa();
        }

        private void MuatDataRiwayatSewa()
        {
            try
            {
                DataTable dt = _controller.AmbilRiwayatSewaPenyewa(_idUserSaatIni);
                dgvPenyewaanSaya.DataSource = dt;
                AturLayoutGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyinkronkan data database ke UI: {ex.Message}", "Bypass Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AturLayoutGrid()
        {
            if (dgvPenyewaanSaya.Columns.Contains("IdTransaksi")) dgvPenyewaanSaya.Columns["IdTransaksi"].HeaderText = "ID Transaksi";
            if (dgvPenyewaanSaya.Columns.Contains("NamaAlatPertanian")) dgvPenyewaanSaya.Columns["NamaAlatPertanian"].HeaderText = "Nama Alat Pertanian";
            if (dgvPenyewaanSaya.Columns.Contains("Pemilik")) dgvPenyewaanSaya.Columns["Pemilik"].HeaderText = "Pemilik";
            if (dgvPenyewaanSaya.Columns.Contains("PeriodeSewa")) dgvPenyewaanSaya.Columns["PeriodeSewa"].HeaderText = "Periode Sewa";
            if (dgvPenyewaanSaya.Columns.Contains("TotalBiaya")) dgvPenyewaanSaya.Columns["TotalBiaya"].HeaderText = "Total Biaya";
            if (dgvPenyewaanSaya.Columns.Contains("StatusAlat")) dgvPenyewaanSaya.Columns["StatusAlat"].HeaderText = "Status Alat";

            if (dgvPenyewaanSaya.Columns.Contains("Aksi"))
            {
                dgvPenyewaanSaya.Columns.Remove("Aksi");
            }
        }

        private void dgvPenyewaanSaya_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}