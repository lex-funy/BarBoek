﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace BarBoekRegistratie
{
    public abstract class DB
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
    }
}
