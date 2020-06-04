using BarboekMVC.Interface;
using BarboekMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarboekMVC.BLL
{
    public class ClubRetRepository
    {
        iClubRetrieveContext ContextRet;
        public ClubRetRepository(iClubRetrieveContext contextRet)
        {
            ContextRet = contextRet;
        }
        public List<ClubModel> GetAll()
        {
            return ContextRet.GetAllClubs();
        }
        public ClubModel GetByID(int id)
        {
            return ContextRet.FindClubById(id);
        }
        public AddressModel GetByCode(string club)
        {
            return ContextRet.FindAddressByCode(club);
        }
    }
}
