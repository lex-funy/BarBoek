﻿using Barboek.ClassLib.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Barboek.ClassLib.DAL.Contexts
{
    public interface iClubRetrieveContext
    {
        ClubDTO FindClubById(int id);
        List<ClubDTO> GetAllClubs();
    }
}
