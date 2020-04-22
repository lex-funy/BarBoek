﻿using Barboek.ClassLib.DAL.Model;
using ClassLibBarboek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barboek.ClassLib.DAL.Contexts
{
    public interface iAddressRetrieveContext
    {
        List<AddressDTO> GetAllAddresses();
        AddressDTO FindAddressById(int id);
    }
}
