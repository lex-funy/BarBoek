using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBoekRegistratie.DAL.Club
{
    interface IClubContainer
    {
        ClubDTO Findby(string email);
        List<ClubDTO> GetAll();
    }
}
