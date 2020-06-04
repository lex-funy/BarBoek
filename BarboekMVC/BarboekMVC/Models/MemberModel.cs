using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarboekMVC.Models
{
    public class MemberModel:UserModel
    {
        public enum AccessLevel
        {
            Member,
            Admin,
            Super
        }

    }
}
