using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RentaniApp.Helpers;

namespace RentaniApp.Views.vPenyewa
{
    public partial class vBerandaPenyewa : Form
    {
        private string _namaPenyewa;

        public vBerandaPenyewa()
        {
            InitializeComponent();
        }

        public vBerandaPenyewa(string nama) : this()
        {
            _namaPenyewa = nama;
        }

        private void vBerandaPenyewa_Load(object sender, EventArgs e)
        {
            FormatSapaanRichTextBox();
            btnBeranda.Checked = true;
            btnBeranda.PerformClick();
        }

        private void FormatSapaanRichTextBox()
        {
            FormatSapaanRTB.Clear();

            FormatSapaanRTB.SelectionColor = Color.FromArgb(108, 117, 125);
            FormatSapaanRTB.SelectionFont = new Font(FormatSapaanRTB.Font, FontStyle.Regular);
            FormatSapaanRTB.AppendText("Selamat Datang, ");

            FormatSapaanRTB.SelectionColor = Color.FromArgb(26, 115, 232);
            FormatSapaanRTB.SelectionFont = new Font(FormatSapaanRTB.Font, FontStyle.Bold);
            FormatSapaanRTB.AppendText(_namaPenyewa);

            FormatSapaanRTB.SelectionColor = Color.FromArgb(108, 117, 125);
            FormatSapaanRTB.SelectionFont = new Font(FormatSapaanRTB.Font, FontStyle.Regular);
            FormatSapaanRTB.AppendText(" • Penyewa");
        }

        private void TampilkanUserControl(UserControl uc)
        {
            pnlKontenPenyewa.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlKontenPenyewa.Controls.Add(uc);
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            TampilkanUserControl(new ucBerandaPenyewa());
            btnBeranda.Checked = true;
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            TampilkanUserControl(new ucKatalogAlat());
            btnKatalog.Checked = true;
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            btnPembayaran.Checked = true;
            int idUserAktif = AppSession.CurrentUser.Id;
            TampilkanUserControl(new ucPembayaranPenyewa(idUserAktif));
        }

        private void btnPenyewaan_Click(object sender, EventArgs e)
        {
            btnPenyewaan.Checked = true;
            int idUserAktif = AppSession.CurrentUser.Id;

            var ucSewa = new ucPenyewaanSaya();
            ucSewa.SetIdPenyewa(idUserAktif);

            TampilkanUserControl(ucSewa);
        }

        private void lblSapaan_Click(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AppSession.EndSession();
                vLogin loginForm = new vLogin();
                loginForm.Show();
                this.Close();
            }
        }

        private void FormatSapaanRTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void pnlKontenPenyewa_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlDashboard_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}