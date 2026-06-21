using Npgsql;
using RentaniApp.Helpers;
using RentaniApp.Models;
using System;
using System.Windows.Forms;

namespace RentaniApp.Controllers
{
    public class AutentikasiController
    {
        public User Login(string username, string password)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                string query = @"SELECT id_user, username, password, nama, email, no_hp, alamat, role
                                 FROM ""user""
                                 WHERE username = @username AND password = @password";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string roleStr = reader.GetString(7);

                    User user = roleStr.Equals("Pemilik", StringComparison.OrdinalIgnoreCase)
                        ? (User)new Pemilik()
                        : (User)new Penyewa();

                    user.Id = reader.GetInt32(0);
                    user.Username = reader.GetString(1);
                    user.Password = reader.GetString(2);
                    user.Nama = reader.GetString(3);
                    user.Email = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    user.NoHp = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    user.Alamat = reader.IsDBNull(6) ? "" : reader.GetString(6);

                    return user;
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool RegisterPenyewa(Penyewa penyewa)
        {
            if (IsUsernameTaken(penyewa.Username))
            {
                MessageBox.Show("Username sudah digunakan.", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrEmpty(penyewa.Email) && IsEmailTaken(penyewa.Email))
            {
                MessageBox.Show("Email sudah digunakan.", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return penyewa.SimpanKeDatabase();
        }

        private bool IsUsernameTaken(string username)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string query = @"SELECT COUNT(*) FROM ""user"" WHERE username = @username";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("username", username);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            catch { return false; }
        }

        private bool IsEmailTaken(string email)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string query = @"SELECT COUNT(*) FROM ""user"" WHERE email = @email";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("email", email);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            catch { return false; }
        }
    }
}