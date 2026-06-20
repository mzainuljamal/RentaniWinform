using Npgsql;
using RentaniApp.Controllers;
using RentaniApp.Helpers;
using RentaniApp.Models;
using RentaniApp.Views.vAdmin;
using System;
using System.Windows.Forms;

namespace RentaniApp.Views
{
    public partial class vLogin : Form
    {
        private readonly AutentikasiController _authController;

        public vLogin()
        {
            InitializeComponent();
            _authController = new AutentikasiController();
            this.KeyPreview = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (txtUsername.Focused)
                {
                    txtPassword.Focus();
                    return true;
                }
                else if (txtPassword.Focused)
                {
                    btnLogin.PerformClick();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void vLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

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
                AppSession.StartSession(userLogin);
                MessageBox.Show($"Selamat Datang, {userLogin.Nama}!", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (userLogin.GetRole() == "Pemilik")
                {
                    vBerandaAdmin berandaAdmin = new vBerandaAdmin();
                    berandaAdmin.Show();
                    this.Hide();
                }
                else
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
            daftar.ShowDialog();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void vLogin_Load_1(object sender, EventArgs e) { }
    }
}