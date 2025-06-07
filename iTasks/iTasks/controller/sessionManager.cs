using iTasks.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.controller
{
    internal static class sessionManager
    {
        public static Users CurrentUser { get; set; }

        public static void Login(Users user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }
    }
}
