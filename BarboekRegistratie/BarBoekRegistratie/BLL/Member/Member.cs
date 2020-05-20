using BarBoekRegistratie.DAL.Member;
using BarBoekRegistratie.DAL.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BarBoekRegistratie
{ 
     class Member: User
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public Member(MemberDTO memberDTO, UserDTO userDTO) : base(userDTO)
        {
            MemberId = memberDTO.MemberId;
            Name = memberDTO.Name;
        }
        public override string ToString()
        {
            return $"{Name},{Email},{Password}";
        }
    }
}
