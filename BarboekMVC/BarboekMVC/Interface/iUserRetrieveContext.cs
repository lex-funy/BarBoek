using BarboekMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarboekMVC.Interface
{
    public interface iUserRetrieveContext
    {
        List<UserModel> GetAllUsers();
        bool Inloggen(UserModel user);
        bool CheckValidate(UserModel user);
    }
}
