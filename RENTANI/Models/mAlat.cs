using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
using RentaniApp.Helpers;

namespace RentaniApp.Models
{
    public class Alat
    {
        public int IdAlat { get; set; }
        public int IdPemilik { get; set; }
        public int IdKategori { get; set; }
        public string NamaAlat { get; set; }
        public string Deskripsi { get; set; }
        public decimal HargaPerHari { get; set; }
        public int Stok { get; set; }
        public string Kondisi { get; set; }
        public byte[] GambarPath { get; set; }
        public string Status { get; set; }

        public KategoriAlat Kategori { get; set; }

        public Alat() { }

        public bool CekKetersediaan()
        {
            return this.Stok > 0 && this.Status == "Tersedia";
        }

        public void UpdateStok(int jumlah)
        {
            this.Stok += jumlah;
            this.Status = this.Stok <= 0 ? "Disewa" : "Tersedia";
        }

        public bool Simpan()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string query = @"INSERT INTO alat (id_pemilik, id_kategori, nama_alat, deskripsi, harga_per_hari, stok, kondisi, gambar_data, status)
                                 VALUES (@id_pemilik, @id_kategori, @nama_alat, @deskripsi, @harga_per_hari, @stok, @kondisi, @gambar_data, @status)";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id_pemilik", this.IdPemilik);
                cmd.Parameters.AddWithValue("id_kategori", this.IdKategori);
                cmd.Parameters.AddWithValue("nama_alat", this.NamaAlat);
                cmd.Parameters.AddWithValue("deskripsi", this.Deskripsi ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("harga_per_hari", this.HargaPerHari);
                cmd.Parameters.AddWithValue("stok", this.Stok);
                cmd.Parameters.AddWithValue("kondisi", this.Kondisi ?? (object)DBNull.Value);

                var paramGambar = new NpgsqlParameter("gambar_data", NpgsqlDbType.Bytea);
                paramGambar.Value = this.GambarPath ?? (object)DBNull.Value;
                cmd.Parameters.Add(paramGambar);

                cmd.Parameters.AddWithValue("status", this.Status ?? "Tersedia");

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal simpan alat: {ex.Message}");
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string query = @"UPDATE alat 
                                 SET id_kategori = @id_kategori, 
                                     nama_alat = @nama_alat, 
                                     deskripsi = @deskripsi, 
                                     harga_per_hari = @harga_per_hari, 
                                     stok = @stok, 
                                     kondisi = @kondisi, 
                                     gambar_data = @gambar_data, 
                                     status = @status
                                 WHERE id_alat = @id_alat";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id_alat", this.IdAlat);
                cmd.Parameters.AddWithValue("id_kategori", this.IdKategori);
                cmd.Parameters.AddWithValue("nama_alat", this.NamaAlat);
                cmd.Parameters.AddWithValue("deskripsi", this.Deskripsi ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("harga_per_hari", this.HargaPerHari);
                cmd.Parameters.AddWithValue("stok", this.Stok);
                cmd.Parameters.AddWithValue("kondisi", this.Kondisi ?? (object)DBNull.Value);

                var paramGambar = new NpgsqlParameter("gambar_data", NpgsqlDbType.Bytea);
                paramGambar.Value = this.GambarPath ?? (object)DBNull.Value;
                cmd.Parameters.Add(paramGambar);

                cmd.Parameters.AddWithValue("status", this.Status ?? "Tersedia");

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengubah data alat: {ex.Message}");
                return false;
            }
        }

        public bool Hapus()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string query = "DELETE FROM alat WHERE id_alat = @id_alat";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id_alat", this.IdAlat);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menghapus alat: {ex.Message}");
                return false;
            }
        }

        public static List<Alat> AmbilSemua()
        {
            var daftar = new List<Alat>();
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string query = @"SELECT a.id_alat, a.id_pemilik, a.id_kategori, a.nama_alat, a.deskripsi, 
                                        a.harga_per_hari, a.stok, a.kondisi, a.gambar_data, a.status,
                                        k.nama_kategori
                                 FROM alat a
                                 LEFT JOIN kategori_alat k ON a.id_kategori = k.id_kategori";

                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    daftar.Add(new Alat
                    {
                        IdAlat = reader.GetInt32(0),
                        IdPemilik = reader.GetInt32(1),
                        IdKategori = reader.GetInt32(2),
                        NamaAlat = reader.GetString(3),
                        Deskripsi = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        HargaPerHari = reader.GetDecimal(5),
                        Stok = reader.GetInt32(6),
                        Kondisi = reader.IsDBNull(7) ? "" : reader.GetString(7),
                        GambarPath = reader.IsDBNull(8) ? null : (byte[])reader["gambar_data"],
                        Status = reader.IsDBNull(9) ? "Tersedia" : reader.GetString(9),
                        Kategori = new KategoriAlat(reader.GetInt32(2), reader.IsDBNull(10) ? "-" : reader.GetString(10))
                    });
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return daftar;
        }

        public static List<Alat> AmbilKatalogKetersediaan()
        {
            var daftar = new List<Alat>();
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string query = @"SELECT a.id_alat, a.id_pemilik, a.id_kategori, a.nama_alat, a.deskripsi, 
                                        a.harga_per_hari, a.stok, a.kondisi, a.gambar_data, a.status,
                                        k.nama_kategori
                                 FROM alat a
                                 LEFT JOIN kategori_alat k ON a.id_kategori = k.id_kategori
                                 WHERE a.stok > 0 
                                   AND a.status NOT IN ('Maintenance', 'Disewa', 'Perbaikan', 'Rusak')";

                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    daftar.Add(new Alat
                    {
                        IdAlat = reader.GetInt32(0),
                        IdPemilik = reader.GetInt32(1),
                        IdKategori = reader.GetInt32(2),
                        NamaAlat = reader.GetString(3),
                        Deskripsi = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        HargaPerHari = reader.GetDecimal(5),
                        Stok = reader.GetInt32(6),
                        Kondisi = reader.IsDBNull(7) ? "" : reader.GetString(7),
                        GambarPath = reader.IsDBNull(8) ? null : (byte[])reader["gambar_data"],
                        Status = reader.IsDBNull(9) ? "Tersedia" : reader.GetString(9),
                        Kategori = new KategoriAlat(reader.GetInt32(2), reader.IsDBNull(10) ? "-" : reader.GetString(10))
                    });
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return daftar;
        }
    }
}