using BarboekMVC.Interface;
using BarboekMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarboekMVC.BLL
{
    public class UserRetRepository
    {
        iUserRetrieveContext ContextRet;
        public UserRetRepository(iUserRetrieveContext contextRet)
        {
            ContextRet = contextRet;
        }
        public List<UserModel> GetAll()
        {
            return ContextRet.GetAllUsers();
        }


    }
}
