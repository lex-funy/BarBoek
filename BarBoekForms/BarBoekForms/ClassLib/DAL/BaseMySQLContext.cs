using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Barboek.ClassLib.DAL
{
    public abstract class BaseMySQLContext
    {
        private string connectionString;
        public BaseMySQLContext(string connString)
        {
            connectionString = connString;
        }

        public DataSet ExecuteQuery(string query, List<KeyValuePair<string,string>> parameters)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = conn.CreateCommand();
                foreach (KeyValuePair<string,string> kvp in parameters)
                {
                    SqlParameter para = new SqlParameter();
                    para.ParameterName = "@" + kvp.Key;
                    para.Value =  "@" + kvp.Value;
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

