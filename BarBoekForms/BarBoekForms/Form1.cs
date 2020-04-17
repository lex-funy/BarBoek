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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Add user list
            List<User> users = new List<User>();

            // Add users to the list
            for (int i = 0; i < 10; i++)
            {
                users.Add(new User($"User{i + 1}"));
            }

            // Create schedule
            Schedule schedule = new Schedule();

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
            string sSchedule = "";
            foreach (Shift shift in schedule.Shifts)
            {
                sSchedule += shift + "\n";
            }

            MessageBox.Show(sSchedule);
        }

        private void butroostergenereer_Click(object sender, EventArgs e)
        {
            this.Hide();
            var roostergenereren = new RoosterGenereren();
            roostergenereren.Show();
        }
    }
}
