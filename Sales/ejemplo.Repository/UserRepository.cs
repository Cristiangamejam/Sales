using ejemplo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo.Repository
{
    public class UserRepository
    {
        public User GetUser(Guid id)
        {
            //me conecto a la base de datos
            //obtengo el usuario
            return new User { Id = 1, Name = "Cristian" };
        }

        public User Login(string username, string password)
        {
            
            //Coneccion base de datos 

            return new User {  Id = 1, Name = "Cristian"}  ;
        }
    }
}
