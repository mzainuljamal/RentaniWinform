using System;
using System.Windows.Forms;
using Npgsql;
using RentaniApp.Helpers;

namespace RentaniApp.Models
{
    public class Penyewaan
    {
        public int IdPenyewaan { get; set; }
        public int IdPenyewa { get; set; }
        public int IdAlat { get; set; }
        public DateTime TglMulai { get; set; }
        public DateTime TglSelesai { get; set; }
        public int DurasiHari { get; set; }
        public decimal TotalHarga { get; set; }
        public string Status { get; set; }
        public string Catatan { get; set; }
        public int? IdRating { get; set; }
        public string KomentarUlasan { get; set; }
        public DateTime? TglUlasan { get; set; }

        public Alat DetailAlat { get; set; }

        public Penyewaan() { }

        public decimal HitungTotal(decimal hargaPerHariAlat)
        {
            TimeSpan selisih = TglSelesai.Date - TglMulai.Date;
            this.DurasiHari = selisih.Days <= 0 ? 1 : selisih.Days;
            this.TotalHarga = this.DurasiHari * hargaPerHariAlat;
            return this.TotalHarga;
        }

        public void BeriUlasan(int idRating, string komentar)
        {
            if (this.Status != "Selesai")
                throw new Exception("Belum bisa memberi ulasan sebelum status sewa 'Selesai'!");

            this.IdRating = idRating;
            this.KomentarUlasan = komentar;
            this.TglUlasan = DateTime.Now;

            // Langsung update ulasan ke database
            UpdateUlasanKeDb();
        }

        public void Verifikasi(bool ok)
        {
            this.Status = ok ? "Disetujui" : "Ditolak";
            UpdateStatusKeDb();
        }

        public void Batalkan()
        {
            this.Status = "Dibatalkan";
            UpdateStatusKeDb();
        }

        public bool BuatPesanan()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string query = @"INSERT INTO penyewaan (id_penyewa, id_alat, tgl_mulai, tgl_selesai, durasi_hari, total_harga, status, catatan)
                                 VALUES (@id_penyewa, @id_alat, @tgl_mulai, @tgl_selesai, @durasi_hari, @total_harga, @status, @catatan)";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id_penyewa", this.IdPenyewa);
                cmd.Parameters.AddWithValue("id_alat", this.IdAlat);
                cmd.Parameters.AddWithValue("tgl_mulai", this.TglMulai);
                cmd.Parameters.AddWithValue("tgl_selesai", this.TglSelesai);
                cmd.Parameters.AddWithValue("durasi_hari", this.DurasiHari);
                cmd.Parameters.AddWithValue("total_harga", this.TotalHarga);
                cmd.Parameters.AddWithValue("status", this.Status ?? "Menunggu");
                cmd.Parameters.AddWithValue("catatan", this.Catatan ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal sewa: {ex.Message}");
                return false;
            }
        }

        private void UpdateStatusKeDb()
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();
            string query = "UPDATE penyewaan SET status = @status WHERE id_penyewaan = @id";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("status", this.Status);
            cmd.Parameters.AddWithValue("id", this.IdPenyewaan);
            cmd.ExecuteNonQuery();
        }

        private void UpdateUlasanKeDb()
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();
            string query = @"UPDATE penyewaan 
                             SET id_rating = @id_rating, komentar_ulasan = @komentar, tgl_ulasan = @tgl 
                             WHERE id_penyewaan = @id";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_rating", this.IdRating);
            cmd.Parameters.AddWithValue("komentar", this.KomentarUlasan);
            cmd.Parameters.AddWithValue("tgl", this.TglUlasan);
            cmd.Parameters.AddWithValue("id", this.IdPenyewaan);
            cmd.ExecuteNonQuery();
        }
    }
}