using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DienstToevoegen
{
    public class Database
    {
        private MySqlConnection con = new MySqlConnection("server=84.31.134.4:3306;database=;username=newuser;password=test;");
        public List<string> GetEvents()
        {
            con.Open();
            List<string> events = new List<string>();
            string currentEvent;
            MySqlCommand receiver = new MySqlCommand("SELECT * FROM EVENTS", con);
            MySqlDataReader reader = receiver.ExecuteReader();
            if(reader.Read())
            {
                while(reader.Read())
                {
                    currentEvent = reader["Name"].ToString();
                    events.Add(currentEvent);
                }
            }
            else
            {
                MessageBox.Show("Er zijn geen evenementen om uit te kiezen!");
            }
            con.Close();
            return events;
        }
        public void SendNewShift()
        {
            con.Open();

            con.Close();
        }
    }
}
