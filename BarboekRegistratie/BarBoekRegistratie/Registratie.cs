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
    public partial class Registratie : Form
    {
        public Registratie()
        {
            InitializeComponent();
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public bool ClubType()
        {
            if(rbDemo.Checked | rbJaar.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnRegistreren_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            Club a = new Club();
            a.Name = txtVnaam.Text;
            a.Contactperson = txtContactpersoon.Text;
            a.Street = txtStraat.Text;
            a.Postcode = txtPostcode.Text;
            a.Location = txtPlaats.Text;
            a.Email = txtEmail.Text;
            if (rbDemo.Checked)
            {
                a.Type = "Demo";
            }
            else
            {
                a.Type = "Jaarabonnement";
            }
            a.Comment = txtOpmerking.Text;
            Boolean c = db.checkUsername(a);
            Boolean d = ClubType();
            bool em = IsValidEmail(txtEmail.Text);
            db.openConnection();
            if (txtVnaam.Text != "" && txtContactpersoon.Text != "" && txtStraat.Text != "" && txtPostcode.Text != "" && txtPlaats.Text != ""&& d)
            {
                if (c)
                {
                    MessageBox.Show("Deze verenigingsnaam bestaat al, selecteer een andere.", "Dubbele gebruikersnaam", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (em)
                    {
                        db.SignUp(a);
                        MessageBox.Show("Uw account is aangemaakt", "Account aangemaakt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (txtEmail.Text == "")
                        {
                            MessageBox.Show("U moet de email invoegen.");
                        }
                        else
                        {
                            MessageBox.Show("Verkeerde email.");
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("U moet de gevraagde gegevens invullen!", "Lege data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            db.closeConnection();
        }


        private void linkTerug_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }
    }
}
