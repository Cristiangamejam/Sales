using ejemplo.Entities;
using ejemplo.Repository;
using ejemplo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo.EApplication
{
    public class LoginAAplication
    {
        static Guid _session;
        private UserRepository _repo;

        public LoginAAplication()
        {
            _repo = new UserRepository();
        }

        //public static Guid Session
        //{
        //    get
        //    {
        //        return _session;
        //    }
        //}

        public void LogOut()
        {
            SessionManager.Logout();
        }

        public void Login (string username, string password)
        {
            
            // La función es validar
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception ("Ingrese usuario y contraseña");
            }

            User  user  = _repo.Login(username, password);
            if(user == null)
            {
                throw new Exception("Ingrese usuario no encontrado");
            }

           SessionManager.Login(user);
        }
    }
}
