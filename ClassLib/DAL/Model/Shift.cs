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
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int MaxMemberCount { get; set; }
        public List<MemberDTO> Members {get; set;}
    }
}
