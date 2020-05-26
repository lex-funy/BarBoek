using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ClassLibrary.DAL.Model;

namespace ClassLibrary.DAL.Context
{
    public class ClubContext: DB,IClubContext
    {
        public ClubContext(string connString) : base(connString)
        {

        }
        public List<ClubModel> GetAll()
        {
            string mysql = "Select * from club ";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            DataSet results = ExecuteSql(mysql, parameters);

            List<ClubModel> clubs = new List<ClubModel>();
            if (results != null)
            {

                for (int x = 0; x < results.Tables[0].Rows.Count; x++)
                {
                    ClubModel club = DataSetParser.DataSetToClub(results, x);
                    clubs.Add(club);
                }
            }
            return clubs;
        }
        public ClubModel GetClubById(int id)
        {
            string mysql = "Select * from club where clubId=@clubId";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("clubId", id.ToString()));

            DataSet results = ExecuteSql(mysql, parameters);
            ClubModel club = null;

            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                club = DataSetParser.DataSetToClub(results, 0);
            }
            return club;
        }
        public ClubModel GetClubByName(string name)
        {
            string mysql = "Select * from club where clubname=@clubname";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("clubname", name));

            DataSet results = ExecuteSql(mysql, parameters);
            ClubModel club = null;

            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                club = DataSetParser.DataSetToClub(results, 0);
            }
            return club;
        }
        public int Insert(ClubModel club)
        {
            string mysql = "INSERT INTO club(clubbondnr,clubname,contactperson,street,addition,postcode,plaats,email,type,comment) OUTPUT Inserted.clubId VALUES (@clubbondnr,@clubname,@contactperson,@street,@addition,@postcode,@plaats,@email,@type,@comment)";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("clubname", club.Name));
            parameters.Add(new KeyValuePair<string, string>("clubbondnr", club.ClubBondnr.ToString()));
            parameters.Add(new KeyValuePair<string, string>("contactperson", club.Contactperson));
            parameters.Add(new KeyValuePair<string, string>("street", club.Street));
            parameters.Add(new KeyValuePair<string, string>("addition", club.Addition));
            parameters.Add(new KeyValuePair<string, string>("postcode", club.Postcode));
            parameters.Add(new KeyValuePair<string, string>("plaats", club.Location));
            parameters.Add(new KeyValuePair<string, string>("email", club.Email));
            parameters.Add(new KeyValuePair<string, string>("type", club.Type));
            parameters.Add(new KeyValuePair<string, string>("comment", club.Comment));
            DataSet result = ExecuteSql(mysql, parameters);
            int id = (int)((decimal)result.Tables[0].Rows[0][0]);
            return id;

        }

        public void Delete(int id)
        {
            string mysql = "delete from club where clbId=@clubId";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("clubId", id.ToString()));
            ExecuteSql(mysql, parameters);
        }

        public void Update(ClubModel club)
        {
            string mysql = "update club set clubname=@name where clubId=@clubId";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("clubId", club.ClubId.ToString()));
            parameters.Add(new KeyValuePair<string, string>("clubname", club.Name));
            ExecuteSql(mysql, parameters);
        }
        public bool Inloggen(ClubModel club)
        {
            bool check = false;
            string mysql = "Select * from club where clubbondnr=@clubbondnr and postcode=@postcode";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("clubbondnr", club.ClubBondnr.ToString()));
            parameters.Add(new KeyValuePair<string, string>("postcode", club.Postcode));
            DataSet results = ExecuteSql(mysql, parameters);
            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                check = true;
            }
            return check;

        }
    }
}
