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
                        ? new Pemilik()
                        : new Penyewa();

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

        public bool Register(User user, string roleStr)
        {
            try
            {
                if (IsUsernameTaken(user.Username))
                {
                    MessageBox.Show("Username sudah digunakan.", "Registrasi Gagal",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!string.IsNullOrEmpty(user.Email) && IsEmailTaken(user.Email))
                {
                    MessageBox.Show("Email sudah digunakan.", "Registrasi Gagal",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                using var conn = DbHelper.GetConnection();
                conn.Open();

                string query = @"INSERT INTO ""user"" (username, password, nama, email, no_hp, alamat, role, created_at)
                                 VALUES (@username, @password, @nama, @email, @no_hp, @alamat, @role, @created_at)";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("username", user.Username);
                cmd.Parameters.AddWithValue("password", user.Password);
                cmd.Parameters.AddWithValue("nama", user.Nama);
                cmd.Parameters.AddWithValue("email", string.IsNullOrEmpty(user.Email) ? (object)DBNull.Value : user.Email);
                cmd.Parameters.AddWithValue("no_hp", string.IsNullOrEmpty(user.NoHp) ? (object)DBNull.Value : user.NoHp);
                cmd.Parameters.AddWithValue("alamat", string.IsNullOrEmpty(user.Alamat) ? (object)DBNull.Value : user.Alamat);
                cmd.Parameters.AddWithValue("role", roleStr); // 'Pemilik' atau 'Penyewa'
                cmd.Parameters.AddWithValue("created_at", DateTime.Now);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Register error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
            catch
            {
                return false;
            }
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
            catch
            {
                return false;
            }
        }
    }
}