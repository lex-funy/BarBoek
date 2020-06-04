using BarboekMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace BarboekMVC.DAL
{
    public class DataSetParser
    {
        public static AddressModel DataSetToAddress(DataSet set, int rowIndex)
        {
            return new ClubModel()
            {
                ID = (int)set.Tables[0].Rows[rowIndex][0],
                ZipCode = set.Tables[0].Rows[rowIndex][1].ToString(),
                Number = (int)set.Tables[0].Rows[rowIndex][2],
                Addition = set.Tables[0].Rows[rowIndex][3].ToString(),
                Street = set.Tables[0].Rows[rowIndex][4].ToString()                
            };
        }
        public static ClubModel DataSetToClub(DataSet set, int rowIndex)
        {
            return new ClubModel()
            {
                ID = (int)set.Tables[0].Rows[rowIndex][0],
                Name = set.Tables[0].Rows[rowIndex][1].ToString(),
                AID = (int)set.Tables[0].Rows[rowIndex][2],
                Email = set.Tables[0].Rows[rowIndex][3].ToString(),
                Postcode = set.Tables[0].Rows[rowIndex][4].ToString(),
                ClubNumber = set.Tables[0].Rows[rowIndex][5].ToString(),
                Test = set.Tables[0].Rows[rowIndex][6].ToString(),
                Comment = set.Tables[0].Rows[rowIndex][7].ToString()
            };
        }
        public static UserModel DataSetToUser(DataSet set,int rowIndex)
        {
            return new UserModel()
            {
                UID = (int)set.Tables[0].Rows[rowIndex][0],
                UEmail = set.Tables[0].Rows[rowIndex][1].ToString(),
                Password = set.Tables[0].Rows[rowIndex][2].ToString()
            };
        }
    }
}
