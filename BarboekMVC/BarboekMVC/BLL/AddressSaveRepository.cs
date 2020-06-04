using BarboekMVC.Interface;
using BarboekMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarboekMVC.BLL
{
    public class AddressSaveRepository
    {
        iAddressSaveContext ContextSave;
        public AddressSaveRepository(iAddressSaveContext contextSave)
        {
            ContextSave = contextSave;
        }
        public void CreateAddress(AddressModel address)
        {
            ContextSave.InsertAddress(address);
        }
    }
}
