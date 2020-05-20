using BarBoekRegistratie.DAL;
using BarBoekRegistratie.DAL.Club;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBoekRegistratie.BLL
{
    class ClubContainer
    {
        private IClubContainer clubContainer;
        public ClubContainer(IClubContainer clubContainer)
        {
            this.clubContainer = clubContainer;
        }
        public Club Findby(string clubname)
        {          
            ClubDTO clubDTO = clubContainer.Findby(clubname);
            Club club = new Club(clubDTO);
            return club;
        }
    }
}
