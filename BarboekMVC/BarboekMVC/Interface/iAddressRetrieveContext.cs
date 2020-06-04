using BarboekMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarboekMVC.Interface
{
    public interface iAddressRetrieveContext
    {
        List<AddressModel> GetAllAddresses();
        AddressModel FindAddressById(int id);
        AddressModel FindAddressByCode(string address);
    }
}
