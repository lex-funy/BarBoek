using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBoekForms
{
    class UserDTO
    {
        public string Bondnumber;
        public string Lastname;
        public string Initials;
        public string Insertion;
        public string Name;
        public int Permission;
        public int AssociationNumber;
        public DateTime Birthdate;
        public string Email;
        public string Password;
        public string Gender;
        public string Phone;
        public string PhoneWork;
        public string PhoneMobile;

        public Address Address;
        public List<Shift> Shifts { get; set; }

        public UserDTO() 
        { 

        }

        public UserDTO(User user)
        {
            this.Bondnumber = user.Bondnumber;
            this.Lastname = user.Lastname;
            this.Initials = user.Initials;
            this.Insertion = user.Initials;
            this.Name = user.Name;
            this.Permission = user.Permission;
            this.AssociationNumber = user.AssociationNumber;
            this.Birthdate = user.Birthdate;
            this.Email = user.Email;
            this.Password = user.Password;
            this.Gender = user.Gender;
            this.Phone = user.Phone;
            this.PhoneWork = user.PhoneWork;
            this.PhoneMobile = user.PhoneMobile;

            this.Address = user.Address;
            this.Shifts = user.Shifts;
        }
    }
}
