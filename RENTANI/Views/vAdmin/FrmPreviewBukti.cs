using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentaniApp.Views.vAdmin
{
    public partial class FrmPreviewBukti : Form
    {
        public FrmPreviewBukti(Image imageBukti, string idTransaksi, string namaPenyewa)
        {
            InitializeComponent();
            lblDetail.Text = $"Transaksi ID: #{idTransaksi} | Penyewa: {namaPenyewa}";

            if (imageBukti != null)
            {
                pbBukti.Image = imageBukti;
            }
            else
            {
                lblError.Visible = true;
            }
        }

        public FrmPreviewBukti(string pathGambar, string idTransaksi, string namaPenyewa)
        {
            InitializeComponent();
            lblDetail.Text = $"Transaksi ID: #{idTransaksi} | Penyewa: {namaPenyewa}";

            try
            {
                if (!string.IsNullOrEmpty(pathGambar) && System.IO.File.Exists(pathGambar))
                {
                    pbBukti.Image = Image.FromFile(pathGambar);
                }
                else
                {
                    lblError.Visible = true;
                }
            }
            catch
            {
                lblError.Visible = true;
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPreviewBukti_Load(object sender, EventArgs e)
        {
        }
    }
}