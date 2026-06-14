using RentaniApp.Controllers;
using RentaniApp.Views.vAdmin;
using RentaniApp.Models;
using Npgsql;

namespace RentaniApp.Views
{
    public partial class vLogin : Form
    {
        private readonly AutentikasiController _authController;

        public vLogin()
        {
            InitializeComponent();
            _authController = new AutentikasiController();
        }

        private void vLogin_Load(object sender, EventArgs e)
        {
            // Kursor langsung fokus ke kotak username saat app dibuka
            txtUsername.Focus();
        }

        // --- LOGIKA TOMBOL LOGIN ---
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AutentikasiController authController = new AutentikasiController();
            User userLogin = authController.Login(username, password);

            if (userLogin != null)
            {
                MessageBox.Show($"Selamat Datang, {userLogin.Nama}!", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Memanfaatkan Polymorphism (.GetRole()) sesuai class modelmu
                if (userLogin.GetRole() == "Pemilik")
                {
                    vBerandaAdmin berandaAdmin = new vBerandaAdmin();
                    berandaAdmin.Show();
                    this.Hide();
                }
                else // Jika Penyewa
                {
                    MessageBox.Show("Login sebagai Penyewa berhasil! (Form Penyewa belum dihubungkan)", "Info Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Username atau password salah / tidak terdaftar!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vRegister daftar = new vRegister();
            daftar.Show();
            this.Hide();
        }

        // Biarkan kosong saja, jangan dihapus supaya desainer tidak error lagi
        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }

        private void vLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}