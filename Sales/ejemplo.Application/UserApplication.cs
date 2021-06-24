using ejemplo.Entities;
using ejemplo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo.EApplication
{
    public class UserApplication
    {
        UserRepository _userRepository;
        public UserApplication()
        {
            _userRepository = new UserRepository();
        }
        public User GetUser(Guid id)
        {

            // La función es validar
            if(id ==Guid.Empty)
            {
                throw new Exception("error");
            }

            return _userRepository.GetUser(id);
        }
    }
}
