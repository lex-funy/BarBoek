using BarBoekRegistratie.DAL.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBoekRegistratie
{  
     abstract class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(UserDTO userDTO)
        {
            userDTO.UserId = UserId;
            userDTO.Email = Email;
            userDTO.Password = Password;
        }
        public override string ToString()
        {
            return $"{UserId},{Email},{Password}";
        }
    }
}
