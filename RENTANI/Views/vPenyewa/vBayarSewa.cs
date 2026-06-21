using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql;
using RentaniApp.Helpers;

namespace RentaniApp.Views.vPenyewa
{
    public partial class vBayarSewa : Form
    {
        private readonly int _idSewa;
        private readonly decimal _totalHarga;
        private byte[] _buktiTransferBytes = null;

        public vBayarSewa(int idSewa, string namaAlat, string periode, decimal totalHarga)
        {
            InitializeComponent();
            _idSewa = idSewa;
            _totalHarga = totalHarga;

            lblNamaAlat.Text = namaAlat;
            lblPeriode.Text = $"Periode Sewa : {periode}";
            lblTotalHarga.Text = $"Rp {totalHarga:N0}";

            IsiMetodePembayaran();
        }

        private void IsiMetodePembayaran()
        {
            cmbMetodeBayar.Items.Clear();
            cmbMetodeBayar.Items.Add("Transfer Bank — BCA");
            cmbMetodeBayar.Items.Add("Transfer Bank — BRI");
            cmbMetodeBayar.Items.Add("QRIS");
            cmbMetodeBayar.Items.Add("COD");
            cmbMetodeBayar.SelectedIndex = 0;
        }

        private void cmbMetodeBayar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetodeBayar.SelectedItem == null) return;
            string metode = cmbMetodeBayar.SelectedItem.ToString();

            if (metode.Contains("BCA"))
            {
                lblRekeningInfo.Text = "BCA 1234-5678-9012\na.n. RENTAL JOKO TANI";
                pnlUploadBukti.Enabled = true;
            }
            else if (metode.Contains("BRI"))
            {
                lblRekeningInfo.Text = "BRI 9876-5432-1012\na.n. RENTAL JOKO TANI";
                pnlUploadBukti.Enabled = true;
            }
            else if (metode.Contains("QRIS"))
            {
                lblRekeningInfo.Text = "Pindai Kode QRIS Resmi Rental Joko Tani";
                pnlUploadBukti.Enabled = true;
            }
            else
            {
                lblRekeningInfo.Text = "Bayar Tunai di Lokasi Saat Ambil Alat";
                pnlUploadBukti.Enabled = false;
                _buktiTransferBytes = null;
                lblNamaFileBukti.Text = "Tidak membutuhkan berkas";
            }
        }

        private void pnlUploadBukti_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lblNamaFileBukti.Text = Path.GetFileName(ofd.FileName);
                    _buktiTransferBytes = File.ReadAllBytes(ofd.FileName);
                }
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void vBayarSewa_Load(object sender, EventArgs e)
        {
        }
        private void btnKonfirmasiBayar_Click(object sender, EventArgs e)
        {
            if (cmbMetodeBayar.SelectedItem == null) return;
            string metodeTeks = cmbMetodeBayar.SelectedItem.ToString();

            if (!metodeTeks.Contains("COD") && _buktiTransferBytes == null)
            {
                MessageBox.Show("Silakan unggah bukti transfer terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idMetode = 1; // Default BRI
            if (metodeTeks.Contains("BCA")) idMetode = 1;
            else if (metodeTeks.Contains("QRIS")) idMetode = 2;
            else if (metodeTeks.Contains("COD")) idMetode = 3;

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                using var trans = conn.BeginTransaction();

                // FIX: Menyesuaikan nama kolom riil PostgreSQL milik lu (status, id_metode, bukti_transfer)
                string queryBayar = @"UPDATE pembayaran 
                                      SET status = 'Lunas', id_metode = @id_metode, tgl_bayar = @tgl
                                      WHERE id_penyewaan = @id_sewa";

                using var cmdBayar = new NpgsqlCommand(queryBayar, conn, trans);
                cmdBayar.Parameters.AddWithValue("id_metode", idMetode);
                cmdBayar.Parameters.AddWithValue("tgl", DateTime.Now);
                cmdBayar.Parameters.AddWithValue("id_sewa", _idSewa);
                cmdBayar.ExecuteNonQuery();

                // Ubah status sewa menjadi Disetujui
                string querySewa = "UPDATE penyewaan SET status = 'Disetujui' WHERE id_penyewaan = @id_sewa";
                using var cmdSewa = new NpgsqlCommand(querySewa, conn, trans);
                cmdSewa.Parameters.AddWithValue("id_sewa", _idSewa);
                cmdSewa.ExecuteNonQuery();

                trans.Commit();

                MessageBox.Show("Pembayaran Berhasil Dikonfirmasi!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memproses pembayaran: {ex.Message}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}