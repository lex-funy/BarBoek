using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace BarBoekRegistratie
{
    public class DB
    {
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=Asdfg1234;database=barboek_test");
        public void openConnection()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return con;
        }

        public void SignUp(Club a)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO club(clubId,clubbondnr,clubname,contactperson,street,postcode,plaats,email,type,comment) VALUES (@id,@bondnr,@name,@person,@street,@postcode,@location,@email,@type,@comment)",getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = a.ClubId;
            command.Parameters.Add("@bondnr", MySqlDbType.Int32).Value = a.ClubBondnr;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = a.Name;
            command.Parameters.Add("@person", MySqlDbType.VarChar).Value = a.Contactperson;
            command.Parameters.Add("@street", MySqlDbType.VarChar).Value = a.Street;
            command.Parameters.Add("@postcode", MySqlDbType.VarChar).Value = a.Postcode;
            command.Parameters.Add("@location", MySqlDbType.VarChar).Value = a.Location;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = a.Email;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = a.Type;
            command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = a.Comment;
            command.ExecuteNonQuery();
            closeConnection();
        }
        public Boolean checkUsername(Club a)
        {
            openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `club` WHERE `clubname` = @name", getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = a.Name;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            openConnection();
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
