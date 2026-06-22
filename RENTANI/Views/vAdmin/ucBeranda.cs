using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using RentaniApp.Controllers;
using RentaniApp.Models;

namespace RentaniApp.Views
{
    public partial class ucBeranda : UserControl
    {
        private AlatController alatController = new AlatController();

        public ucBeranda()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ucBeranda_Load);
        }

        private void ucBeranda_Load(object sender, EventArgs e)
        {
            MuatDataDashboardAdmin();
        }

        public void MuatDataDashboardAdmin()
        {
            try
            {
                Dictionary<string, object> ringkasan = Penyewaan.AmbilRingkasanBisnisAdmin();

                lblValAlat.Text = ringkasan["TotalAlat"].ToString();
                lblValSewa.Text = ringkasan["PengajuanBaru"].ToString();

                decimal pendapatan = Convert.ToDecimal(ringkasan["Pendapatan"]);
                if (pendapatan >= 1000000)
                {
                    lblValIncome.Text = $"Rp {(pendapatan / 1000000):N1}M";
                }
                else
                {
                    lblValIncome.Text = $"Rp {(pendapatan / 1000):N0}K";
                }

                DataTable dtSewa = Penyewaan.AmbilSemuaDataSewa();
                dgvPengajuan.DataSource = dtSewa;

                dgvPengajuan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPengajuan.ReadOnly = true;
                dgvPengajuan.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyinkronkan data database ke UI: {ex.Message}", "Bypass Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}