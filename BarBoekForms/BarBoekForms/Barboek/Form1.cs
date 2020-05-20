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
using Barboek.ClassLib.DAL.Model;
using Barboek.ClassLib.DAL.Contexts;
using System.Data.SqlClient;

namespace Barboek
{
    public partial class Form1 : Form
    {
        //connection string database server=84.31.134.4;database=;username=newuser;password=test;
        public Form1()
        {
            InitializeComponent();
        }
        
        AddressMySQLContext AddressSQL;
        List<AddressDTO> addresses = new List<AddressDTO> { };
        ClubMySQLContext ClubSQL;
        List<ClubDTO> clubs = new List<ClubDTO> { };
        MemberMySQLContext MemberSQL;
        List<MemberDTO> members = new List<MemberDTO> { };
        PaymentMySQLContext PaymentSQL;
        List<PaymentDTO> payments = new List<PaymentDTO> { };
        ScheduleMySQLContext ScheduleSQL;
        List<ScheduleDTO> schedules = new List<ScheduleDTO> { };
        ShiftMySQLContext ShiftSQL;
        List<ShiftDTO> shifts = new List<ShiftDTO> { };


        private bool ConnectToDatabase()
        {
            string connectionString = "Server=84.31.134.4;Database=barboekmain;User Id=newuser;Password=test;";

            try
            {
                AddressSQL = new AddressMySQLContext(connectionString);
                ClubSQL = new ClubMySQLContext(connectionString);
                MemberSQL = new MemberMySQLContext(connectionString);
                PaymentSQL = new PaymentMySQLContext(connectionString);
                ScheduleSQL = new ScheduleMySQLContext(connectionString);
                ShiftSQL = new ShiftMySQLContext(connectionString);
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private bool AllAddresses()
        {
            try
            {
                if (ConnectToDatabase())
                {
                    addresses = AddressSQL.GetAllAddresses();
                }
                return true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private bool AllClubs()
        {
            try
            {
                if (ConnectToDatabase())
                {
                    clubs = ClubSQL.GetAllClubs();
                }
                return true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private bool AllMembers()
        {
            try
            {
                if (ConnectToDatabase())
                {
                    members = MemberSQL.GetAllMembers();
                }
                return true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private bool AllPayments()
        {
            try
            {
                if (ConnectToDatabase())
                {
                    payments = PaymentSQL.GetAllPayments();
                }
                return true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private bool AllSchedules()
        {
            try
            {
                if (ConnectToDatabase())
                {
                    schedules = ScheduleSQL.GetAllSchedules();
                }
                return true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private bool AllShifts()
        {
            try
            {
                if (ConnectToDatabase())
                {
                    shifts = ShiftSQL.GetAllShift();
                }
                return true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            AllMembers();
            AllShifts();
            AllPayments();
            //AllSchedules();
            AllAddresses();
            AllClubs();
            foreach(MemberDTO m in members)
            {
                CLBMembers.Items.Add(m.Name);
            }
            
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
            ClubMySQLContext cmsqlc = new ClubMySQLContext("Server=84.31.134.4;Database=barboekmain;User Id=newuser;Password=test;");
            cmsqlc.GetAllClubs();
            List<ClubDTO> list = cmsqlc.GetAllClubs();
            foreach(ClubDTO c in list)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void CLBGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
