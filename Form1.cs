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
            EventSelectBox.DataSource = ConOne.GetEvents();
            InitializeComponent();
            CurrentShift = new Shift();
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
