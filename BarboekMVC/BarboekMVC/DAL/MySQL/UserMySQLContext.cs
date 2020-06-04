using BarboekMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using BarboekMVC.Interface;

namespace BarboekMVC.DAL.MySQL
{
    public class UserMySQLContext:BaseMYSQLContext,iUserSaveContext,iUserRetrieveContext
    {
        public UserMySQLContext(string connString) : base(connString)
        {

        }
        public List<UserModel> GetAllUsers()
        {
            string query = "Select * from user ";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            DataSet results = ExecuteQuery(query, parameters);

            List<UserModel> users = new List<UserModel>();

            if (results != null)
            {

                for (int x = 0; x < results.Tables[0].Rows.Count; x++)
                {
                    UserModel user = DataSetParser.DataSetToUser(results, x);
                    users.Add(user);
                }
            }
            return users;
        }
        public void InsertUser(UserModel user)
        {
            string sql = " INSERT INTO user(email, password) VALUES(@email,@password);";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("email", user.UEmail));
            parameters.Add(new KeyValuePair<string, string>("password", user.Password));
            DataSet result = ExecuteQuery(sql, parameters);
        }
        public bool Inloggen(UserModel user)
        {
            bool check = false;
            string mysql = "Select * from user where email=@email and password=@password";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("email",user.UEmail));
            parameters.Add(new KeyValuePair<string, string>("password", user.Password));
            DataSet results = ExecuteQuery(mysql, parameters);
            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                check = true;
            }
            return check;
        }
        public bool CheckValidate(UserModel user)
        {
            bool check = false;
            string mysql = "Select * from user where email=@email";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("email", user.UEmail));
            DataSet results = ExecuteQuery(mysql, parameters);
            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                check = true;
            }
            return check;
        }
    }
}
