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
        }

        private void butroostergenereer_Click(object sender, EventArgs e)
        {
            this.Hide();
            var roostergenereren = new RoosterGenereren();
            roostergenereren.Show();
        }
    }
}
