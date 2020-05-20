using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using BarBoekRegistratie.DAL.Club;
using BarBoekRegistratie.DAL;

namespace BarBoekRegistratie.Classes
{
    class ClubDAL:DB,IClubDAL,IClubContainer
    {
        public void Insert(ClubDTO clubDTO)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO club(clubId,clubbondnr,clubname,contactperson,street,addition,postcode,plaats,email,type,comment) VALUES (@id,@bondnr,@name,@person,@street,@add,@postcode,@location,@email,@type,@comment)", getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = clubDTO.ClubId;
            command.Parameters.Add("@bondnr", MySqlDbType.Int32).Value = clubDTO.ClubBondnr;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = clubDTO.Name;
            command.Parameters.Add("@person", MySqlDbType.VarChar).Value = clubDTO.Contactperson;
            command.Parameters.Add("@street", MySqlDbType.VarChar).Value = clubDTO.Street;
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = clubDTO.Addition;
            command.Parameters.Add("@postcode", MySqlDbType.VarChar).Value = clubDTO.Postcode;
            command.Parameters.Add("@location", MySqlDbType.VarChar).Value = clubDTO.Location;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = clubDTO.Email;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = clubDTO.Type;
            command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = clubDTO.Comment;
            command.ExecuteNonQuery();
            closeConnection();
        }
        public void Update(ClubDTO clubDTO)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE club SET contactperson=@person,street=@street,addition=@add,postcode=@postcode,plaats=@location,email=@email,type=@type,comment=@com WHERE clubname =@cname", getConnection());
            command.Parameters.Add("@person", MySqlDbType.VarChar).Value = clubDTO.Contactperson;
            command.Parameters.Add("@street", MySqlDbType.VarChar).Value = clubDTO.Street;
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = clubDTO.Addition;
            command.Parameters.Add("@postcode", MySqlDbType.VarChar).Value = clubDTO.Postcode;
            command.Parameters.Add("@location", MySqlDbType.VarChar).Value = clubDTO.Location;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = clubDTO.Email;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = clubDTO.Type;
            command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = clubDTO.Comment;
            command.ExecuteNonQuery();
            closeConnection();
        }
        public List<ClubDTO> GetAll()
        {
            openConnection();
            List<ClubDTO> clublist = new List<ClubDTO>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `club` WHERE `clubname` = @name", getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ClubDTO clubDTO = new ClubDTO();
                clubDTO.ClubId = reader.GetInt32("clubId");
                clubDTO.ClubBondnr = reader.GetInt32("clubbondnr");
                clubDTO.Name = reader.GetString("clubname");
                clubDTO.Contactperson = reader.GetString("contactperson");
                clubDTO.Street = reader.GetString("street");
                clubDTO.Addition = reader.GetString("addition");
                clubDTO.Postcode = reader.GetString("addition");
                clubDTO.Location = reader.GetString("plaats");
                clubDTO.Email = reader.GetString("email");
                clubDTO.Type = reader.GetString("type");
                clubDTO.Comment = reader.GetString("comment");
                clublist.Add(clubDTO);
            }
            closeConnection();
            return clublist;
        }
        public ClubDTO Findby(string clubname)
        {
            openConnection();
            ClubDTO clubDTO = new ClubDTO();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `club` WHERE `clubname` = @name", getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = clubname;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                clubDTO.ClubId = reader.GetInt32("clubId");
                clubDTO.ClubBondnr = reader.GetInt32("clubbondnr");
                clubDTO.Name = reader.GetString("clubname");
                clubDTO.Contactperson = reader.GetString("contactperson");
                clubDTO.Street = reader.GetString("street");
                clubDTO.Addition = reader.GetString("addition");
                clubDTO.Postcode = reader.GetString("addition");
                clubDTO.Location = reader.GetString("plaats");
                clubDTO.Email = reader.GetString("email");
                clubDTO.Type = reader.GetString("type");
                clubDTO.Comment = reader.GetString("comment");
            }
            closeConnection();
            return clubDTO;
        }
        public void Delete(ClubDTO clubDTO)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM club WHERE clubname = @name", getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = clubDTO.Name;
            command.ExecuteNonQuery();
            closeConnection();
        }
        public bool Inloggen(ClubDTO clubDTO)
        {
            bool check = false;
            openConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `club` WHERE `clubbondnr` = @bnr and `postcode` = @post", getConnection());
            command.Parameters.Add("@bnr", MySqlDbType.Int32).Value = clubDTO.ClubBondnr;
            command.Parameters.Add("@post", MySqlDbType.VarChar).Value = clubDTO.Postcode;
            sda.SelectCommand = command;
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                check = true;
            }
            closeConnection();
            return check;
        }
        public List<ClubDTO> Search(string clubname)
        {
            openConnection();
            List<ClubDTO> clublist = new List<ClubDTO>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `club` WHERE `clubname` like '%" + clubname + "%'", getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ClubDTO clubDTO = new ClubDTO();
                clubDTO.ClubId = reader.GetInt32("clubId");
                clubDTO.ClubBondnr = reader.GetInt32("clubbondnr");
                clubDTO.Name = reader.GetString("clubname");
                clubDTO.Contactperson = reader.GetString("contactperson");
                clubDTO.Street = reader.GetString("street");
                clubDTO.Addition = reader.GetString("addition");
                clubDTO.Postcode = reader.GetString("addition");
                clubDTO.Location = reader.GetString("plaats");
                clubDTO.Email = reader.GetString("email");
                clubDTO.Type = reader.GetString("type");
                clubDTO.Comment = reader.GetString("comment");
                clublist.Add(clubDTO);
            }
            closeConnection();
            return clublist;
        }
        public Boolean Check(ClubDTO clubDTO)
        {
            openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `club` WHERE `clubname` = @name", getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value =clubDTO.Name ;
            adapter.SelectCommand = command;
            adapter.Fill(table);
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
