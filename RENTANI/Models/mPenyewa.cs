using System.Collections.Generic;
using System.Data;
using Npgsql;
using RentaniApp.Helpers;

namespace RentaniApp.Models
{
    public class Penyewa : User
    {
        public int IdPenyewa { get; set; }
        public string Nik { get; set; }
        public string Pekerjaan { get; set; }

        public override string GetRole() => "Penyewa";

        public override void Logout()
        {
        }
    }
}
