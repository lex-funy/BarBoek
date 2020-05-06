using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace BarBoekForms
{
    public partial class RoosterGenereren : Form
    {
        private readonly DataGridViewButtonColumn btnbewerk = new DataGridViewButtonColumn();
        private readonly DataGridViewButtonColumn btnverwijder = new DataGridViewButtonColumn();
        private Club club; //= new Club();
        private Shift Shift;

   
        private Shift shifttest = new Shift(new DateTime(2020, 4, 12, 18, 00, 00), new DateTime(2020, 4, 12, 20, 00, 00));
        private Schedule schedule = new Schedule();

        private DateTime test = new DateTime(2020, 4, 30, 00, 00, 00); //lidmaatschap maanden
        public RoosterGenereren()
        {
            InitializeComponent();
            constructDataGridView();

            
            
           
           
            ComboDate.Items.Add(test.Month);
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
            dataGridView1.Columns.Add(btnbewerk);
            dataGridView1.Columns.Add(btnverwijder);
           
        }
        private void AddbuttonColumn() //adds edit and delete buttons
        {
            btnbewerk.HeaderText = @"Bewerken";
            btnbewerk.Name = "buttonbewerk";
            btnbewerk.Text = "Bewerk";
            btnbewerk.UseColumnTextForButtonValue = true;

            btnverwijder.HeaderText = @"Verwijderen";
            btnverwijder.Name = "buttonverwijder";
            btnverwijder.Text = "Verwijder";
            btnverwijder.UseColumnTextForButtonValue = true;
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
                // Add user list
                List<User> users = new List<User>();

                // Add users to the list
                for (int i = 0; i < 10; i++)
                {
                    users.Add(new User($"User{i + 1}"));
                }

                // Create schedule


                // Add shifts to the schedule
                schedule.AddShift(new Shift(new DateTime(2020, 1, 20, 22, 00, 00), new DateTime(2020, 1, 20, 23, 59, 00)));
                schedule.AddShift(new Shift(new DateTime(2020, 1, 20, 22, 00, 00), new DateTime(2020, 1, 20, 23, 59, 00)));
                schedule.AddShift(new Shift(new DateTime(2020, 1, 20, 22, 00, 00), new DateTime(2020, 1, 20, 23, 59, 00)));

                schedule.AddShift(new Shift(new DateTime(2020, 1, 26, 22, 00, 00), new DateTime(2020, 1, 26, 23, 59, 00)));
                schedule.AddShift(new Shift(new DateTime(2020, 1, 26, 22, 00, 00), new DateTime(2020, 1, 26, 23, 59, 00)));
                schedule.AddShift(new Shift(new DateTime(2020, 1, 26, 22, 00, 00), new DateTime(2020, 1, 26, 23, 59, 00)));
                schedule.AddShift(new Shift(new DateTime(2020, 1, 26, 22, 00, 00), new DateTime(2020, 1, 26, 23, 59, 00)));

                schedule.AddShift(new Shift(new DateTime(2020, 4, 10, 22, 00, 00), new DateTime(2020, 4, 10, 23, 59, 00)));
                schedule.AddShift(new Shift(new DateTime(2020, 4, 10, 22, 00, 00), new DateTime(2020, 4, 10, 23, 59, 00)));
                schedule.AddShift(new Shift(new DateTime(2020, 4, 10, 22, 00, 00), new DateTime(2020, 4, 10, 23, 59, 00)));
                schedule.AddShift(new Shift(new DateTime(2020, 4, 10, 22, 00, 00), new DateTime(2020, 4, 10, 23, 59, 00)));

                // Schedule the schedule 
                schedule.PlanShifts(users);

                // Print the schedule
                /*
                string sSchedule = "";
                foreach (Shift shift in schedule.Shifts)
                {
                    sSchedule += shift + "\n";
                }

                MessageBox.Show(sSchedule);
                */
                schedule.AddShift(shifttest);
                AddRows();
            }
        }
        private void AddRows()
        {
            
            //test variables
            string testevenement = "test";
            
            foreach (Shift shift in schedule.Shifts) //puts the data in the datagrid
            {
                if (shift.Start.Month == Convert.ToInt32(ComboDate.Text)) //checks the selected month
                {
                    dataGridView1.Rows.Add(testevenement, shift.Start.Date, shift.Start.TimeOfDay, shift.End.TimeOfDay, shift.User);
                }
                
            }
            
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //here comes the code that runs after you press a datagrid button
        {
            Shift[] shifts = schedule.Shifts.ToArray();
            if (e.ColumnIndex == 5 && e.RowIndex < shifts.Length)
            {
                try
                {

                    MessageBox.Show(this, "Hello" + ", how are you", "Student", MessageBoxButtons.OKCancel);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            if (e.ColumnIndex == 6 && e.RowIndex < shifts.Length)
            {
                try
                {
                    MessageBox.Show(this, "Verwijder", "Shift", MessageBoxButtons.OKCancel);
                }
                catch(Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
