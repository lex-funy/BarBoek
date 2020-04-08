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
        public RoosterGenereren()
        {
            InitializeComponent();
            constructDataGridView();
            
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
            constructDataGridView();
        }
        private void AddRows()
        {
            foreach (var shift in)
            {

            }
        }
    }
}
