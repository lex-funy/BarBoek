using BarBoekRegistratie.DAL.User;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBoekRegistratie
{
    interface IUserDAL
    {
        void Insert(UserDTO userDTO);
        void Update(UserDTO userDTO);
        List<UserDTO> GetAll();
        UserDTO Findbyemail(string email);
        void Delete(UserDTO userDTO);
        bool Inloggen(UserDTO userDTO);
        List<UserDTO> Search(string email);
        Boolean Check(UserDTO userDTO);
    }
}
