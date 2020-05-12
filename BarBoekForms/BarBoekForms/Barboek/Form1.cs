using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Barboek
{
    public partial class Form1 : Form
    {
        //connection string database server=84.31.134.4;database=;username=newuser;password=test;
        public Form1()
        {
            InitializeComponent();
        }
        
        MySqlConnection Connection;
        string query;
        private bool OpenConnection()
        {
            //Connectiestring benodigd om te verbinden met database
            string connectionString = "Server=84.31.134.4;Database=barboekmain;User Id=newuser;Password=test;";
            Connection = new MySqlConnection(connectionString);//Daadwerkelijke verbinding

            try // Doe een poging om de database te openen
            {
                Connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString()); //Geef de error weer als dit niet lukt
                return false;
            }
        }

        private bool CloseConnection()
        {
            try //Doe een poging de connectie te sluiten
            {
                Connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString()); //Geef een error weer als dit niet lukt
                return false;
            }
        }

        private bool LoadData()
        {
            try
            {
                if (OpenConnection())
                {
                    try
                    {
                        using (MySqlCommand command = new MySqlCommand(query, Connection)) //maak dan dit command voor de database van de connectie
                        {
                            try
                            {
                                using (MySqlDataReader reader = command.ExecuteReader()) // voer het command uit
                                {
                                    while (reader.Read())
                                    {
                                        //DO SOMETHING ¯\_(ツ)_/¯ 
                                        string memberName = reader.GetString(0);
                                        int memberId = reader.GetInt32(1);
                                        DateTime memberBirthDate = reader.GetDateTime(2);
                                        MessageBox.Show(memberName + " " + memberId + " " + memberBirthDate);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                return true;
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenConnection();
            MessageBox.Show("success");
            CloseConnection();
        }

        private void setAllInvisibleDisabled()
        {
            LFrom.Visible = false;
            LUntill.Visible = false;
            dtFrom.Visible = false;
            dtFrom.Enabled = false;
            dtTill.Visible = false;
            dtTill.Enabled = false;
            LContains.Visible = false;
            TBContains.Enabled = false;
            TBContains.Visible = false;
            LGroups.Visible = false;
            CLBGroups.Visible = false;
            CLBGroups.Enabled = false;
            CBSelectAllGro.Visible = false;
            CBSelectAllGro.Enabled = false;
            TBTill.Visible = false;
            TBTill.Enabled = false;
            TBFrom.Visible = false;
            TBFrom.Enabled = false;
        }
        private void RBName_CheckedChanged(object sender, EventArgs e)
        {
            if(RBName.Checked)
            {
                setAllInvisibleDisabled();
                LContains.Visible = true;
                TBContains.Enabled = true;
                TBContains.Visible = true;
            }
            else
            {
                
            }
        }

        private void RBDate_CheckedChanged(object sender, EventArgs e)
        {
            if (RBDate.Checked)
            {
                setAllInvisibleDisabled();
                LFrom.Visible = true;
                LUntill.Visible = true;
                dtFrom.Visible = true;
                dtFrom.Enabled = true;
                dtTill.Visible = true;
                dtTill.Enabled = true;
                
            }
            else
            {

            }
        }

        private void RBAge_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAge.Checked)
            {
                setAllInvisibleDisabled();
                LFrom.Visible = true;
                TBFrom.Visible = true;
                TBFrom.Enabled = true;
                LUntill.Visible = true;
                TBTill.Visible = true;
                TBTill.Enabled = true;
            }
            else
            {

            }
        }

        private void RBExceptionAbsence_CheckedChanged(object sender, EventArgs e)
        {
            if (RBExceptionAbsence.Checked)
            {
                setAllInvisibleDisabled();
                LFrom.Visible = true;
                LUntill.Visible = true;
                dtFrom.Visible = true;
                dtFrom.Enabled = true;
                dtTill.Visible = true;
                dtTill.Enabled = true;
            }
            else
            {

            }
        }

        private void RBGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (RBGroup.Checked)
            {
                setAllInvisibleDisabled();
                LGroups.Visible = true;
                CLBGroups.Visible = true;
                CLBGroups.Enabled = true;
                CBSelectAllGro.Visible = true;
                CBSelectAllGro.Enabled = true;
                
            }
            else
            {

            }
        }

        private void CBSelectAllGro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBSelectAllMem_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
