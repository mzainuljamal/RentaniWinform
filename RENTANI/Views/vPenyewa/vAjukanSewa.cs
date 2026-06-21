using System;
using System.Windows.Forms;
using RentaniApp.Controllers;
using RentaniApp.Models;

namespace RentaniApp.Views.vPenyewa
{
    public partial class vAjukanSewa : Form
    {
        private readonly PenyewaanController _controller;
        private readonly Alat _alatDiSewa;

        public vAjukanSewa(Alat alat)
        {
            InitializeComponent();
            _controller = new PenyewaanController();
            _alatDiSewa = alat;

            IsiDefaultMetodeBayar();
            HitungOtomatisBiaya();
        }

        private void IsiDefaultMetodeBayar()
        {
            cmbMetodeBayar.Items.Clear();
            cmbMetodeBayar.Items.Add("Transfer Bank BRI");
            cmbMetodeBayar.Items.Add("QRIS");
            cmbMetodeBayar.Items.Add("COD");
            cmbMetodeBayar.SelectedIndex = 0;
        }

        private void HitungOtomatisBiaya()
        {
            Penyewaan dummySewa = new Penyewaan
            {
                TglMulai = dtpMulai.Value,
                TglSelesai = dtpSelesai.Value
            };

            decimal total = dummySewa.HitungTotal(_alatDiSewa.HargaPerHari);

            lblDetailDurasi.Text = $"Durasi Sewa: {dummySewa.DurasiHari} Hari (1 × Rp {_alatDiSewa.HargaPerHari:N0})";
            lblTotalHarga.Text = $"Rp {total:N0}";
        }

        private void dtpMulai_ValueChanged(object sender, EventArgs e)
        {
            HitungOtomatisBiaya();
        }

        private void dtpSelesai_ValueChanged(object sender, EventArgs e)
        {
            HitungOtomatisBiaya();
        }

        private void btnAjukanSewa_Click(object sender, EventArgs e)
        {
            string metodeBayar = cmbMetodeBayar.SelectedItem?.ToString() ?? "Transfer Bank BRI";
            string catatan = txtCatatan.Text;

            int idMetode = 1;
            if (metodeBayar.Contains("QRIS"))
            {
                idMetode = 2;
            }
            else if (metodeBayar.Contains("COD"))
            {
                idMetode = 3;
            }

            bool sukses = _controller.KirimPengajuanSewa(
                _alatDiSewa.IdAlat,
                dtpMulai.Value,
                dtpSelesai.Value,
                idMetode,
                catatan,
                _alatDiSewa.HargaPerHari
            );

            if (sukses)
            {
                MessageBox.Show("Pengajuan sewa berhasil dikirim! Silakan tunggu verifikasi admin.", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void cmbMetodeBayar_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtCatatan_TextChanged(object sender, EventArgs e) { }
        private void lblDetailDurasi_Click(object sender, EventArgs e) { }
        private void lblTotalHarga_Click(object sender, EventArgs e) { }

        private void vAjukanSewa_Load(object sender, EventArgs e)
        {

        }
    }
}