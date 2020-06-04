using BarboekMVC.Interface;
using BarboekMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace BarboekMVC.DAL.MYSQL
{
    public class AddressMySQLContext:BaseMYSQLContext,iAddressRetrieveContext,iAddressSaveContext
    {
        public AddressMySQLContext(string connString) : base(connString)
        {

        }

        public List<AddressModel> GetAllAddresses()
        {
            string query = "Select * from adres ";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            DataSet results = ExecuteQuery(query, parameters);

            List<AddressModel> addresses = new List<AddressModel>();

            if (results != null)
            {

                for (int x = 0; x < results.Tables[0].Rows.Count; x++)
                {
                    AddressModel a = DataSetParser.DataSetToAddress(results, x);
                    addresses.Add(a);
                }
            }
            return addresses;
        }

        public AddressModel FindAddressById(int id)
        {
            string query = "Select * from adres where ID=@ID";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("ID", id.ToString()));

            DataSet results = ExecuteQuery(query, parameters);
            AddressModel a = new ClubModel();

            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                a = DataSetParser.DataSetToAddress(results, 0);
            }
            return a;
        }
        public AddressModel FindAddressByCode(string address)
        {
            string query = "Select * from adres where zipcode=@zipcode";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("zipcode", address));
            DataSet results = ExecuteQuery(query, parameters);
            AddressModel a = new ClubModel();

            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                a = DataSetParser.DataSetToAddress(results, 0);
            }
            return a;
        }
        public void InsertAddress(AddressModel address)
        {
            string sql = "INSERT INTO adres (zipcode,number,addition) VALUES(@zipcode,@number,@addition);";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("zipcode", address.ZipCode.ToString()));
            parameters.Add(new KeyValuePair<string, string>("number", address.Number.ToString()));
            parameters.Add(new KeyValuePair<string, string>("addition", address.Addition.ToString()));
            DataSet result = ExecuteQuery(sql, parameters);
        }

        public void DeleteAddress(int id)
        {
            string sql = "DELETE FROM adres where ID=@ID;";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("ID", id.ToString()));
            ExecuteQuery(sql, parameters);
        }

        public void UpdateAddress(AddressModel addr)
        {
            string sql = "UPDATE adres SET ID=@ID, zipcode=@zipcode, number=@number, addition=@addition";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("ID", addr.AID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("zipcode", addr.ZipCode.ToString()));
            parameters.Add(new KeyValuePair<string, string>("number", addr.Number.ToString()));
            parameters.Add(new KeyValuePair<string, string>("addition", addr.Addition.ToString()));
            ExecuteQuery(sql, parameters);
        }
    }
}
