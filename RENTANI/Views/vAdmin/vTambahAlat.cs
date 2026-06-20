using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using RentaniApp.Controllers;
using RentaniApp.Helpers;
using RentaniApp.Models;

namespace RentaniApp.Views.vAdmin
{
    public partial class vTambahAlat : Form
    {
        private byte[] rawGambar = null;

        public vTambahAlat()
        {
            InitializeComponent();
        }

        private void AmbilFotoAlat()
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbFotoAlat.Image = Image.FromFile(ofd.FileName);
                    rawGambar = File.ReadAllBytes(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal memuat gambar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int GetOrInsertKategoriId(string namaKategori)
        {
            int idKategori = 0;
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                string checkQuery = "SELECT id_kategori FROM kategori_alat WHERE LOWER(nama_kategori) = LOWER(@nama)";
                using (var cmdCheck = new NpgsqlCommand(checkQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("nama", namaKategori);
                    var result = cmdCheck.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }

                string insertQuery = "INSERT INTO kategori_alat (nama_kategori) VALUES (@nama) RETURNING id_kategori";
                using (var cmdInsert = new NpgsqlCommand(insertQuery, conn))
                {
                    cmdInsert.Parameters.AddWithValue("nama", namaKategori);
                    idKategori = Convert.ToInt32(cmdInsert.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error Kategori Cek: " + ex.Message);
            }
            return idKategori;
        }

        private void btnKlikUploudFoto_Click(object sender, EventArgs e)
        {
            AmbilFotoAlat();
        }

        private void pbFotoAlat_Click(object sender, EventArgs e)
        {
            AmbilFotoAlat();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string namaAlat = txtNamaAlat.Text.Trim();
            string namaKategori = txtKategori.Text.Trim();
            string hargaStr = txtHargaPerHari.Text.Trim();
            string stokStr = txtStok.Text.Trim();
            string kondisi = cmbKondisi.SelectedItem?.ToString() ?? "Baik";
            string status = cmbStatus.SelectedItem?.ToString() ?? "Tersedia";

            if (string.IsNullOrEmpty(namaAlat) || string.IsNullOrEmpty(namaKategori) || string.IsNullOrEmpty(hargaStr) || string.IsNullOrEmpty(stokStr))
            {
                MessageBox.Show("Semua kolom isian wajib diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(hargaStr, out decimal hargaPerHari) || hargaPerHari < 0)
            {
                MessageBox.Show("Format harga tidak valid!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(stokStr, out int stok) || stok < 0)
            {
                MessageBox.Show("Format stok tidak valid!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rawGambar == null || rawGambar.Length == 0)
            {
                MessageBox.Show("Wajib memilih atau mengunggah foto alat!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idKategori = GetOrInsertKategoriId(namaKategori);
            if (idKategori <= 0)
            {
                MessageBox.Show("Gagal memproses kategori alat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idPemilik = AppSession.CurrentUser != null ? AppSession.CurrentUser.Id : 1;

            Alat alatBaru = new Alat
            {
                IdPemilik = idPemilik,
                IdKategori = idKategori,
                NamaAlat = namaAlat,
                Deskripsi = "",
                HargaPerHari = hargaPerHari,
                Stok = stok,
                Kondisi = kondisi,
                GambarPath = rawGambar,
                Status = status
            };

            AlatController controller = new AlatController();
            if (controller.TambahAlatBaru(alatBaru))
            {
                MessageBox.Show("Data alat pertanian baru berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSilang_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtNamaAlat_TextChanged(object sender, EventArgs e) { }
        private void txtKategori_TextChanged(object sender, EventArgs e) { }
        private void txtHargaPerHari_TextChanged(object sender, EventArgs e) { }
        private void txtStok_TextChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void cmbKondisi_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}