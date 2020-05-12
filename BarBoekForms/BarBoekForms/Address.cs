using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBoekForms
{
    class Address
    {
        public int Id;
        public int UserId;
        public string Street;
        public int HouseNumber;
        public string Addition;
        public string ZipCode;
        public string Residence;
        public string Country;

        public Address() { }

        public Address(AddressDTO addressDto)
        {
            this.Id = addressDto.Id;
            this.UserId = addressDto.UserId;
            this.Street = addressDto.Street;
            this.HouseNumber = addressDto.HouseNumber;
            this.Addition = addressDto.Addition;
            this.ZipCode = addressDto.ZipCode;
            this.Residence = addressDto.Residence;
            this.Country = addressDto.Country;
        }
    }
}
