using Barboek.ClassLib.DAL.Contexts;
using Barboek.ClassLib.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace BarBoekForms
{
    public partial class RoosterGenereren : Form
    {
        List<ShiftDTO> Shifts = new List<ShiftDTO> { };
        ShiftMySQLContext ShiftSQL;
        MemberMySQLContext MemberSQL;
        ScheduleDTO schedules;

        string connectionString = "Server=84.31.134.4;Database=barboekmain;User Id=newuser;Password=test;";
        private bool ConnectToDatabase() 
        {
            try
            {
                ShiftSQL = new ShiftMySQLContext(connectionString);
                MemberSQL = new MemberMySQLContext(connectionString);
            }
            catch(SqlException x)
            {
                MessageBox.Show(x.ToString());
                return false;
            }
            return true;
        }

        List<ShiftDTO> shifts; //= new List<ShiftDTO> { };
        List<MemberDTO> members; //= new List<MemberDTO> { };
        private bool noemmaarwatwil()
        {
            try
            {
                if (ConnectToDatabase())
                {
                    shifts = ShiftSQL.GetAllShift();
                    members = MemberSQL.GetAllMembers();
                }
                return true;
            }
            catch(SqlException x)
            {
                MessageBox.Show(x.ToString());
                return false;
            }
        }

        private readonly DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
        private readonly DataGridViewButtonColumn btndelete = new DataGridViewButtonColumn();
        

   
       
        private Schedule schedule = new Schedule();

        private DateTime test = new DateTime(2020, 1, 30, 00, 00, 00); //lidmaatschap maanden
        private DateTime test1 = new DateTime(2020, 4, 30, 00, 00, 00);
        private List<DateTime> subscription = new List<DateTime>();
        public RoosterGenereren()
        {
            InitializeComponent();
            constructDataGridView();

            
            noemmaarwatwil();
            
            subscription.Add(test);
            subscription.Add(test1);
           
          foreach (var months in subscription)
            {
                ComboDate.Items.Add((Month)months.Month);
            }
          
            List<User> users = new List<User>();

            foreach (ShiftDTO shift in shifts) //use shifts from database
            {
                schedules.Shifts.Add(shift);
            }
            foreach (var member in members) //use members from database
            {
                users.Add(new User(member.Name));
            }

            // Schedule the schedule 
            //schedules.(users);
            
           



            // Add user list

            /*
            // Add users to the list
            for (int i = 0; i < 10; i++)
            {
                users.Add(new User($"User{i + 1}"));
            }

            
            // Create schedule


            // Add shifts to the schedule
            schedule.AddShift(new Shift(new DateTime(2020, 1, 20, 22, 00, 00), new DateTime(2020, 1, 20, 01, 59, 00)));
            schedule.AddShift(new Shift(new DateTime(2020, 1, 20, 22, 00, 00), new DateTime(2020, 1, 20, 02, 59, 00)));
            schedule.AddShift(new Shift(new DateTime(2020, 1, 20, 22, 00, 00), new DateTime(2020, 1, 20, 23, 59, 00)));

            schedule.AddShift(new Shift(new DateTime(2020, 1, 26, 22, 00, 00), new DateTime(2020, 1, 26, 03, 59, 00)));
            schedule.AddShift(new Shift(new DateTime(2020, 1, 26, 22, 00, 00), new DateTime(2020, 1, 26, 04, 59, 00)));
            schedule.AddShift(new Shift(new DateTime(2020, 1, 26, 22, 00, 00), new DateTime(2020, 1, 26, 05, 59, 00)));
            schedule.AddShift(new Shift(new DateTime(2020, 1, 26, 22, 00, 00), new DateTime(2020, 1, 26, 06, 59, 00)));

            schedule.AddShift(new Shift(new DateTime(2020, 4, 10, 22, 00, 00), new DateTime(2020, 4, 10, 23, 59, 00)));
            schedule.AddShift(new Shift(new DateTime(2020, 4, 10, 22, 00, 00), new DateTime(2020, 4, 10, 23, 59, 00)));
            schedule.AddShift(new Shift(new DateTime(2020, 4, 10, 22, 00, 00), new DateTime(2020, 4, 10, 23, 59, 00)));
            schedule.AddShift(new Shift(new DateTime(2020, 4, 10, 22, 00, 00), new DateTime(2020, 4, 10, 23, 59, 00)));

           */

            // Print the schedule
            /*
            string sSchedule = "";
            foreach (Shift shift in schedule.Shifts)
            {
                sSchedule += shift + "\n";
            }

            MessageBox.Show(sSchedule);
            */



        }


        enum Month
            {
                Januari = 1,
                Februari = 2,
                Maart = 3,
                April = 4,
                Mei = 5,
                Juni = 6,
                Juli = 7,
                Augustus = 8,
                September = 9,
                Oktober = 10,
                November = 11,
                December = 12
            }
            
        


        private void constructDataGridView() //constructs the datagridview
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Evenement";
            dataGridView1.Columns[1].Name = "Datum";
            dataGridView1.Columns[2].Name = "Begin Tijd";
            dataGridView1.Columns[3].Name = "Eind Tijd";
            dataGridView1.Columns[4].Name = "Lid";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AddbuttonColumn();
            dataGridView1.Columns.Add(btnedit);
            dataGridView1.Columns.Add(btndelete);  
        }
        private void AddbuttonColumn() //adds edit and delete buttons
        {
            btnedit.HeaderText = @"Bewerken";
            btnedit.Name = "buttonbewerk";
            btnedit.Text = "Bewerk";
            btnedit.UseColumnTextForButtonValue = true;

            btndelete.HeaderText = @"Verwijderen";
            btndelete.Name = "buttonverwijder";
            btndelete.Text = "Verwijder";
            btndelete.UseColumnTextForButtonValue = true;
        }

        private void butgenereren_Click(object sender, EventArgs e)
        {
           if (ComboDate.Text == "")
            {
                MessageBox.Show("Selecteer eerst een maand");
            }
            else
            {
                dataGridView1.Rows.Clear();
                AddRows();
            }
        }
        private void AddRows()
        {

            int monthcheck = 0;
            
            for (int i = 0; i < 13; i++)
            { 
               if (ComboDate.Text == Convert.ToString((Month)i))
                {
                    monthcheck = i;
                    break;
                }
            }
            
            //test variables
            string testevenement = "test";
            
            foreach (ShiftDTO shift in schedules.Shifts) //puts the data in the datagrid
            {
                if (shift.DateStart.Month == monthcheck) //checks the selected month
                {
                    dataGridView1.Rows.Add(testevenement, shift.DateStart.Date, shift.DateStart.TimeOfDay, shift.DateEnd.TimeOfDay);//, shift.User);
                }
                
            }
            
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //here comes the code that runs after you press a datagrid button
        {
            Shift[] shifts = schedule.Shifts.ToArray();
            if (e.ColumnIndex == 5 && e.RowIndex < shifts.Length)
            {
                try //edit button
                {
                    //if this button is pressed the user should be able to edit the shift associated with the button, this can be done with an extra screen/form
                    MessageBox.Show(this, "Hello" + ", how are you", "Shift", MessageBoxButtons.YesNo);
                   
                    //schedule.Shifts[someindex].someproperty = somevalue;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    
                }
            }
            if (e.ColumnIndex == 6 && e.RowIndex < shifts.Length)
            {
                try //Delete button
                {
                    MessageBox.Show(this, "Delete", "Shift", MessageBoxButtons.OKCancel);

                }
                catch(Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
