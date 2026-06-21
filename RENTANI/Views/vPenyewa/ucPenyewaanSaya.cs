using System;
using System.Data;
using System.Windows.Forms;
using RentaniApp.Controllers;

namespace RentaniApp.Views.vPenyewa
{
    public partial class ucPenyewaanSaya : UserControl
    {
        private readonly PenyewaanController _controller = new PenyewaanController();
        private int _idPenyewaSaatIni = 1;

        public ucPenyewaanSaya()
        {
            InitializeComponent();
        }

        public void SetIdPenyewa(int idPenyewa)
        {
            _idPenyewaSaatIni = idPenyewa;
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
                DataTable dt = _controller.AmbilRiwayatSewaPenyewa(_idPenyewaSaatIni);
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

            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn
            {
                Name = "Aksi",
                HeaderText = "Aksi",
                Text = "Aksi"
            };
            dgvPenyewaanSaya.Columns.Add(btnCol);

            foreach (DataGridViewRow row in dgvPenyewaanSaya.Rows)
            {
                if (row.Cells["StatusAlat"].Value != null)
                {
                    string status = row.Cells["StatusAlat"].Value.ToString();

                    if (status == "Menunggu")
                    {
                        row.Cells["Aksi"].Value = "Batalkan";
                    }
                    else
                    {
                        row.Cells["Aksi"].Value = "-";
                    }
                }
            }
        }

        private void dgvPenyewaanSaya_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvPenyewaanSaya.Columns["Aksi"].Index) return;

            string aksi = dgvPenyewaanSaya.Rows[e.RowIndex].Cells["Aksi"].Value?.ToString();
            if (aksi != "Batalkan") return;

            int idTransaksi = Convert.ToInt32(dgvPenyewaanSaya.Rows[e.RowIndex].Cells["IdTransaksi"].Value);

            var konfirmasi = MessageBox.Show("Apakah Anda yakin ingin membatalkan pesanan ini?", "Konfirmasi Pembatalan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmasi == DialogResult.Yes)
            {
                if (_controller.BatalkanPesananPenyewa(idTransaksi))
                {
                    MessageBox.Show("Pesanan berhasil dibatalkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MuatDataRiwayatSewa();
                }
            }
        }
    }
}