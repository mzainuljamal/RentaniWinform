using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RentaniApp.Controllers;
using RentaniApp.Models;

namespace RentaniApp.Views
{
    public partial class vRegister : Form
    {
        public vRegister()
        {
            InitializeComponent();
        }

        private void vRegister_Load(object sender, EventArgs e)
        {
            // Bisa dikosongkan
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            // 1. Validasi Input Data Wajib
            if (string.IsNullOrWhiteSpace(rNaleng.Text) ||
                string.IsNullOrWhiteSpace(rUname.Text) ||
                string.IsNullOrWhiteSpace(rPw.Text))
            {
                MessageBox.Show("Nama Lengkap, Username, dan Password wajib diisi ya!", "Validasi Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnDaftar.Enabled = false;

                // 2. Bungkus data ke objek Penyewa
                User userBaru = new Penyewa();
                userBaru.Nama = rNaleng.Text;
                userBaru.Username = rUname.Text;
                userBaru.Password = rPw.Text;
                userBaru.Email = rEmail.Text;
                userBaru.NoHp = rNoHP.Text;
                userBaru.Alamat = guna2TextBox1.Text;

                // 3. Kirim ke controller
                AutentikasiController auth = new AutentikasiController();
                bool berhasil = auth.Register(userBaru, "Penyewa");

                if (berhasil)
                {
                    MessageBox.Show("Akun Penyewa berhasil didaftarkan! Silakan masuk kembali.", "Registrasi Berhasil",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close(); // Tutup pop-up dan kembali ke vLogin
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan sistem: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDaftar.Enabled = true;
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Menutup form register ini, otomatis layar balik ke vLogin yang ada di belakangnya
            this.Close();
        }

        private void rNaleng_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }
        private void rEmail_TextChanged(object sender, EventArgs e) { }
        private void rNoHP_TextChanged(object sender, EventArgs e) { }
        private void rUname_TextChanged(object sender, EventArgs e) { }
        private void rPw_TextChanged(object sender, EventArgs e) { }
    }
}