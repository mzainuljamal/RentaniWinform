using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Npgsql;
using RentaniApp.Helpers;

namespace RentaniApp.Models
{
    public class KategoriAlat
    {
        public int IdKategori { get; set; }
        public string NamaKategori { get; set; }

        public KategoriAlat() { }

        public KategoriAlat(int id, string nama)
        {
            IdKategori = id;
            NamaKategori = nama;
        }
        public static List<KategoriAlat> AmbilSemua()
        {
            var daftar = new List<KategoriAlat>();
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string query = "SELECT id_kategori, nama_kategori FROM kategori_alat";
                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    daftar.Add(new KategoriAlat(reader.GetInt32(0), reader.GetString(1)));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return daftar;
        }
    }
}