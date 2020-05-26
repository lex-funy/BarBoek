using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.DAL.Model
{
    public class ClubModel
    {
        public int ClubId { get; set; }
        public int ClubBondnr { get; set; }
        public string Name { get; set; }
        public string Contactperson { get; set; }
        public string Street { get; set; }
        public string Addition { get; set; }
        public string Postcode { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
    }
}
