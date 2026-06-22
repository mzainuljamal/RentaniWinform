using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RentaniApp.Helpers;
using RentaniApp.Controllers;
using RentaniApp.Models;

namespace RentaniApp.Views.vPenyewa
{
    public partial class ucBerandaPenyewa : UserControl
    {
        private BerandaController _berandaController;
        private AlatController _alatController;

        public ucBerandaPenyewa()
        {
            InitializeComponent();
            _berandaController = new BerandaController();
            _alatController = new AlatController();
        }

        private void ucBerandaPenyewa_Load(object sender, EventArgs e)
        {
            LoadDataRingkasanAktivitas();
            LoadKatalogAlatBeranda();
        }

        private void LoadDataRingkasanAktivitas()
        {
            try
            {
                if (AppSession.IsLoggedIn())
                {
                    int idPenyewa = AppSession.CurrentUser.Id;
                    Dictionary<string, object> statistik = _berandaController.GetStatistikPenyewa(idPenyewa);

                    lblAngkaSewaAktif.Text = statistik["SewaAktif"].ToString();
                    lblAngkaMenunggu.Text = statistik["MenungguVerifikasi"].ToString();
                    lblAngkaSelesai.Text = statistik["Selesai"].ToString();

                    long totalBelanja = Convert.ToInt64(statistik["TotalBelanja"]);
                    lblAngkaTotalBelanja.Text = string.Format("Rp {0:N0}", totalBelanja);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadKatalogAlatBeranda()
        {
            try
            {
                flpKatalogBeranda.Controls.Clear();
                List<Alat> daftarAlat = _alatController.AmbilSemuaAlat();

                foreach (Alat alat in daftarAlat)
                {
                    ucItemAlat item = new ucItemAlat(alat);
                    flpKatalogBeranda.Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat katalog: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlRingkasan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}