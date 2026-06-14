namespace RentaniApp.Helpers
{
    public static class Session
    {
        public static int IdUser { get; set; }
        public static int IdRoleSpecific { get; set; }
        public static string Username { get; set; }
        public static string Nama { get; set; }
        public static string Role { get; set; }

        public static void Clear()
        {
            IdUser = 0;
            IdRoleSpecific = 0;
            Username = Nama = Role = null;
        }
    }
}
