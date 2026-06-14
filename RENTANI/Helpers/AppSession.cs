using System;
using RentaniApp.Models;

namespace RentaniApp.Helpers
{
    public static class AppSession
    {
        public static User CurrentUser { get; private set; }
        public static DateTime LoginTime { get; private set; }
        public static void StartSession(User user)
        {
            CurrentUser = user;
            LoginTime = DateTime.Now;
        }
        public static void EndSession()
        {
            if (CurrentUser != null)
            {
                CurrentUser.Logout();
            }

            CurrentUser = null;
            LoginTime = DateTime.MinValue;
        }

        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }
    }
}