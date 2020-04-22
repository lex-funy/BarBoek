using Barboek.ClassLib.DAL.Model;
using ClassLibBarboek;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barboek.ClassLib.DAL
{
    class DataSetParser
    {
        public static ClubDTO DataSetToClub(DataSet set, int rowIndex)
        {
            return new ClubDTO()
            {
                ID = (int)set.Tables[0].Rows[rowIndex][0],
                Name = set.Tables[0].Rows[rowIndex][1].ToString(),
                Address = (AddressDTO)set.Tables[0].Rows[rowIndex][2],
                ClubNumber = set.Tables[0].Rows[rowIndex][3].ToString(),
                Email = set.Tables[0].Rows[rowIndex][4].ToString()
                
                
            };
        }

        public static AddressDTO DataSetToAddress(DataSet set, int rowIndex)
        {
            return new AddressDTO()
            {
                ID = (int)set.Tables[0].Rows[rowIndex][0],
                ZipCode = set.Tables[0].Rows[rowIndex][1].ToString(),
                Number = (int)set.Tables[0].Rows[rowIndex][2],
                Addition = set.Tables[0].Rows[rowIndex][3].ToString()
            };
        }
    }
}
