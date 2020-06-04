using BarboekMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarboekMVC.Interface
{
    public interface iAddressSaveContext
    {
        void InsertAddress(AddressModel address);       
    }
}
