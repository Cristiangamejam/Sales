using ejemplo.Abstractions;
using System;

namespace ejemplo.Services
{
    public  class SessionManager
    {
        private static IUser _session;
        
        public static IUser Session
        {
            get
            {
                return _session;
            }
        }

        public static bool IsLogeed()
        {
            return _session == null;
        }

        public static void Login(IUser user)
        {
             _session = user;
        } 

        public static void Logout()
        {
            _session = null;
        }
    }
}
