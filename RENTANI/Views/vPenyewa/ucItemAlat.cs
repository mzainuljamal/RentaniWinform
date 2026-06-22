using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using RentaniApp.Models;

namespace RentaniApp.Views.vPenyewa
{
    public partial class ucItemAlat : UserControl
    {
        private readonly Alat _alat;

        public event EventHandler<Alat> OnSewaClicked;

        public ucItemAlat()
        {
            InitializeComponent();
        }

        public ucItemAlat(Alat alat) : this()
        {
            _alat = alat;
            TampilkanDataAlat();
        }

        private void TampilkanDataAlat()
        {
            if (_alat == null) return;

            lblNamaAlat.Text = _alat.NamaAlat;
            lblKategori.Text = _alat.Kategori != null ? _alat.Kategori.NamaKategori : "Umum";
            lblHarga.Text = $"Rp {_alat.HargaPerHari:N0} / hari";

            if (_alat.GambarPath != null && _alat.GambarPath.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(_alat.GambarPath))
                    {
                        picAlat.Image = Image.FromStream(ms);
                    }
                }
                catch
                {
                    picAlat.Image = null;
                }
            }

            if (_alat.Status == "Maintenance" || _alat.Status == "Perbaikan")
            {
                lblStok.Text = "Maintenance";
                lblStok.ForeColor = Color.Orange;
                btnSewaSekarang.Enabled = false;
                btnSewaSekarang.Text = "Perbaikan";
            }
            else if (_alat.Status == "Disewa" || _alat.Status == "Rusak" || _alat.Stok <= 0)
            {
                lblStok.Text = _alat.Status == "Disewa" ? "Sedang Disewa" : "Stok Habis";
                lblStok.ForeColor = Color.Red;
                btnSewaSekarang.Enabled = false;
                btnSewaSekarang.Text = "Habis";
            }
            else
            {
                lblStok.Text = $"Tersedia: {_alat.Stok} Unit";
                lblStok.ForeColor = Color.FromArgb(40, 167, 69);
                btnSewaSekarang.Enabled = true;
                btnSewaSekarang.Text = "Sewa";
            }
        }

        private void btnSewaSekarang_Click(object sender, EventArgs e)
        {
            OnSewaClicked?.Invoke(this, _alat);
        }

        private void ucItemAlat_Load(object sender, EventArgs e)
        {
        }

        private void picAlat_Click(object sender, EventArgs e)
        {
        }
    }
}