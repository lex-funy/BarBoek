using BarBoekRegistratie.BLL;
using BarBoekRegistratie.DAL.User;
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
    public partial class Emailconfirm : Form
    {
        public Emailconfirm()
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
        public bool HerhaalPassword()
        {
            if(txtPassword.Text == txtHpassword.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            IUserDAL userDAL = new UserDAL();
            UserDTO userDTO = new UserDTO();
            userDTO.Email = txtEmail.Text;
            userDTO.Password = txtPassword.Text;
            bool email = IsValidEmail(txtEmail.Text);
            Boolean check = userDAL.Check(userDTO);
            if (txtEmail.Text != "" | txtPassword.Text != "" | txtHpassword.Text != "")
            {
                if (txtPassword.Text.Equals(txtHpassword.Text))
                {
                    if (check)
                    {
                        MessageBox.Show("Deze gebruikersnaam bestaat al, selecteer een andere.", "Dubbele gebruikersnaam", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (email)
                        {
                            userDAL.Insert(userDTO);
                            MessageBox.Show("Uw account is aangemaakt", "Account aangemaakt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Foute email");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Verkeerd bevestigingswachtwoord", "Verkeerd password", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("U moet gevraagde gegevens invullen!", "Lege data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void LLBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
