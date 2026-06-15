using System;
using System.Collections.Generic;
using System.Windows.Forms; 
using RentaniApp.Models;
using Npgsql;               
using RentaniApp.Helpers;   

namespace RentaniApp.Controllers
{
    public class AlatController
    {
        public bool TambahAlatBaru(Alat dataAlat)
        {

            if (dataAlat == null)
            {
                MessageBox.Show("Data alat tidak boleh kosong!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(dataAlat.NamaAlat))
            {
                MessageBox.Show("Nama alat wajib diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataAlat.IdKategori <= 0)
            {
                MessageBox.Show("Silakan pilih kategori alat yang valid!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           
            if (dataAlat.HargaPerHari < 0)
            {
                MessageBox.Show("Harga sewa per hari tidak boleh bernilai minus!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataAlat.Stok < 0)
            {
                MessageBox.Show("Stok alat tidak boleh bernilai minus!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataAlat.GambarPath == null || dataAlat.GambarPath.Length == 0)
            {
                MessageBox.Show("Wajib mengunggah foto alat pertanian!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

          
            return dataAlat.Simpan();
        }


        public List<Alat> AmbilSemuaAlat()
        {
            return Alat.AmbilSemua();
        }

        public int GetTotalAlat()
        {
            int total = 0;
            string query = "SELECT COUNT(*) FROM alat";

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                using var cmd = new NpgsqlCommand(query, conn);
                total = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error GetTotalAlat: " + ex.Message);
            }

            return total;
        }

        public void SesuaikanStokAlat(Alat dataAlat, int jumlahPerubahan)
        {
            dataAlat.UpdateStok(jumlahPerubahan);
        }

        public bool ApakahAlatBisaDisewa(Alat dataAlat)
        {
            return dataAlat.CekKetersediaan();
        }
    }
}