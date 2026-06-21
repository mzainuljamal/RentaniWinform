using System;

namespace RentaniApp.Models
{
    public class mRating
    {
        public int IdRating { get; set; }
        public int Skor { get; set; }
        public string Keterangan { get; set; }

        public mRating() { }
        public mRating(int id, int skor, string ket)
        {
            IdRating = id;
            Skor = skor;
            Keterangan = ket;
        }
    }
}