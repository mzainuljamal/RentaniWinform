namespace RentaniApp.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string NoHp { get; set; }
        public string Alamat { get; set; }

        // POLYMORPHISM
        public abstract string GetRole();
        public abstract void Logout();
    }
}