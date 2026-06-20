using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using RentaniApp.Controllers;
using RentaniApp.Models;

namespace RentaniApp.Views.vAdmin
{
    public partial class vEditAlat : Form
    {
        private readonly AlatController _alatController = new AlatController();
        private int _idAlatTerpilih;
        private byte[] _gambarBytes;

        public vEditAlat(int idAlat, string nama, string kategori, decimal harga, int stok, string kondisi, string status, Image gambarCurrent)
        {
            InitializeComponent();

            _idAlatTerpilih = idAlat;
            txtNamaAlat.Text = nama;
            txtKategori.Text = kategori;
            txtHargaPerHari.Text = harga.ToString();
            txtStok.Text = stok.ToString();

            // --- 1. SINKRONISASI DATA KONDISI SESUAI DATABASE ---
            cmbKondisi.Items.Clear();
            cmbKondisi.Items.AddRange(new string[] { "Baik", "Cukup", "Perlu Servis" });

            // --- 2. SINKRONISASI DATA STATUS SESUAI DATABASE ---
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "Tersedia", "Disewa", "Maintenance" });

            // Set item terpilih dari DataGridView
            if (cmbKondisi.Items.Contains(kondisi)) cmbKondisi.SelectedItem = kondisi;
            if (cmbStatus.Items.Contains(status)) cmbStatus.SelectedItem = status;

            if (gambarCurrent != null)
            {
                pbFotoAlat.Image = gambarCurrent;
                using (MemoryStream ms = new MemoryStream())
                {
                    gambarCurrent.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    _gambarBytes = ms.ToArray();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pbFotoAlat_Click(object sender, EventArgs e)
        {
        }

        private void vEditAlat_Load(object sender, EventArgs e)
        {
        }

        private void txtNamaAlat_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtKategori_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtHargaPerHari_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtStok_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbKondisi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnKlikUploudFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbFotoAlat.Image = Image.FromFile(ofd.FileName);
                    _gambarBytes = File.ReadAllBytes(ofd.FileName);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Alat alatUpdate = new Alat
            {
                IdAlat = _idAlatTerpilih,
                NamaAlat = txtNamaAlat.Text.Trim(),
                HargaPerHari = string.IsNullOrEmpty(txtHargaPerHari.Text) ? 0 : Convert.ToDecimal(txtHargaPerHari.Text),
                Stok = string.IsNullOrEmpty(txtStok.Text) ? 0 : Convert.ToInt32(txtStok.Text),
                Kondisi = cmbKondisi.SelectedItem?.ToString(),
                Status = cmbStatus.SelectedItem?.ToString(),
                GambarPath = _gambarBytes,
                IdKategori = 1
            };

            if (_alatController.EditAlatBerhasil(alatUpdate))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}