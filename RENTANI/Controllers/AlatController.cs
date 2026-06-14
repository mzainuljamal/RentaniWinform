using System;
using System.Collections.Generic;
using System.Windows.Forms; // Ditambahkan agar bisa memunculkan MessageBox peringatan
using RentaniApp.Models;

namespace RentaniApp.Controllers
{
    public class AlatController
    {
        // 1. MANGGIL MODEL UNTUK SIMPAN DATA (DENGAN VALIDASI SYARAT)
        public bool TambahAlatBaru(Alat dataAlat)
        {
            // ---- PROSES PENGECEKAN SYARAT (VALIDASI) ----

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

            if (dataAlat.HargaPerHari <= 0)
            {
                MessageBox.Show("Harga sewa per hari harus lebih besar dari Rp 0!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            // ---- JIKA SEMUA SYARAT LOLOS, BARU SIMPAN KE DB ----
            return dataAlat.Simpan();
        }

        // 2. MANGGIL MODEL UNTUK AMBIL SEMUA DATA (READ)
        public List<Alat> AmbilSemuaAlat()
        {
            return Alat.AmbilSemua();
        }

        // 3. SEBAGAI PENGHUBUNG UPDATE STOK KETIKA ADA TRANSAKSI
        public void SesuaikanStokAlat(Alat dataAlat, int jumlahPerubahan)
        {
            dataAlat.UpdateStok(jumlahPerubahan);
        }

        // 4. SEBAGAI PENGHUBUNG CEK APAKAH BARANG READY
        public bool ApakahAlatBisaDisewa(Alat dataAlat)
        {
            return dataAlat.CekKetersediaan();
        }
    }
}