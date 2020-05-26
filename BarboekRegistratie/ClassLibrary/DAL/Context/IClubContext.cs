using ClassLibrary.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.DAL.Context
{
    public interface IClubContext
    {
        List<ClubModel> GetAll();
        ClubModel GetClubById(int id);
        ClubModel GetClubByName(string name);
        int Insert(ClubModel club);
        void Delete(int id);
        void Update(ClubModel club);
        bool Inloggen(ClubModel club);
    }
}
