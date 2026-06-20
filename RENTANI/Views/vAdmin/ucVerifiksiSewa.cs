using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RentaniApp.Controllers;

namespace RentaniApp.Views.vAdmin
{
    public partial class ucVerifiksiSewa : UserControl
    {
        private readonly PenyewaanController _penyewaanController = new PenyewaanController();

        public ucVerifiksiSewa()
        {
            InitializeComponent();
        }

        private void ucVerifiksiSewa_Load(object sender, EventArgs e)
        {
            TampilkanDataPengajuan();
        }

        private void TampilkanDataPengajuan()
        {
            dgvVerifikasi.AutoGenerateColumns = false;

            DataTable dt = _penyewaanController.AmbilSemuaPengajuanSewa();

            if (dgvVerifikasi.Columns.Count >= 7)
            {
                dgvVerifikasi.Columns[0].DataPropertyName = "IdPenyewaan";
                dgvVerifikasi.Columns[1].DataPropertyName = "NamaPenyewa";
                dgvVerifikasi.Columns[2].DataPropertyName = "NamaAlat";
                dgvVerifikasi.Columns[3].DataPropertyName = "TglMulai";
                dgvVerifikasi.Columns[4].DataPropertyName = "TglSelesai";
                dgvVerifikasi.Columns[5].DataPropertyName = "TotalHarga";
                dgvVerifikasi.Columns[6].DataPropertyName = "Status";
            }

            dgvVerifikasi.DataSource = dt;

            foreach (DataGridViewRow row in dgvVerifikasi.Rows)
            {
                if (dgvVerifikasi.Columns.Contains("btnSetujuCol"))
                    row.Cells["btnSetujuCol"].Value = "✔";

                if (dgvVerifikasi.Columns.Contains("btnTolakCol"))
                    row.Cells["btnTolakCol"].Value = "❌";
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvVerifikasi.Rows[e.RowIndex].DataBoundItem is DataRowView rowView)
            {
                string statusSaatIni = rowView["Status"]?.ToString() ?? "";
                if (statusSaatIni.Equals("Disetujui", StringComparison.OrdinalIgnoreCase) ||
                    statusSaatIni.Equals("Ditolak", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Transaksi ini sudah selesai diproses dan tidak dapat diubah lagi!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idPenyewaan = Convert.ToInt32(rowView["IdPenyewaan"]);
                string namaPenyewa = rowView["NamaPenyewa"]?.ToString() ?? "Penyewa";

                if (dgvVerifikasi.Columns[e.ColumnIndex].Name == "btnSetujuCol")
                {
                    DialogResult res = MessageBox.Show($"Apakah Anda yakin ingin MENYETUJUI pengajuan sewa dari {namaPenyewa}?", "Konfirmasi Setuju", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        if (_penyewaanController.ProsesVerifikasi(idPenyewaan, true))
                        {
                            MessageBox.Show("Pengajuan sewa berhasil disetujui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TampilkanDataPengajuan();
                        }
                    }
                }

                if (dgvVerifikasi.Columns[e.ColumnIndex].Name == "btnTolakCol")
                {
                    DialogResult res = MessageBox.Show($"Apakah Anda yakin ingin MENOLAK pengajuan sewa dari {namaPenyewa}?", "Konfirmasi Tolak", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        if (_penyewaanController.ProsesVerifikasi(idPenyewaan, false))
                        {
                            MessageBox.Show("Pengajuan sewa telah ditolak.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TampilkanDataPengajuan();
                        }
                    }
                }
            }
        }

        private void dgvVerifikasi_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && (dgvVerifikasi.Columns[e.ColumnIndex].Name == "btnSetujuCol" ||
                                    dgvVerifikasi.Columns[e.ColumnIndex].Name == "btnTolakCol"))
            {
                dgvVerifikasi.Cursor = Cursors.Hand;
            }
            else
            {
                dgvVerifikasi.Cursor = Cursors.Default;
            }
        }
    }
}