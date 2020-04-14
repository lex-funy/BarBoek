using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBoekRegistratie
{
    public class Club
    {
        public int ClubId { get; set; }
        public int ClubBondnr { get; set; }
        public string Name { get; set; }
        public string Contactperson { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }


    }
}
