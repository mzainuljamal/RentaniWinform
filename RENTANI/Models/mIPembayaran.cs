using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using RentaniApp.Helpers;

namespace RentaniApp.Models
{
    public interface IPembayaran
    {
        bool Verifikasi(int idPenyewaan, int idBayar);
    }

    public class PembayaranTransfer : IPembayaran
    {
        public bool Verifikasi(int idPenyewaan, int idBayar)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();
            using var trans = conn.BeginTransaction();
            try
            {
                string queryBayar = "UPDATE pembayaran SET status = 'Lunas' WHERE id_bayar = @id_bayar";
                using var cmdBayar = new NpgsqlCommand(queryBayar, conn, trans);
                cmdBayar.Parameters.AddWithValue("id_bayar", idBayar);
                cmdBayar.ExecuteNonQuery();

                string querySewa = "UPDATE penyewaan SET status = 'Disetujui' WHERE id_penyewaan = @id_penyewaan";
                using var cmdSewa = new NpgsqlCommand(querySewa, conn, trans);
                cmdSewa.Parameters.AddWithValue("id_penyewaan", idPenyewaan);
                cmdSewa.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show($"Gagal verifikasi transfer: {ex.Message}");
                return false;
            }
        }
    }

    public class PembayaranCOD : IPembayaran
    {
        public bool Verifikasi(int idPenyewaan, int idBayar)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();
            using var trans = conn.BeginTransaction();
            try
            {
                string queryBayar = "UPDATE pembayaran SET status = 'Lunas' WHERE id_bayar = @id_bayar";
                using var cmdBayar = new NpgsqlCommand(queryBayar, conn, trans);
                cmdBayar.Parameters.AddWithValue("id_bayar", idBayar);
                cmdBayar.ExecuteNonQuery();

                string querySewa = "UPDATE penyewaan SET status = 'Disetujui' WHERE id_penyewaan = @id_penyewaan";
                using var cmdSewa = new NpgsqlCommand(querySewa, conn, trans);
                cmdSewa.Parameters.AddWithValue("id_penyewaan", idPenyewaan);
                cmdSewa.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show($"Gagal verifikasi COD: {ex.Message}");
                return false;
            }
        }
    }

    public class Pembayaran
    {
        public int IdBayar { get; set; }
        public int IdPenyewaan { get; set; }
        public int IdMetode { get; set; }
        public decimal Jumlah { get; set; }
        public string BuktiBayar { get; set; }
        public DateTime TglBayar { get; set; }
        public string Status { get; set; }

        public Pembayaran() { }

        public static DataTable AmbilSemuaDataPembayaran()
        {
            DataTable dt = new DataTable();
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string query = @"
                SELECT b.id_bayar AS IdPembayaran,
                       b.id_penyewaan AS IdPenyewaan,
                       u.nama AS NamaPenyewa,
                       a.nama_alat AS NamaAlat,
                       b.jumlah AS JumlahBayar,
                       COALESCE(m.nama_metode, 'Transfer Bank BRI') AS MetodeBayar,
                       b.status AS StatusPembayaran,
                       b.bukti_transfer AS BuktiBayar
                FROM pembayaran b
                JOIN penyewaan p ON b.id_penyewaan = p.id_penyewaan
                JOIN penyewa py ON p.id_penyewa = py.id_penyewa
                JOIN ""user"" u ON py.id_user = u.id_user
                JOIN alat a ON p.id_alat = a.id_alat
                LEFT JOIN metode_pembayaran m ON b.id_metode = m.id_metode
                ORDER BY b.id_bayar DESC";

            using var cmd = new NpgsqlCommand(query, conn);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable AmbilRiwayatSewa()
        {
            DataTable dt = new DataTable();
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string query = @"
                SELECT p.id_penyewaan AS IdSewa,
                       u.nama AS NamaPenyewa,
                       a.nama_alat AS NamaAlat,
                       CONCAT(TO_CHAR(p.tgl_mulai, 'YYYY-MM-DD'), ' ➔ ', TO_CHAR(p.tgl_selesai, 'YYYY-MM-DD')) AS PeriodeSewa,
                       p.total_harga AS TotalHarga,
                       p.status AS StatusSewa,
                       COALESCE(b.status, 'Menunggu Konfirmasi') AS StatusBayar
                FROM penyewaan p
                JOIN penyewa py ON p.id_penyewa = py.id_penyewa
                JOIN ""user"" u ON py.id_user = u.id_user
                JOIN alat a ON p.id_alat = a.id_alat
                LEFT JOIN pembayaran b ON p.id_penyewaan = b.id_penyewaan
                ORDER BY p.id_penyewaan DESC";

            using var cmd = new NpgsqlCommand(query, conn);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable AmbilRiwayatSewaPenyewa(int idPenyewa)
        {
            DataTable dt = new DataTable();
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string query = @"
                SELECT p.id_penyewaan AS IdSewa,
                       a.nama_alat AS AlatPertanian,
                       p.total_harga AS JumlahTagihan,
                       COALESCE(b.status, 'Menunggu Konfirmasi') AS StatusBayar,
                       b.bukti_transfer AS BuktiBayar
                FROM penyewaan p
                JOIN penyewa py ON p.id_penyewa = py.id_penyewa
                JOIN alat a ON p.id_alat = a.id_alat
                LEFT JOIN pembayaran b ON p.id_penyewaan = b.id_penyewaan
                WHERE p.id_penyewa = @id_penyewa
                ORDER BY p.id_penyewaan DESC";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_penyewa", idPenyewa);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}