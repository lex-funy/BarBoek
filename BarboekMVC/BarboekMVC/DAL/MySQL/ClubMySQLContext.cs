using BarboekMVC.Interface;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarboekMVC.Models;

namespace BarboekMVC.DAL.MySQL
{
    public class ClubMySQLContext: BaseMYSQLContext,iClubRetrieveContext,iClubSaveContext
    {
        public ClubMySQLContext(string connString) : base(connString)
        {

        }

        public List<ClubModel> GetAllClubs()
        {
            string query = "Select * from club ";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            DataSet results = ExecuteQuery(query, parameters);

            List<ClubModel> clubs = new List<ClubModel>();

            if (results != null)
            {

                for (int x = 0; x < results.Tables[0].Rows.Count; x++)
                {
                    ClubModel c = DataSetParser.DataSetToClub(results, x);
                    clubs.Add(c);
                }
            }
            return clubs;
        }

        public ClubModel FindClubById(int id)
        {
            string query = "Select * from club where ID=@ID";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("ID", id.ToString()));

            DataSet results = ExecuteQuery(query, parameters);
            ClubModel c = new ClubModel();

            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                c = DataSetParser.DataSetToClub(results, 0);
            }
            return c;
        }
        public ClubModel FindAddressByCode(string address)
        {
            string query = "Select * from adres where zipcode=@zipcode";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("zipcode", address));
            DataSet results = ExecuteQuery(query, parameters);
            AddressModel a = new ClubModel();
            ClubModel c = new ClubModel();
            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                a = DataSetParser.DataSetToAddress(results, 0);
                c.AID = a.AID;

            }
            return c;
        }

        public void InsertClub(ClubModel club)
        {
            string sql = "SET FOREIGN_KEY_CHECKS=0;INSERT INTO club (name,adresId,email,password,clubnumber,type,comment) VALUES(@name,@adresId,@email,@password,@clubnumber,@type,@comment);SET FOREIGN_KEY_CHECKS=0;";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("name", club.Name.ToString()));
            parameters.Add(new KeyValuePair<string, string>("adresId", club.AID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("email", club.Email.ToString()));
            parameters.Add(new KeyValuePair<string, string>("password", club.Postcode.ToString()));
            parameters.Add(new KeyValuePair<string, string>("clubnumber", club.ClubNumber));
            parameters.Add(new KeyValuePair<string, string>("type", club.Test));
            parameters.Add(new KeyValuePair<string, string>("comment", club.Comment));

            DataSet result = ExecuteQuery(sql, parameters);
        }
        public void InsertAddress(ClubModel club)
        {
            string sql = " INSERT INTO adres(zipcode, number, addition,street) VALUES(@zipcode, @number, @addition,@street);";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("zipcode", club.ZipCode));
            parameters.Add(new KeyValuePair<string, string>("number", club.Number.ToString()));
            parameters.Add(new KeyValuePair<string, string>("addition", club.Addition));
            parameters.Add(new KeyValuePair<string, string>("street", club.Street));

            DataSet result = ExecuteQuery(sql, parameters);
        }

        public void DeleteClub(int id)
        {
            string sql = "DELETE FROM club where ID=@ID;";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("ID", id.ToString()));
            ExecuteQuery(sql, parameters);
        }

        public void UpdateClub(ClubModel club)
        {
            string sql = "UPDATE club SET ID=@ID, name=@name, adresId =@adresId, email=@email, password=@password; UPDATE [lid-dienst-combo] SET ID=@ID";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("ID", club.ID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("name", club.Name.ToString()));
            parameters.Add(new KeyValuePair<string, string>("adresID", club.AID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("email", club.Email.ToString()));
            parameters.Add(new KeyValuePair<string, string>("password", club.Postcode.ToString()));
            ExecuteQuery(sql, parameters);
        }
        public bool Inloggen(ClubModel club)
        {
            bool check = false;
            string mysql = "Select * from club where clubnumber=@clubnumber and password=@password";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("clubnumber", club.ClubNumber));
            parameters.Add(new KeyValuePair<string, string>("password", club.Postcode));
            DataSet results = ExecuteQuery(mysql, parameters);
            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                check = true;
            }
            return check;
        }
        public bool CheckValidate(ClubModel club)
        {
            bool check = false;
            string mysql = "Select * from club where name=@name";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("name", club.Name));
            DataSet results = ExecuteQuery(mysql, parameters);
            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                check = true;
            }
            return check;
        }

    }
}
