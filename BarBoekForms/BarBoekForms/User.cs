using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace BarBoekForms
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

        public List<UserDTO> ImportFromExcel(string fileLocation = @"C:\Users\Lex-Desktop\Documents\leden.xlsx")
        {
            Application excelApplication = new Application();

            Workbook workbook = excelApplication.Workbooks.Open(fileLocation);
            Worksheet worksheet = workbook.Sheets[1];

            int rows = worksheet.UsedRange.Rows.Count;
            int columns = worksheet.UsedRange.Columns.Count;

            List<UserDTO> users = new List<UserDTO>();
            for (int i = 2; i < rows; i++)
            {
                UserDTO temp = new UserDTO();
                temp.Address = new AddressDTO();

                temp.Bondnumber          = worksheet.Cells[i, 1].Text;  // Bondsnummer
                temp.Lastname            = worksheet.Cells[i, 2].Text;  // Achternaam
                temp.Initials            = worksheet.Cells[i, 3].Text;  // Voorletters
                temp.Insertion           = worksheet.Cells[i, 4].Text;  // Tussenvoegsel
                temp.Name                = worksheet.Cells[i, 5].Text;  // Roepnaam

                temp.Address.Street      = worksheet.Cells[i, 6].Text;  // Straat
                temp.Address.HouseNumber = Int32.Parse(worksheet.Cells[i, 7].Text);  // Huis nummer
                temp.Address.Addition    = worksheet.Cells[i, 8].Text;  // toevoeging
                temp.Address.ZipCode     = worksheet.Cells[i, 9].Text;  // postcode
                temp.Address.Residence   = worksheet.Cells[i, 10].Text; // woonplaats
                temp.Address.Country     = worksheet.Cells[i, 11].Text; // land

                temp.Phone               = worksheet.Cells[i, 12].Text; // telefoon
                temp.Gender              = worksheet.Cells[i, 13].Text; // geslacht
                temp.Birthdate           = DateTime.Parse(worksheet.Cells[i, 14].Text); // geboorte datum
                temp.AssociationNumber   = Int32.Parse(worksheet.Cells[i, 15].Text); // verenigings lidnummer
                temp.Email               = worksheet.Cells[i, 16].Text; // email
                temp.PhoneWork           = worksheet.Cells[i, 17].Text; // telefoon werk
                temp.PhoneMobile         = worksheet.Cells[i, 18].Text; // telefoon mobiel

                users.Add(temp);
            }

            return users;
        }
    }
}
