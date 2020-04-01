using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DienstToevoegen
{
    public partial class DienstToevoegen : Form
    {
        private Database ConOne;
        private Shift CurrentShift;
        public DienstToevoegen()
        {
            ConOne = new Database();
            //EventSelectBox.DataSource = ConOne.GetEvents();
            InitializeComponent();
            CurrentShift = new Shift();

            List<User> users = new List<User>();

            for (int i = 0; i < 10; i++)
            {
                users.Add(new User($"User{i + 1}"));
            }
            Schedule schedule = new Schedule();

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

            schedule.PlanShifts(users);

            string sSchedule = "";
            foreach (Shift shift in schedule.Shifts)
            {
                sSchedule += shift + "\n";
            }

            MessageBox.Show(sSchedule);

        }
        private void OnceCheckButton_CheckedChanged(object sender, EventArgs e)
        {
            OnceSelected();
        }
        public void OnceSelected()
        {
            BeginDateSelect.Enabled = true;
            BeginTimeSelect.Enabled = true;
            EndTimeSelect.Enabled = true;
            UserAmountSelect.Enabled = true;

            EventSelectBox.Enabled = false;
            EndDateSelect.Enabled = false;
            DaysListSelect.Enabled = false;
        }
        private void PeriodicityButton_CheckedChanged(object sender, EventArgs e)
        {
            PeriodicallySelected();
        }
        private void PeriodicallySelected()
        {
            BeginDateSelect.Enabled = true;
            EndDateSelect.Enabled = true;
            BeginTimeSelect.Enabled = true;
            EndTimeSelect.Enabled = true;
            DaysListSelect.Enabled = true;
            UserAmountSelect.Enabled = true;

            EventSelectBox.Enabled = false;
        }
        private void EventButton_CheckedChanged(object sender, EventArgs e)
        {
            EventSelected();
        }
        private void EventSelected()
        {
            BeginDateSelect.Enabled = true;
            EndDateSelect.Enabled = true;
            BeginTimeSelect.Enabled = true;
            EndTimeSelect.Enabled = true;
            DaysListSelect.Enabled = true;
            UserAmountSelect.Enabled = true;
            EventSelectBox.Enabled = true;
        }
        private void EventSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentShift.Event = Convert.ToString(EventSelectBox.SelectedItem);
        }
        private void UserAmountSelect_ValueChanged(object sender, EventArgs e)
        {

        }
        private void BeginDateSelect_ValueChanged(object sender, EventArgs e)
        {

        }
        private void EndDateSelect_ValueChanged(object sender, EventArgs e)
        {

        }
        private void BeginTimeSelect_ValueChanged(object sender, EventArgs e)
        {

        }
        private void EndTimeSelect_ValueChanged(object sender, EventArgs e)
        {

        }
        private void DaysListSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ToevoegenButton_Click(object sender, EventArgs e)
        {
            if(CheckFields())
            ConOne.SendNewShift();
            CurrentShift = new Shift();
        }
        private bool CheckFields()
        {
            if(BeginTimeSelect.Value != null) //WIP
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
