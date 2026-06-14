using System;
using Npgsql;

namespace RentaniApp.Helpers
{
    public static class DbHelper
    {
        private static readonly string connectionString =
            "Host=localhost;" +
            "Port=5432;" +
            "Username=postgres;" +
            "Password=jeje123;" +
            "Database=RENTANI";
        public static NpgsqlConnection GetConnection()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            return conn;
        }
    }
}
