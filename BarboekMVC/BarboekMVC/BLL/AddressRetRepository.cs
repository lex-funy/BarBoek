using BarboekMVC.Interface;
using BarboekMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarboekMVC.BLL
{
    public class AddressRetRepository
    {
        iAddressRetrieveContext ContextRet;
        public AddressRetRepository(iAddressRetrieveContext contextRet)
        {
            ContextRet = contextRet;
        }
        public List<AddressModel> GetAll()
        {
            return ContextRet.GetAllAddresses();
        }
        public AddressModel GetByID(int id)
        {
            return ContextRet.FindAddressById(id);
        }
        public AddressModel GetByCode(string address)
        {
            return ContextRet.FindAddressByCode(address);
        }
    }
}
