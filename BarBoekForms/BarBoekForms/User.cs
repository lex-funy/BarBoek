using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBoekForms
{
    class User
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

        public User(UserDTO userDto)
        {
            this.Bondnumber = userDto.Bondnumber;
            this.Lastname = userDto.Lastname;
            this.Initials = userDto.Initials;
            this.Insertion = userDto.Initials;
            this.Name = userDto.Name;
            this.Permission = userDto.Permission;
            this.AssociationNumber = userDto.AssociationNumber;
            this.Birthdate = userDto.Birthdate;
            this.Email = userDto.Email;
            this.Password = userDto.Password;
            this.Gender = userDto.Gender;
            this.Phone = userDto.Phone;
            this.PhoneWork = userDto.PhoneWork;
            this.PhoneMobile = userDto.PhoneMobile;

            this.Address = new Address();
            this.Shifts = new List<Shift>();
        }

        public bool AddShift(Shift newShift)
        {
            bool add = true;
            foreach (Shift shift in this.Shifts)
            {
                // Als de shift niet in een bestaande shift valt wordt hij toegevoegd.

                // Een shift valt niet binnen een bestaande shift als ->
                // de start datum tijd na een de shift valt.
                // de eind datum tijd voor de shift valt.

                // if start of old shift is before end of new shift -> overlap
                if (shift.Start.CompareTo(newShift.End) == 1)
                {
                    add = false;
                    break;
                }

                // if end of old shift is before start of new shift -> overlap
                if (shift.End.CompareTo(newShift.Start) == 1)
                {
                    add = false;
                    break;
                }
            }

            if (add)
                this.Shifts.Add(newShift);

            return add;
        }

        public override string ToString()
        {
            if (this.Name == null || this.Name == "")
                return "Unnamed user";
            return $"{this.Name}";
        }
    }
}
