using BarBoekRegistratie.Classes;
using BarBoekRegistratie.DAL.Club;
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
            InitializeComponent();;
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
            if (rbDemo.Checked | rbJaar.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool BnrCheck()
        {
            if(txtBnr.Text.Length == 6)
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
            ClubDTO clubDTO = new ClubDTO();
            IClubDAL clubDAL = new ClubDAL();        
            clubDTO.Name = txtVnaam.Text;
            if(txtBnr.Text != "")
            {
                clubDTO.ClubBondnr = Convert.ToInt32(txtBnr.Text);
            }        
            clubDTO.Contactperson = txtContactpersoon.Text;
            clubDTO.Street = txtStraat.Text;
            clubDTO.Addition = txtAdd.Text;
            clubDTO.Postcode = txtPostcode.Text;
            clubDTO.Location = txtPlaats.Text;
            clubDTO.Email = txtEmail.Text;
            if (rbDemo.Checked)
            {
                clubDTO.Type = "Demo";
            }
            else
            {
                clubDTO.Type = "Jaarabonnement";
            }
            clubDTO.Comment = txtOpmerking.Text;
            Boolean d = ClubType();
            bool em = IsValidEmail(txtEmail.Text);
            bool bnr = BnrCheck();
            Boolean check = clubDAL.Check(clubDTO);
            if (txtVnaam.Text != "" && txtContactpersoon.Text != "" && txtStraat.Text != "" && txtPostcode.Text != "" && txtPlaats.Text != "" && txtEmail.Text != ""&& txtBnr.Text !=""&& d)
            {
                if (check)
                {
                    MessageBox.Show("Deze verenigingsnaam bestaat al, selecteer een andere.", "Dubbele gebruikersnaam", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (em)
                    {
                        if (bnr)
                        {
                            clubDAL.Insert(clubDTO);
                            MessageBox.Show("Uw account is aangemaakt", "Account aangemaakt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Verkeerde bondnummer.", "Fout", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                      
                    }
                    else
                    {
                            MessageBox.Show("Verkeerde email.","Fout", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("U moet de gevraagde gegevens invullen!", "Lege data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }


        private void linkTerug_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void txtContactpersoon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if(!Char.IsLetter(chr) && !Char.IsWhiteSpace(chr) && !Char.IsControl(chr))
            {
                e.Handled = true;
                MessageBox.Show("Vul alstublieft een geldige waarde in.","Fout", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void txtStraat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsLetter(chr)&& !Char.IsDigit(chr) && !Char.IsWhiteSpace(chr)&& !Char.IsControl(chr) && chr != '.')
            {
                e.Handled = true;
                MessageBox.Show("Vul alstublieft een geldige waarde in.", "Fout", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void txtPostcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsLetter(chr) && !Char.IsDigit(chr) && !Char.IsWhiteSpace(chr) && !Char.IsControl(chr))
            {
                e.Handled = true;
                MessageBox.Show("Vul alstublieft een geldige waarde in.", "Fout", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void txtPlaats_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsLetter(chr) && !Char.IsDigit(chr) && !Char.IsWhiteSpace(chr) && !Char.IsControl(chr))
            {
                e.Handled = true;
                MessageBox.Show("Vul alstublieft een geldige waarde in.", "Fout", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void txtBnr_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && !Char.IsControl(chr))
            {
                e.Handled = true;
                MessageBox.Show("Vul alstublieft een geldige waarde in.", "Fout", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void txtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && !Char.IsControl(chr) && !Char.IsLetter(chr))
            {
                e.Handled = true;
                MessageBox.Show("Vul alstublieft een geldige waarde in.", "Fout", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
