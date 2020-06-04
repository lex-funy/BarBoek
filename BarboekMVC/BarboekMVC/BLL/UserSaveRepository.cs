using BarboekMVC.Interface;
using BarboekMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarboekMVC.BLL
{
    public class UserSaveRepository
    {
        iUserSaveContext ContextSave;
        public UserSaveRepository(iUserSaveContext contextSave)
        {
            ContextSave = contextSave;
        }
        public void CreateUser(UserModel user)
        {
            ContextSave.InsertUser(user);
        }
    }
}
