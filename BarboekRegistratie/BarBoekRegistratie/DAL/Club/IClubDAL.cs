using BarBoekRegistratie.DAL;
using BarBoekRegistratie.DAL.Club;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBoekRegistratie.Classes
{
    interface IClubDAL
    {
        void Insert(ClubDTO clubDTO);
        void Update(ClubDTO clubDTO);
        List<ClubDTO> GetAll();
        ClubDTO Findby(string clubname);
        void Delete(ClubDTO clubDTO);
        bool Inloggen(ClubDTO clubDTO);
        List<ClubDTO> Search(string clubname);
        Boolean Check(ClubDTO clubDTO);
    }
}
