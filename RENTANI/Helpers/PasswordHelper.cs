using System;
using System.Security.Cryptography;
using System.Text;

namespace RENTANI.Helpers
{
    public static class PasswordHelper
    {
        // Mengubah password biasa menjadi kode acak (Hash)
        public static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Mengecek apakah password inputan sama dengan password acak di database
        public static bool VerifyPassword(string inputPassword, string hashedPasswordInDb)
        {
            string hashedInput = HashPassword(inputPassword);
            return string.Equals(hashedInput, hashedPasswordInDb, StringComparison.OrdinalIgnoreCase);
        }
    }
}