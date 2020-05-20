using BarBoekRegistratie.Classes;
using BarBoekRegistratie.DAL.Club;
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

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            ClubDTO clubDTO = new ClubDTO();
            IClubDAL clubDAL = new ClubDAL();
            UserDTO userDTO = new UserDTO();
            IUserDAL userDAL = new UserDAL();
            bool email = IsValidEmail(txtEmail.Text);
            if (!email)
            {
                clubDTO.ClubBondnr = Convert.ToInt32(txtEmail.Text);
            }
            else
            {
                clubDTO.ClubBondnr = 0;
            }
            clubDTO.Postcode = txtPostcode.Text;
            userDTO.Email = txtEmail.Text;
            userDTO.Password = txtPostcode.Text;
            bool check = userDAL.Inloggen(userDTO);
            bool check2 = clubDAL.Inloggen(clubDTO);
            if (btnInloggen.Text == "Inloggen")
            {
                if (check)
                {
                    label3.Visible = true;
                    btnInloggen.Text = "Uitloggen";
                }
                else
                {
                    if (check2)
                    {
                        Emailconfirm emailconfirm = new Emailconfirm();
                        this.Hide();
                        emailconfirm.Show();
                    }
                    else
                    {
                        if (txtEmail.Text.Trim().Equals(""))
                        {
                            MessageBox.Show("Je moet de email invoegen", "Lege email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (userDTO.Password.Trim().Equals(""))
                        {
                            MessageBox.Show("Je moet het password invoegen", "Leeg password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Gebruikersnaam/password niet correct!", "Verkeerde Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                Application.Restart();
            }
   
    
        }
    }
}
