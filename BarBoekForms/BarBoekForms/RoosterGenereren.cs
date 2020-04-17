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

        public static DateTime date1 = new DateTime(2020, 4, 12, 18, 00, 00);// 18:00:00);
        public static DateTime date2 = new DateTime(2020, 4, 12, 20, 00, 00);
        private Shift shift = new Shift(date1, date2);
        private Schedule schedule = new Schedule();
        public RoosterGenereren()
        {
            InitializeComponent();
            constructDataGridView();

            schedule.AddShift(shift);
        }
        private void constructDataGridView()
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
        private void AddbuttonColumn()
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
            //constructDataGridView();
            dataGridView1.Rows.Clear();
            AddRows();
        }
        private void AddRows()
        {
            
            //test variables
            string testevenement = "test";
            
            foreach (var shift in schedule.Shifts)
            {
                dataGridView1.Rows.Add(testevenement, shift.Start.Date, shift.Start.TimeOfDay, shift.End.TimeOfDay, shift.User);
                
            }
            
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
