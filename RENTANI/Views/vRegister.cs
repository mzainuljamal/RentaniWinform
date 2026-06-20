using System;
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
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            // Menambahkan validasi wajib isi untuk NIK dan Pekerjaan
            if (string.IsNullOrWhiteSpace(rNaleng.Text) ||
                string.IsNullOrWhiteSpace(rUname.Text) ||
                string.IsNullOrWhiteSpace(rPw.Text) ||
                string.IsNullOrWhiteSpace(txtNik.Text) ||
                string.IsNullOrWhiteSpace(txtPekerjaan.Text))
            {
                MessageBox.Show("Nama Lengkap, Username, Password, NIK, dan Pekerjaan wajib diisi ya!", "Validasi Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnDaftar.Enabled = false;

                // OOP IMPLEMENTATION: Membuat spesifik objek Penyewa lengkap dengan data profil sekundernya
                Penyewa penyewaBaru = new Penyewa();
                penyewaBaru.Nama = rNaleng.Text;
                penyewaBaru.Username = rUname.Text;
                penyewaBaru.Password = rPw.Text;
                penyewaBaru.Email = rEmail.Text;
                penyewaBaru.NoHp = rNoHP.Text;
                penyewaBaru.Alamat = guna2TextBox1.Text;
                penyewaBaru.Nik = txtNik.Text;     
                penyewaBaru.Pekerjaan = txtPekerjaan.Text;  

                AutentikasiController auth = new AutentikasiController();
                bool berhasil = auth.RegisterPenyewa(penyewaBaru);

                if (berhasil)
                {
                    MessageBox.Show("Akun Penyewa berhasil didaftarkan! Silakan masuk kembali.", "Registrasi Berhasil",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
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
            this.Close();
        }

        private void rNaleng_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }
        private void rEmail_TextChanged(object sender, EventArgs e) { }
        private void rNoHP_TextChanged(object sender, EventArgs e) { }
        private void rUname_TextChanged(object sender, EventArgs e) { }
        private void rPw_TextChanged(object sender, EventArgs e) { }
        private void txtPekerjaan_TextChanged(object sender, EventArgs e) { }
        private void txtNik_TextChanged(object sender, EventArgs e) { }
    }
}