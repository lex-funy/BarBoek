using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

namespace BarboekMVC.DAL
{
    public class BaseMYSQLContext
    {
        private string connectionString;
        public BaseMYSQLContext(string connString)
        {
            connectionString = connString;
        }

        public DataSet ExecuteQuery(string query, List<KeyValuePair<string, string>> parameters)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = conn.CreateCommand();
                foreach (KeyValuePair<string, string> kvp in parameters)
                {
                    MySqlParameter para = new MySqlParameter();
                    para.ParameterName = "@" + kvp.Key;
                    para.Value = kvp.Value;
                    cmd.Parameters.Add(para);
                }
                cmd.CommandText = query;
                da.SelectCommand = cmd;

                conn.Open();
                da.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            return ds;
        }
    }
}
