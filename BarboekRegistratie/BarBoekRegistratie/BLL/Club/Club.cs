using BarBoekRegistratie.DAL;
using BarBoekRegistratie.DAL.Club;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBoekRegistratie
{
     class Club
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
        public Club(ClubDTO clubDTO)
        {
            ClubId = clubDTO.ClubId;
            ClubBondnr = clubDTO.ClubBondnr;
            Name = clubDTO.Name;
            Contactperson = clubDTO.Contactperson;
            Street = clubDTO.Street;
            Addition = clubDTO.Addition;
            Postcode = clubDTO.Postcode;
            Location = clubDTO.Location;
            Email = clubDTO.Email;
            Type = clubDTO.Type;
            Comment = clubDTO.Comment;
        }
        public override string ToString()
        {
            return $"{ClubId} {Name}";
        }
    }
}
