using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ClassLibrary.DAL.Model;

namespace ClassLibrary.DAL
{
    public class DataSetParser
    {
        public static ClubModel DataSetToClub(DataSet set, int rowIndex)
        {
            return new ClubModel()
            {
                ClubId = (int)set.Tables[0].Rows[rowIndex][0],
                ClubBondnr = (int)set.Tables[0].Rows[rowIndex][1],
                Name = set.Tables[0].Rows[rowIndex][2].ToString(),
                Contactperson = set.Tables[0].Rows[rowIndex][3].ToString(),
                Street = set.Tables[0].Rows[rowIndex][4].ToString(),
                Postcode = set.Tables[0].Rows[rowIndex][5].ToString(),
                Location = set.Tables[0].Rows[rowIndex][6].ToString(),
                Email = set.Tables[0].Rows[rowIndex][7].ToString(),
                Type = set.Tables[0].Rows[rowIndex][8].ToString(),
                Comment = set.Tables[0].Rows[rowIndex][9].ToString(),
                Addition = set.Tables[0].Rows[rowIndex][10].ToString(),
            };
        }
    }
}
