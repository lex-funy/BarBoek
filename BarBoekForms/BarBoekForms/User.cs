using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DienstToevoegen
{
    class User
    {
        public string Name { get; set; }
        public List<Shift> Shifts { get; }

        public User(string name)
        {
            this.Name = name;
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
