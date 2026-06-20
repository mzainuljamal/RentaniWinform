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

        private void TampilkanUserControl(UserControl uc)
        {
            panelKonten.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(uc);
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            ucBeranda halamanBeranda = new ucBeranda();
            TampilkanUserControl(halamanBeranda);
        }

        private void btnKelolaAlat_Click(object sender, EventArgs e)
        {
            ucKelolaAlat halamanKelola = new ucKelolaAlat();
            TampilkanUserControl(halamanKelola);
        }

        private void panelKonten_Paint(object sender, PaintEventArgs e)
        {
        }

        private void vBerandaAdmin_Load(object sender, EventArgs e)
        {
            label2.Text = "Selamat Datang, " + AppSession.CurrentUser.Nama;

            ucBeranda halamanBeranda = new ucBeranda();
            TampilkanUserControl(halamanBeranda);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form formLogin = null;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "vLogin")
                    {
                        formLogin = f;
                        break;
                    }
                }

                if (formLogin != null)
                {
                    formLogin.Show();
                }
                else
                {
                    vLogin newLogin = new vLogin();
                    newLogin.Show();
                }

                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void panelKonten_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ucVerifiksiSewa halamanVerifikasi = new ucVerifiksiSewa();
            TampilkanUserControl(halamanVerifikasi);
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            ucCekPembayaran halamanPembayaran = new ucCekPembayaran();
            TampilkanUserControl(halamanPembayaran);
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            ucRiwayatSewa halamanRiwayat = new ucRiwayatSewa();
            TampilkanUserControl(halamanRiwayat);
        }
    }
}