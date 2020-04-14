using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBoekRegistratie
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnRegistratie_Click(object sender, EventArgs e)
        {
            Registratie a = new Registratie();
            this.Hide();
            a.Show();
        }
    }
}
