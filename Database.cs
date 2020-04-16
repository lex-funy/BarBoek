using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barboek
{
    public class Database
    {
        private MySqlConnection con = new MySqlConnection("server=84.31.134.4,port=3306;database=testvereniging;username=newuser;password=test;");
        public List<string> GetEvents()
        {
            con.Open();
            List<string> events = new List<string>();
            string currentEvent;
            MySqlCommand receiver = new MySqlCommand("SELECT * FROM events", con);
            MySqlDataReader reader = receiver.ExecuteReader();
            if(reader.Read())
            {
                while(reader.Read())
                {
                    currentEvent = reader["Name"].ToString();
                    MessageBox.Show(currentEvent);
                    events.Add(currentEvent);
                    //add line for description if necessary
                }
            }
            else
            {
                MessageBox.Show("Er zijn geen evenementen om uit te kiezen!");
            }
            con.Close();
            return events;
        }
        public void SendNewShiftOnce(Shift ShiftToSend)
        {
            DateTime BeginToSend = CombineBeginDatetime(ShiftToSend);
            DateTime EndToSend = CombineEndDatetime(ShiftToSend);
            con.Open();
            //string mySQLBeginTimeFormat =  ShiftToSend.BeginTime.ToString("yyyy-MM-dd HH:mm:ss");
            string command = "INSERT INTO Diensten (StartDatetime,EndDatetime,VolunteersNeeded) VALUES('"+BeginToSend+"','"+EndToSend+"','"+ShiftToSend.UserAmount+"')";
            MySqlCommand Sender = new MySqlCommand(command, con);
            Sender.ExecuteNonQuery();
            con.Close();
        }
        public void SendNewShiftPeriodically()
        {
            con.Open();

            con.Close();
        }
        public void SendNewShiftEvent()
        {
            con.Open();

            con.Close();
        }
        public DateTime CombineBeginDatetime(Shift ToParse)
        {
            DateTime CombinedBeginDatetime;
            string Time = ToParse.BeginTime.ToString("HH:mm:ss");
            MessageBox.Show(Time);
            string Date = ToParse.BeginDate.ToString("MM/dd/yyyy");
            MessageBox.Show(Date);
            MessageBox.Show(Date+" "+Time);
            CombinedBeginDatetime = Convert.ToDateTime(Date+" "+Time);
            return CombinedBeginDatetime;
        }
        public DateTime CombineEndDatetime(Shift ToParse)
        {
            DateTime CombinedEndDatetime;
            string Time = ToParse.EndTime.ToString("HH:mm:ss");
            string Date = ToParse.BeginDate.ToString("MM/dd/yyyy");
            CombinedEndDatetime = Convert.ToDateTime(Date+" "+Time);
            return CombinedEndDatetime; ;
        }
    }
}
