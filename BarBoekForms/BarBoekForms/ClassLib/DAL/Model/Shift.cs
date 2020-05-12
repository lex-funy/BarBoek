using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barboek.ClassLib.DAL.Model
{
    struct ShiftDTO
    {
        public int ID { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int MaxMemberCount { get; set; }
        public List<MemberDTO> Members {get; set;}
    }
}
