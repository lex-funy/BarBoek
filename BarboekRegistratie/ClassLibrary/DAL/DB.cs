using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace ClassLibrary.DAL
{
    public abstract class DB
    {
        public string ConnectionString { get; set; }

        public DB(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        public DataSet ExecuteSql(string mysql, List<KeyValuePair<string, string>> parameters)
        {
            DataSet dataSet = new DataSet();
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString);
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = conn.CreateCommand();

                foreach (KeyValuePair<string, string> kvp in parameters)
                {
                    MySqlParameter param = new MySqlParameter();
                    param.ParameterName = "@" + kvp.Key;
                    param.Value = kvp.Value;
                    cmd.Parameters.Add(param);
                }

                cmd.CommandText = mysql;
                da.SelectCommand = cmd;

                conn.Open();
                da.Fill(dataSet);
                conn.Close();
            }
            catch (Exception ex)
            {
                return null;
            }

            return dataSet;
        }
    }
}
