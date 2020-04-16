using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barboek
{
    public partial class DienstToevoegen : Form
    {
        private Database ConOne;
        private Shift CurrentShift;
        public DienstToevoegen()
        {
            ConOne = new Database();
            InitializeComponent();
            EventSelectBox.DataSource = ConOne.GetEvents();
            CurrentShift = new Shift();
        }
        private void OnceCheckRadio_CheckedChanged(object sender, EventArgs e)
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
        private void PeriodicallyCheckRadio_CheckedChanged(object sender, EventArgs e)
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
        private void EventCheckRadio_CheckedChanged(object sender, EventArgs e)
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
            CurrentShift.UserAmount = Convert.ToInt32(UserAmountSelect.Value);
        }
        private void BeginDateSelect_ValueChanged(object sender, EventArgs e)
        {
            CurrentShift.BeginDate = BeginDateSelect.Value;
        }
        private void EndDateSelect_ValueChanged(object sender, EventArgs e)
        {
            CurrentShift.EndDate = EndDateSelect.Value;
        }
        private void BeginTimeSelect_ValueChanged(object sender, EventArgs e)
        {
            CurrentShift.BeginTime = BeginTimeSelect.Value;
        }
        private void EndTimeSelect_ValueChanged(object sender, EventArgs e)
        {
            CurrentShift.EndTime = EndTimeSelect.Value;
        }
        private void ToevoegenButton_Click(object sender, EventArgs e)
        {
            if (OnceCheckRadio.Checked)
            {
                if (OnceCheckFields())
                {
                    ConOne.SendNewShiftOnce(CurrentShift);
                    CurrentShift = new Shift();
                }
            }
            else if (PeriodicallyCheckRadio.Checked)
            {
                if (PeriodicallyCheckFields())
                {
                    ConOne.SendNewShiftPeriodically();
                    CurrentShift = new Shift();
                }
            }
            else if (EventCheckRadio.Checked)
            {
                if (EventCheckFields())
                {
                    ConOne.SendNewShiftEvent();
                    CurrentShift = new Shift();
                }
            }
            else
            {
                MessageBox.Show("Fatal error 1: Unreachable code reached");
            }
        }
        private bool OnceCheckFields()
        {
            if(BeginTimeSelect.Value != null && EndTimeSelect.Value != null && BeginDateSelect.Value != null) //WIP
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool PeriodicallyCheckFields()
        {
            if (BeginTimeSelect.Value != null && EndTimeSelect.Value != null && BeginDateSelect.Value != null && EndDateSelect.Value != null && EndDateSelect.Value > BeginDateSelect.Value) //WIP
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool EventCheckFields()
        {
            if (BeginTimeSelect.Value != null && EndTimeSelect.Value != null && BeginDateSelect.Value != null) //WIP
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
