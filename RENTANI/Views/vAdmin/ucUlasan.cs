using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using RentaniApp.Models;

namespace RentaniApp.Views.vAdmin
{
    public partial class ucUlasan : UserControl
    {
        public ucUlasan()
        {
            InitializeComponent();
        }

        private void ucUlasan_Load(object sender, EventArgs e)
        {
            MuatDataUlasan();
        }

        private void MuatDataUlasan()
        {
            try
            {
                Dictionary<string, object> ringkasan = Penyewaan.AmbilRingkasanUlasanAdmin();

                lblValTotalUlasan.Text = ringkasan["TotalUlasan"].ToString();

                double rating = Convert.ToDouble(ringkasan["RatingRataRata"]);
                lblValRating.Text = rating > 0 ? $"{rating:N1} ★" : "0.0 ★";

                DataTable dtUlasan = Penyewaan.AmbilSemuaUlasanAdmin();
                flpContainerUlasan.Controls.Clear();

                foreach (DataRow row in dtUlasan.Rows)
                {
                    string tglFormatted = row["TglUlasan"] != DBNull.Value
                        ? Convert.ToDateTime(row["TglUlasan"]).ToString("yyyy-MM-dd")
                        : DateTime.Now.ToString("yyyy-MM-dd");

                    Panel pnlItem = BuatItemUlasan(
                        row["NamaPenyewa"].ToString(),
                        row["NamaAlat"].ToString(),
                        row["KomentarUlasan"].ToString(),
                        tglFormatted,
                        Convert.ToInt32(row["SkorRating"])
                    );
                    flpContainerUlasan.Controls.Add(pnlItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyinkronkan data ulasan dari database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel BuatItemUlasan(string nama, string alat, string komentar, string tanggal, int rating)
        {
            Panel pnlCard = new Panel
            {
                Width = 1215,
                Height = 120,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 15),
                Padding = new Padding(15)
            };

            Label lblAvatar = new Label
            {
                Text = !string.IsNullOrEmpty(nama) ? nama.Substring(0, 1).ToUpper() : "U",
                Size = new Size(45, 45),
                Location = new Point(15, 15),
                BackColor = Color.FromArgb(243, 244, 246),
                ForeColor = Color.FromArgb(29, 78, 216),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblNama = new Label
            {
                Text = nama,
                Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(75, 15),
                AutoSize = true
            };

            Label lblAlat = new Label
            {
                Text = $"menyewa {alat}",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(29, 78, 216),
                Location = new Point(75, 38),
                AutoSize = true
            };

            Label lblKomentar = new Label
            {
                Text = $"\"{komentar}\"",
                Font = new Font("Segoe UI", 9.5F, FontStyle.Italic),
                ForeColor = Color.FromArgb(75, 85, 99),
                Location = new Point(75, 65),
                Width = 900,
                Height = 22
            };

            Label lblTanggal = new Label
            {
                Text = tanggal,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(156, 163, 175),
                Location = new Point(75, 90),
                AutoSize = true
            };

            int totalBintang = Math.Clamp(rating, 1, 5);
            string bintang = new string('★', totalBintang);

            Label lblBintang = new Label
            {
                Text = bintang,
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.Orange,
                Location = new Point(1080, 15),
                Width = 120,
                TextAlign = ContentAlignment.TopRight
            };

            pnlCard.Controls.Add(lblAvatar);
            pnlCard.Controls.Add(lblNama);
            pnlCard.Controls.Add(lblAlat);
            pnlCard.Controls.Add(lblKomentar);
            pnlCard.Controls.Add(lblTanggal);
            pnlCard.Controls.Add(lblBintang);

            return pnlCard;
        }
    }
}