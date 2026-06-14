
namespace RentaniApp.Models
{
    public class Pemilik : User
    {
        public int IdPemilik { get; set; }
        public string NamaUsaha { get; set; }
        public string Rekening { get; set; }
        public string AlamatUsaha { get; set; }

        public Pemilik() { }

        public override string GetRole()
        {
            return "Pemilik";
        }
        public override void Logout()
        {
        }

        public void TambahAlat(Alat a)
        {
            Console.WriteLine($"Alat {a.NamaAlat} berhasil ditambahkan ke inventaris.");
        }

        public void UbahAlat(Alat a)
        {
            Console.WriteLine($"Data alat {a.NamaAlat} berhasil diperbarui.");
        }

        public void HapusAlat(int id)
        {
            Console.WriteLine($"Alat dengan ID {id} berhasil dihapus.");
        }

        public void VerifikasiSewa(int id, bool ok) { }

        public void KonfirmasiBayar(int id) { }

        public decimal LihatPendapatan() => 0;

        public List<Penyewaan> LihatUlasan()
        {
            return new List<Penyewaan>();
        }
    }
}