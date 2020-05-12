using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBoekForms
{
    class UserContainer
    {
        public static List<UserDTO> ImportFromExcel(string fileLocation = @"C:\Users\Lex-Desktop\Documents\leden.xlsx")
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

                temp.Bondnumber = worksheet.Cells[i, 1].Text;  // Bondsnummer
                temp.Lastname = worksheet.Cells[i, 2].Text;  // Achternaam
                temp.Initials = worksheet.Cells[i, 3].Text;  // Voorletters
                temp.Insertion = worksheet.Cells[i, 4].Text;  // Tussenvoegsel
                temp.Name = worksheet.Cells[i, 5].Text;  // Roepnaam

                temp.Address.Street = worksheet.Cells[i, 6].Text;  // Straat
                temp.Address.HouseNumber = Int32.Parse(worksheet.Cells[i, 7].Text);  // Huis nummer
                temp.Address.Addition = worksheet.Cells[i, 8].Text;  // toevoeging
                temp.Address.ZipCode = worksheet.Cells[i, 9].Text;  // postcode
                temp.Address.Residence = worksheet.Cells[i, 10].Text; // woonplaats
                temp.Address.Country = worksheet.Cells[i, 11].Text; // land

                temp.Phone = worksheet.Cells[i, 12].Text; // telefoon
                temp.Gender = worksheet.Cells[i, 13].Text; // geslacht
                temp.Birthdate = DateTime.Parse(worksheet.Cells[i, 14].Text); // geboorte datum
                temp.AssociationNumber = Int32.Parse(worksheet.Cells[i, 15].Text); // verenigings lidnummer
                temp.Email = worksheet.Cells[i, 16].Text; // email
                temp.PhoneWork = worksheet.Cells[i, 17].Text; // telefoon werk
                temp.PhoneMobile = worksheet.Cells[i, 18].Text; // telefoon mobiel

                // TODO: Create user from userdto
                User user = new User(temp);

                // TODO: Add user to database
                UserContainer.Save(user);


                users.Add(temp);
            }

            return users;
        }

        public static bool Save(User user)
        {
            UserDTO userDto = new UserDTO(user);

            throw new NotImplementedException();
        }
    }
}
