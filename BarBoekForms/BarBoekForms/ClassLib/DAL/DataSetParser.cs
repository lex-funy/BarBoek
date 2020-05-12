﻿using Barboek.ClassLib.DAL.Contexts;
using Barboek.ClassLib.DAL.Model;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Barboek.ClassLib.DAL
{
    class DataSetParser
    {
        public static AddressDTO DataSetToAddress(DataSet set, int rowIndex)
        {
            return new AddressDTO()
            {
                ID = (int)set.Tables[0].Rows[rowIndex][0],
                ZipCode = set.Tables[0].Rows[rowIndex][1].ToString(),
                Number = (int)set.Tables[0].Rows[rowIndex][2],
                Addition = set.Tables[0].Rows[rowIndex][3].ToString()
            };
        }

        public static ClubDTO DataSetToClub(DataSet set, int rowIndex)
        {
            AddressMySQLContext a;
            string connectionString = "Server=192.168.15.51;Database=dbi428513;User Id=dbi428513;Password=Udkingtrug4!;";
            a = new AddressMySQLContext(connectionString); //Zorgt ervoor dat er een daadwerkelijk adres wordt opgeslagen in ClubDTO
            return new ClubDTO()
            {
                ID = (int)set.Tables[0].Rows[rowIndex][0],
                Name = set.Tables[0].Rows[rowIndex][1].ToString(),
                Address = (AddressDTO) a.FindAddressById((int)set.Tables[0].Rows[rowIndex][2]),
                ClubNumber = set.Tables[0].Rows[rowIndex][3].ToString(),
                Email = set.Tables[0].Rows[rowIndex][4].ToString()


            };
        }

        public static MemberDTO DataSetToMember(DataSet set, int rowIndex)
        {
            AddressMySQLContext a;
            string connectionString = "Server=192.168.15.51;Database=dbi428513;User Id=dbi428513;Password=Udkingtrug4!;";
            a = new AddressMySQLContext(connectionString); //Zorgt ervoor dat er een daadwerkelijk adres wordt opgeslagen in MemberDTO
            return new MemberDTO()
            {
                ID = (int)set.Tables[0].Rows[rowIndex][0],
                Name = set.Tables[0].Rows[rowIndex][1].ToString(),
                Address =(AddressDTO) a.FindAddressById((int)set.Tables[0].Rows[rowIndex][2])
            };
        }

        public static PaymentDTO DataSetToPayment(DataSet set, int rowIndex)
        {
            return new PaymentDTO()
            {
                ID = (int)set.Tables[0].Rows[rowIndex][0],
                Succesful = (bool) set.Tables[0].Rows[rowIndex][1]
            };
        }

        public static ScheduleDTO DataSetToSchedule(DataSet set, int rowIndex)
        {
            return new ScheduleDTO()
            {
                Name = set.Tables[0].Rows[rowIndex][0].ToString()
            };
        }

        public static ShiftDTO DataSetToShift(DataSet set, int rowIndex)
        {
            return new ShiftDTO()
            {
                ID = (int)set.Tables[0].Rows[rowIndex][0],
                DateStart = (DateTime)set.Tables[0].Rows[rowIndex][1],
                DateEnd = (DateTime)set.Tables[0].Rows[rowIndex][2],
                MaxMemberCount = (int)set.Tables[0].Rows[rowIndex][3]
            };
        }

    }
}
