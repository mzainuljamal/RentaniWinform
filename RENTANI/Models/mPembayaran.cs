using System;
using System.Windows.Forms;
using Npgsql;
using RentaniApp.Helpers;

namespace RentaniApp.Models
{
    public class Pembayaran
    {
        public int IdPembayaran { get; set; }
        public int IdPenyewaan { get; set; }
        public decimal JumlahBayar { get; set; }
        public DateTime TglBayar { get; set; }
        public string MetodeBayar { get; set; }
        public string StatusPembayaran { get; set; }

        public Pembayaran() { }

        public bool CatatPembayaran()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string query = @"INSERT INTO pembayaran (id_penyewaan, jumlah_bayar, tgl_bayar, metode_bayar, status_pembayaran)
                                 VALUES (@id_penyewaan, @jumlah_bayar, @tgl_bayar, @metode_bayar, @status_pembayaran)";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id_penyewaan", this.IdPenyewaan);
                cmd.Parameters.AddWithValue("jumlah_bayar", this.JumlahBayar);
                cmd.Parameters.AddWithValue("tgl_bayar", DateTime.Now);
                cmd.Parameters.AddWithValue("metode_bayar", this.MetodeBayar);
                cmd.Parameters.AddWithValue("status_pembayaran", this.StatusPembayaran ?? "Lunas");
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
    }
}