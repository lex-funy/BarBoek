using BarboekMVC.Interface;
using BarboekMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarboekMVC.BLL
{
    public class ClubSaveRepository
    {
        iClubSaveContext ContextSave;
        public ClubSaveRepository(iClubSaveContext contextSave)
        {
            ContextSave = contextSave;
        }
        public void CreateClub(ClubModel club)
        {
            ContextSave.InsertClub(club);
        }
        public void CreateAddress(ClubModel club)
        {
            ContextSave.InsertAddress(club);
        }
    }
}
