using BarboekMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarboekMVC.Interface
{
    public interface iClubRetrieveContext
    {
        List<ClubModel> GetAllClubs();
        ClubModel FindClubById(int id);
        bool Inloggen(ClubModel club);
        bool CheckValidate(ClubModel club);
        ClubModel FindAddressByCode(string address);
    }
}
