using RentaniApp.Controllers;
using RentaniApp.Helpers;
using RentaniApp.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RentaniApp.Views.vPenyewa
{
    public partial class ucPembayaranPenyewa : UserControl
    {
        private readonly PembayaranController _controller;
        private readonly int _idUserAktif;

        public ucPembayaranPenyewa(int idUser)
        {
            InitializeComponent();
            _controller = new PembayaranController();
            _idUserAktif = idUser;

            this.dgvPembayaran.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPembayaran_CellFormatting);
            this.dgvPembayaran.CellContentClick -= this.dgvPembayaran_CellContentClick;
            this.dgvPembayaran.CellContentClick += this.dgvPembayaran_CellContentClick;
        }

        private void ucPembayaranPenyewa_Load(object sender, EventArgs e)
        {
            FormatGridTransaksi();
            MuatDataHalamanPembayaran();
        }

        private void MuatDataHalamanPembayaran()
        {
            try
            {
                int idPenyewaAsli = _idUserAktif;
                using (var conn = RentaniApp.Helpers.DbHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new Npgsql.NpgsqlCommand("SELECT id_penyewa FROM penyewa WHERE id_user = @id_user", conn))
                    {
                        cmd.Parameters.AddWithValue("id_user", _idUserAktif);
                        object result = cmd.ExecuteScalar();
                        if (result != null) idPenyewaAsli = Convert.ToInt32(result);
                    }
                }

                DataTable dtRiwayat = Pembayaran.AmbilRiwayatSewaPenyewa(idPenyewaAsli);
                dgvPembayaran.DataSource = dtRiwayat;

                var statistik = Penyewaan.AmbilStatistikBeranda(idPenyewaAsli);

                int perlumBayar = Convert.ToInt32(statistik["MenungguVerifikasi"]);
                lblPerluBayar.Text = $"{perlumBayar} Transaksi";

                long totalBerhasil = Convert.ToInt64(statistik["TotalBelanja"]);
                lblTotalBerhasilBayar.Text = string.Format("Rp {0:N0}", totalBerhasil);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyegarkan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGridTransaksi()
        {
            dgvPembayaran.AutoGenerateColumns = false;
            dgvPembayaran.Columns.Clear();

            dgvPembayaran.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdSewa",
                HeaderText = "ID Sewa",
                Name = "IdSewa",
                ReadOnly = true
            });

            dgvPembayaran.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AlatPertanian",
                HeaderText = "Alat Pertanian",
                Name = "AlatPertanian",
                ReadOnly = true
            });

            dgvPembayaran.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "JumlahTagihan",
                HeaderText = "Jumlah Tagihan",
                Name = "JumlahTagihan",
                ReadOnly = true
            });

            dgvPembayaran.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StatusBayar",
                HeaderText = "Status",
                Name = "StatusBayar",
                ReadOnly = true
            });

            dgvPembayaran.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Aksi",
                Name = "GridAksi",
                Text = "Aksi",
                UseColumnTextForButtonValue = false
            });
        }

        private void dgvPembayaran_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPembayaran.Columns[e.ColumnIndex].Name == "JumlahTagihan" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal harga))
                {
                    e.Value = string.Format("Rp {0:N0}", harga);
                    e.FormattingApplied = true;
                }
            }

            if (dgvPembayaran.Columns[e.ColumnIndex].Name == "GridAksi")
            {
                string status = dgvPembayaran.Rows[e.RowIndex].Cells["StatusBayar"].Value?.ToString();
                e.Value = (status == "Lunas") ? "Lihat Bukti" : "Bayar Sekarang";
            }
        }

        private void dgvPembayaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPembayaran.Columns[e.ColumnIndex].Name == "GridAksi")
            {
                int idSewa = Convert.ToInt32(dgvPembayaran.Rows[e.RowIndex].Cells["IdSewa"].Value);
                string status = dgvPembayaran.Rows[e.RowIndex].Cells["StatusBayar"].Value?.ToString();

                if (status == "Lunas")
                {
                    var curRow = ((DataRowView)dgvPembayaran.Rows[e.RowIndex].DataBoundItem).Row;
                    if (curRow["BuktiBayar"] != DBNull.Value && !string.IsNullOrWhiteSpace(curRow["BuktiBayar"].ToString()))
                    {
                        string pathGambar = curRow["BuktiBayar"].ToString();
                        try
                        {
                            Form popUpGambar = new Form
                            {
                                Text = $"Bukti Pembayaran ID Sewa: {idSewa}",
                                Size = new Size(500, 600),
                                StartPosition = FormStartPosition.CenterScreen
                            };
                            PictureBox pic = new PictureBox
                            {
                                ImageLocation = pathGambar,
                                Dock = DockStyle.Fill,
                                SizeMode = PictureBoxSizeMode.Zoom
                            };
                            popUpGambar.Controls.Add(pic);
                            popUpGambar.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Gagal memuat file gambar dari path: {pathGambar}\nError: {ex.Message}", "Error Gambar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tidak ada file path bukti transfer (Metode COD / data kosong).", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    string namaAlat = dgvPembayaran.Rows[e.RowIndex].Cells["AlatPertanian"].Value?.ToString() ?? "Alat Pertanian";
                    decimal jumlahTagihan = Convert.ToDecimal(dgvPembayaran.Rows[e.RowIndex].Cells["JumlahTagihan"].Value);

                    AksiBayarSekarang(idSewa, namaAlat, jumlahTagihan);
                }
            }
        }

        private void AksiBayarSekarang(int idSewa, string namaAlat, decimal totalHarga)
        {
            string tanggalMulaiSimulasi = DateTime.Now.ToString("yyyy-MM-dd");
            string tanggalSelesaiSimulasi = DateTime.Now.AddDays(2).ToString("yyyy-MM-dd");
            string stringPeriode = $"{tanggalMulaiSimulasi} sd {tanggalSelesaiSimulasi}";

            using (vBayarSewa formBayar = new vBayarSewa(idSewa, namaAlat, stringPeriode, totalHarga))
            {
                formBayar.ShowDialog();
                MuatDataHalamanPembayaran();
            }
        }
    }
}