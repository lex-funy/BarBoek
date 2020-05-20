using BarBoekRegistratie.DAL.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBoekRegistratie.BLL
{
    class UserContainer
    {
        private IUserContainer userContainer;
        public UserContainer(IUserContainer userContainer)
        {
            this.userContainer = userContainer;
        }
        public User Findbysername(User user, string email)
        {
            UserDTO userDTO = userContainer.Findbyemail(email);
            return user;
        }

    }
}
