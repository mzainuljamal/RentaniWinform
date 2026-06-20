using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using RentaniApp.Controllers;

namespace RentaniApp.Views.vAdmin
{
    public partial class ucRiwayatSewa : UserControl
    {
        private readonly PembayaranController _pembayaranController = new PembayaranController();

        public ucRiwayatSewa()
        {
            InitializeComponent();

            // Daftarkan ulang event secara aman
            dgvRiwayat.CellFormatting -= dgvRiwayat_CellFormatting;
            dgvRiwayat.CellFormatting += dgvRiwayat_CellFormatting;
        }

        private void ucRiwayatSewa_Load(object sender, EventArgs e)
        {
            TampilkanRiwayat();
        }

        private void TampilkanRiwayat()
        {
            dgvRiwayat.AutoGenerateColumns = false;

            DataTable dt = _pembayaranController.AmbilRiwayatSewaController();

            idCol.DataPropertyName = "IdSewa";
            penyewaCol.DataPropertyName = "NamaPenyewa";
            alatCol.DataPropertyName = "NamaAlat";
            periodeCol.DataPropertyName = "PeriodeSewa";
            totalCol.DataPropertyName = "TotalHarga";
            statusCol.DataPropertyName = "StatusSewa";
            pembayaranCol.DataPropertyName = "StatusBayar";

            dgvRiwayat.DataSource = dt;
        }

        // --- LOGIKA PEWARNAAN OTOMATIS DAN KEBAL THEME ---
        private void dgvRiwayat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            // Membaca langsung mapping properti datanya agar terhindar dari salah nama kolom desainer
            string propertiData = dgvRiwayat.Columns[e.ColumnIndex].DataPropertyName;
            string nilaiTeks = e.Value.ToString().Trim().ToLower();

            // 1. Mewarnai Kolom Status Sewa (Mapping: StatusSewa)
            if (propertiData == "StatusSewa")
            {
                if (nilaiTeks == "disetujui" || nilaiTeks == "selesai")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(40, 167, 69); // Hijau sukses
                    e.CellStyle.SelectionForeColor = Color.FromArgb(40, 167, 69);
                    e.CellStyle.Font = new Font(dgvRiwayat.Font, FontStyle.Bold);
                    e.FormattingApplied = true; // Paksa Guna2 menuruti warna ini
                }
                else if (nilaiTeks == "menunggu" || nilaiTeks == "pending")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(253, 126, 20); // Oranye
                    e.CellStyle.SelectionForeColor = Color.FromArgb(253, 126, 20);
                    e.CellStyle.Font = new Font(dgvRiwayat.Font, FontStyle.Bold);
                    e.FormattingApplied = true;
                }
            }

            // 2. Mewarnai Kolom Status Pembayaran (Mapping: StatusBayar)
            if (propertiData == "StatusBayar")
            {
                if (nilaiTeks == "lunas" || nilaiTeks == "sudah bayar")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(40, 167, 69); // Hijau sukses
                    e.CellStyle.SelectionForeColor = Color.FromArgb(40, 167, 69);
                    e.CellStyle.Font = new Font(dgvRiwayat.Font, FontStyle.Bold);
                    e.FormattingApplied = true;
                }
                else if (nilaiTeks == "belum bayar" || nilaiTeks == "belum_bayar")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(220, 53, 69); // Merah alert
                    e.CellStyle.SelectionForeColor = Color.FromArgb(220, 53, 69);
                    e.CellStyle.Font = new Font(dgvRiwayat.Font, FontStyle.Bold);
                    e.FormattingApplied = true;
                }
                else if (nilaiTeks == "konfirmasi" || nilaiTeks == "menunggu verifikasi")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(253, 126, 20); // Oranye
                    e.CellStyle.SelectionForeColor = Color.FromArgb(253, 126, 20);
                    e.CellStyle.Font = new Font(dgvRiwayat.Font, FontStyle.Bold);
                    e.FormattingApplied = true;
                }
            }
        }
    }
}