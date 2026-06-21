using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RentaniApp.Models;

namespace RentaniApp.Views.vPenyewa
{
    public partial class ucKatalogAlat : UserControl
    {
        private List<Alat> _listAlat;

        public ucKatalogAlat()
        {
            InitializeComponent();
        }

        private void ucKatalogAlat_Load(object sender, EventArgs e)
        {
            MuatKatalogAlat();
        }

        public void MuatKatalogAlat()
        {
            try
            {
                _listAlat = Alat.AmbilSemua();
                TampilkanKartuAlat(_listAlat);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat katalog: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TampilkanKartuAlat(List<Alat> daftarAlat)
        {
            flpKatalog.Controls.Clear();
            if (daftarAlat == null || daftarAlat.Count == 0) return;

            foreach (Alat alat in daftarAlat)
            {
                ucItemAlat card = new ucItemAlat(alat);
                card.OnSewaClicked += Card_OnSewaClicked;
                flpKatalog.Controls.Add(card);
            }
        }

        private void Card_OnSewaClicked(object sender, Alat alatTerpilih)
        {
            vAjukanSewa formSewa = new vAjukanSewa(alatTerpilih);
            if (formSewa.ShowDialog() == DialogResult.OK)
            {
                MuatKatalogAlat();
            }
        }

        private void tbCariAlat_TextChanged(object sender, EventArgs e)
        {
            if (_listAlat == null) return;

            string keyword = tbCariAlat.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                TampilkanKartuAlat(_listAlat);
            }
            else
            {
                var hasilFilter = _listAlat.Where(a =>
                    (a.NamaAlat != null && a.NamaAlat.ToLower().Contains(keyword)) ||
                    (a.Kategori != null && a.Kategori.NamaKategori.ToLower().Contains(keyword))
                ).ToList();

                TampilkanKartuAlat(hasilFilter);
            }
        }

        private void flpKatalog_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}