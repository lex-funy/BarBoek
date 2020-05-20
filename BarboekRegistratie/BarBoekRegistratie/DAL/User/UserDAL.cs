using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using BarBoekRegistratie.DAL.User;

namespace BarBoekRegistratie
{
    class UserDAL:DB,IUserDAL,IUserContainer
    {
        public void Insert(UserDTO userDTO)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`( `email`, `password`) VALUES(@email, @pass)", getConnection());
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userDTO.Email;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = userDTO.Password;
            command.ExecuteNonQuery();
            closeConnection();
        }
        public void Update(UserDTO userDTO)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE user SET password=@password,email=@email WHERE email =@email", getConnection());
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = userDTO.Email;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = userDTO.Password;
            command.ExecuteNonQuery();
            closeConnection();
        }
        public List<UserDTO> GetAll()
        {
            openConnection();
            List<UserDTO> userlist = new List<UserDTO>();
            MySqlCommand command = new MySqlCommand("SELECT* FROM user ORDER BY userId ", getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                UserDTO users = new UserDTO();
                users.UserId = reader.GetInt32("userId");             
                users.Email = reader.GetString("username");
                users.Password = reader.GetString("password");

                userlist.Add(users);
            }

            closeConnection();
            return userlist;
        }

        public UserDTO Findbyemail(string email)
        {
            openConnection();
            UserDTO userDTO = new UserDTO();
            MySqlDataReader mdr;
            MySqlCommand command = new MySqlCommand("SELECT* FROM user Where email = @email", getConnection());
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            MySqlDataAdapter dar = new MySqlDataAdapter(command);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                userDTO.UserId = mdr.GetInt32("userId");
                userDTO.Email = mdr.GetString("email");
                userDTO.Password = mdr.GetString("password");
            }
            closeConnection();
            return userDTO;
        }
        public void Delete(UserDTO userDTO)
        {
            openConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM user WHERE email = @email", getConnection());
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userDTO.Email;
            command.ExecuteNonQuery();
            closeConnection();
        }
        public bool Inloggen(UserDTO userDTO)
        {
            bool check = false;
            openConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `email` = @email and `password` = @password", getConnection());
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userDTO.Email;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = userDTO.Password;
            sda.SelectCommand = command;
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                check = true;
            }
            closeConnection();
            return check;
        }
        public List<UserDTO> Search(string email)
        {
            openConnection();
            List<UserDTO> userlist = new List<UserDTO>();
            MySqlDataReader mdr;
            MySqlCommand command = new MySqlCommand("SELECT* FROM user Where email = @email", getConnection());
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            MySqlDataAdapter dar = new MySqlDataAdapter(command);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                UserDTO userDTO = new UserDTO();
                userDTO.UserId = mdr.GetInt32("userId");
                userDTO.Email = mdr.GetString("email");
                userDTO.Password = mdr.GetString("password");
                userlist.Add(userDTO);
            }
            closeConnection();
            return userlist;
        }
        public Boolean Check(UserDTO userDTO)
        {
            openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `email` = @email", getConnection());
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userDTO.Email;
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
