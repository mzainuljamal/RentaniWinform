using Microsoft.VisualBasic.ApplicationServices;
using RentaniApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace RentaniApp.Views.vAdmin
{
    public partial class vBerandaAdmin : Form
    {
        public vBerandaAdmin()
        {
            InitializeComponent();
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {

        }

        private void panelKonten_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vBerandaAdmin_Load(object sender, EventArgs e)
        {
            label2.Text = "Selamat Datang, " + AppSession.CurrentUser.Nama;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            // 1. Tampilkan konfirmasi biar gak sengaja ke-klik logout
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Cari form login yang sebelumnya kita sembunyikan (Hide)
                Form formLogin = null;
                foreach (Form f in Application.OpenForms)
                {
                    // Sesuaikan dengan nama class Form Login kamu (misal: vLogin)
                    if (f.Name == "vLogin")
                    {
                        formLogin = f;
                        break;
                    }
                }

                // 3. Jika form login ketemu di memori, tampilkan lagi. 
                // Jika tidak ketemu (misal karena terhapus), buat instance baru.
                if (formLogin != null)
                {
                    formLogin.Show();
                }
                else
                {
                    // Jika vLogin ada di folder Views, pastikan di paling atas sudah ada 'using RentaniApp.Views;'
                    vLogin newLogin = new vLogin();
                    newLogin.Show();
                }

                // 4. Tutup form beranda admin yang sekarang sedang aktif
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
