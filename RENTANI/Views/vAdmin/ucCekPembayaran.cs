using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using RentaniApp.Controllers;
using RentaniApp.Models;

namespace RentaniApp.Views.vAdmin
{
    public partial class ucCekPembayaran : UserControl
    {
        private readonly PembayaranController _pembayaranController = new PembayaranController();

        public ucCekPembayaran()
        {
            InitializeComponent();

            dgvPembayaran.ReadOnly = false;
            dgvPembayaran.CellContentClick -= dgvPembayaran_CellContentClick;
            dgvPembayaran.CellContentClick += dgvPembayaran_CellContentClick;
        }

        private void ucCekPembayaran_Load(object sender, EventArgs e)
        {
            TampilkanDataPembayaran();
        }

        public void TampilkanDataPembayaran()
        {
            dgvPembayaran.AutoGenerateColumns = false;

            DataTable dt = _pembayaranController.AmbilDaftarPembayaran();

            idPembayaranCol.DataPropertyName = "IdPembayaran";
            namaPenyewaCol.DataPropertyName = "NamaPenyewa";
            namaAlatCol.DataPropertyName = "NamaAlat";
            jumlahBayarCol.DataPropertyName = "JumlahBayar";
            statusCol.DataPropertyName = "StatusPembayaran";

            dgvPembayaran.DataSource = dt;

            foreach (DataGridViewRow row in dgvPembayaran.Rows)
            {
                if (row.DataBoundItem is DataRowView rowView)
                {
                    string status = rowView["StatusPembayaran"]?.ToString() ?? "";
                    string metode = rowView["MetodeBayar"]?.ToString() ?? "";

                    if (metode.Equals("COD", StringComparison.OrdinalIgnoreCase))
                    {
                        row.Cells["viewBuktiCol"].Value = null;
                    }
                    else
                    {
                        row.Cells["viewBuktiCol"].Value = Properties.Resources.Group__3_;
                    }

                    if (status.Equals("Lunas", StringComparison.OrdinalIgnoreCase))
                    {
                        row.Cells["btnVerifikasiCol"].Value = null;
                    }
                    else
                    {
                        row.Cells["btnVerifikasiCol"].Value = Properties.Resources.Group__4_;
                    }
                }
            }
        }

        private void dgvPembayaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPembayaran.Rows[e.RowIndex].DataBoundItem is DataRowView rowView)
            {
                int idPembayaran = Convert.ToInt32(rowView["IdPembayaran"]);
                int idPenyewaan = Convert.ToInt32(rowView["IdPenyewaan"]);
                string namaPenyewa = rowView["NamaPenyewa"]?.ToString() ?? "Penyewa";
                string metode = rowView["MetodeBayar"]?.ToString() ?? "Transfer";
                string status = rowView["StatusPembayaran"]?.ToString() ?? "";

                if (e.ColumnIndex == 5)
                {
                    if (metode.Equals("COD", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Metode pembayaran COD tidak menggunakan lampiran berkas bukti transfer fisik.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string pathGambar = string.Empty;
                        if (rowView.Row.Table.Columns.Contains("BuktiBayar") && rowView["BuktiBayar"] != DBNull.Value)
                        {
                            pathGambar = rowView["BuktiBayar"].ToString();
                        }

                        using (FrmPreviewBukti popUp = new FrmPreviewBukti(pathGambar, idPembayaran.ToString(), namaPenyewa))
                        {
                            popUp.ShowDialog(this);
                        }
                    }
                    return;
                }

                if (e.ColumnIndex == 6)
                {
                    if (status.Equals("Lunas", StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }

                    DialogResult res = MessageBox.Show($"Konfirmasi pemrosesan verifikasi pembayaran via {metode} dari {namaPenyewa}?", "Konfirmasi Verifikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        IPembayaran strategi;

                        if (metode.Equals("COD", StringComparison.OrdinalIgnoreCase))
                        {
                            strategi = new PembayaranCOD();
                        }
                        else
                        {
                            strategi = new PembayaranTransfer();
                        }

                        if (_pembayaranController.ProcessVerifikasiAdmin(strategi, idPenyewaan, idPembayaran))
                        {
                            MessageBox.Show($"Pembayaran via {metode} berhasil diverifikasi!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TampilkanDataPembayaran();
                        }
                    }
                }
            }
        }

        private void dgvPembayaran_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && (dgvPembayaran.Columns[e.ColumnIndex].Name == "btnVerifikasiCol" ||
                                    dgvPembayaran.Columns[e.ColumnIndex].Name == "viewBuktiCol"))
            {
                dgvPembayaran.Cursor = Cursors.Hand;
            }
            else
            {
                dgvPembayaran.Cursor = Cursors.Default;
            }
        }

        private void dgvPembayaran_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}