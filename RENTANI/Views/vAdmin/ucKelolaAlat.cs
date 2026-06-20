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
    public partial class ucKelolaAlat : UserControl
    {
        private readonly AlatController _alatController = new AlatController();

        public ucKelolaAlat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dgvAlat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnTambahAlat_Click(object sender, EventArgs e)
        {
            vTambahAlat popUp = new vTambahAlat();
            if (popUp.ShowDialog() == DialogResult.OK)
            {
                TampilkanDataKeGrid();
            }
        }

        private void ucKelolaAlat_Load(object sender, EventArgs e)
        {
            CustomizeDataGridView();

            int radius = 15;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(dgvAlat.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(dgvAlat.Width - radius, dgvAlat.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, dgvAlat.Height - radius, radius, radius, 90, 90);

            dgvAlat.Region = new Region(gp);
            TampilkanDataKeGrid();
        }

        private void TampilkanDataKeGrid()
        {
            try
            {
                List<Alat> daftarAlat = _alatController.AmbilSemuaAlat();

                dgvAlat.AutoGenerateColumns = false;

                DataTable dt = new DataTable();
                dt.Columns.Add("IdAlat", typeof(int));
                dt.Columns.Add("Gambar", typeof(Image));
                dt.Columns.Add("NamaAlat", typeof(string));
                dt.Columns.Add("Kategori", typeof(string));
                dt.Columns.Add("HargaPerHari", typeof(decimal));
                dt.Columns.Add("Stok", typeof(int));
                dt.Columns.Add("Kondisi", typeof(string));
                dt.Columns.Add("Status", typeof(string));

                foreach (var alat in daftarAlat)
                {
                    Image img = null;
                    if (alat.GambarPath != null && alat.GambarPath.Length > 0)
                    {
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(alat.GambarPath))
                            {
                                img = Image.FromStream(ms);
                            }
                        }
                        catch
                        {
                            img = CreatePlaceholderImage();
                        }
                    }
                    else
                    {
                        img = CreatePlaceholderImage();
                    }

                    string namaKategori = (alat.Kategori != null) ? alat.Kategori.NamaKategori : "-";

                    dt.Rows.Add(alat.IdAlat, img, alat.NamaAlat, namaKategori, alat.HargaPerHari, alat.Stok, alat.Kondisi, alat.Status);
                }

                if (dgvAlat.Columns.Count >= 7)
                {
                    dgvAlat.Columns[0].DataPropertyName = "Gambar";
                    dgvAlat.Columns[1].DataPropertyName = "NamaAlat";
                    dgvAlat.Columns[2].DataPropertyName = "Kategori";
                    dgvAlat.Columns[3].DataPropertyName = "HargaPerHari";
                    dgvAlat.Columns[4].DataPropertyName = "Stok";
                    dgvAlat.Columns[5].DataPropertyName = "Kondisi";
                    dgvAlat.Columns[6].DataPropertyName = "Status";
                }

                dgvAlat.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data alat: {ex.Message}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image CreatePlaceholderImage()
        {
            Bitmap bmp = new Bitmap(50, 50);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                using (Font font = new Font("Arial", 7))
                {
                    g.DrawString("No Img", font, Brushes.DimGray, new PointF(5, 18));
                }
            }
            return bmp;
        }

        private void CustomizeDataGridView()
        {
            dgvAlat.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
            dgvAlat.RowsDefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

            if (dgvAlat.Columns.Count >= 5)
            {
                dgvAlat.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvAlat.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvAlat.Columns.Count >= 1 && dgvAlat.Columns[0] is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void dgvAlat_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // --- LOGIKA TOMBOL HAPUS ---
            if (dgvAlat.Columns[e.ColumnIndex].Name == "btnHapusColumn")
            {
                if (dgvAlat.Rows[e.RowIndex].DataBoundItem is DataRowView rowView)
                {
                    int idAlat = Convert.ToInt32(rowView["IdAlat"]);
                    string namaAlat = rowView["NamaAlat"]?.ToString() ?? "Alat";

                    DialogResult confirm = MessageBox.Show($"Apakah kamu yakin ingin menghapus '{namaAlat}' dari sistem?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        if (_alatController.HapusAlat(idAlat))
                        {
                            MessageBox.Show("Data alat pertanian berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TampilkanDataKeGrid();
                        }
                    }
                }
            }

            // --- LOGIKA TOMBOL EDIT ---
            if (dgvAlat.Columns[e.ColumnIndex].Name == "btnEditColumn")
            {
                if (dgvAlat.Rows[e.RowIndex].DataBoundItem is DataRowView rowView)
                {
                    int idAlat = Convert.ToInt32(rowView["IdAlat"]);
                    string nama = rowView["NamaAlat"]?.ToString() ?? "";
                    string kategori = rowView["Kategori"]?.ToString() ?? "";
                    decimal harga = Convert.ToDecimal(rowView["HargaPerHari"]);
                    int stok = Convert.ToInt32(rowView["Stok"]);
                    string kondisi = rowView["Kondisi"]?.ToString() ?? "Baik";
                    string status = rowView["Status"]?.ToString() ?? "Tersedia";

                    Image gambarOriginal = rowView["Gambar"] as Image;
                    Image gambarClone = null;
                    if (gambarOriginal != null)
                    {
                        gambarClone = new Bitmap(gambarOriginal);
                    }

                    vEditAlat popUp = new vEditAlat(idAlat, nama, kategori, harga, stok, kondisi, status, gambarClone);
                    if (popUp.ShowDialog() == DialogResult.OK)
                    {
                        TampilkanDataKeGrid();
                    }
                }
            }
        }
    }
}