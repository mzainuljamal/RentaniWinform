using System;
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

   
        public bool SimpanKeDatabase()
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();
            using var trans = conn.BeginTransaction(); 

            try
            {
                string queryUser = @"INSERT INTO ""user"" (username, password, nama, email, no_hp, alamat, role, created_at)
                                     VALUES (@username, @password, @nama, @email, @no_hp, @alamat, 'Penyewa', @created_at)
                                     RETURNING id_user";

                using var cmdUser = new NpgsqlCommand(queryUser, conn, trans);
                cmdUser.Parameters.AddWithValue("username", this.Username);
                cmdUser.Parameters.AddWithValue("password", this.Password);
                cmdUser.Parameters.AddWithValue("nama", this.Nama);
                cmdUser.Parameters.AddWithValue("email", string.IsNullOrEmpty(this.Email) ? (object)DBNull.Value : this.Email);
                cmdUser.Parameters.AddWithValue("no_hp", string.IsNullOrEmpty(this.NoHp) ? (object)DBNull.Value : this.NoHp);
                cmdUser.Parameters.AddWithValue("alamat", string.IsNullOrEmpty(this.Alamat) ? (object)DBNull.Value : this.Alamat);
                cmdUser.Parameters.AddWithValue("created_at", DateTime.Now);


                this.Id = Convert.ToInt32(cmdUser.ExecuteScalar());

                string queryPenyewa = @"INSERT INTO penyewa (id_user, nik, pekerjaan)
                                        VALUES (@id_user, @nik, @pekerjaan)";

                using var cmdPenyewa = new NpgsqlCommand(queryPenyewa, conn, trans);
                cmdPenyewa.Parameters.AddWithValue("id_user", this.Id);
                cmdPenyewa.Parameters.AddWithValue("nik", string.IsNullOrEmpty(this.Nik) ? (object)DBNull.Value : this.Nik);
                cmdPenyewa.Parameters.AddWithValue("pekerjaan", string.IsNullOrEmpty(this.Pekerjaan) ? (object)DBNull.Value : this.Pekerjaan);

                cmdPenyewa.ExecuteNonQuery();

                trans.Commit(); 
                return true;
            }
            catch (Exception)
            {
                trans.Rollback(); 
                throw;
            }
        }
    }
}