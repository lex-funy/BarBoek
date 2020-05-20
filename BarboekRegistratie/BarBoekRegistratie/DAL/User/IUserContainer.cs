using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBoekRegistratie.DAL.User
{
    interface IUserContainer
    {
        UserDTO Findbyemail(string email);
        List<UserDTO> GetAll();
    }
}
