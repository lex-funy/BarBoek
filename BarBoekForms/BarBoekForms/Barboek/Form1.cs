//TODO = ¯\_(ツ)_/¯
//SECTION = (~˘▾˘)~
//SUB-SECTION = ʕ•́ᴥ•̀ʔっ
// Waarom? Het maakt mn code een beetje eigen en het is leuk om doorheen te zien en opvallend. =D
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
using MySqlX.XDevAPI.Relational;
using System.Windows.Forms.VisualStyles;
using Org.BouncyCastle.Asn1.BC;
using System.Threading;
using Barboek.ClassLib.DAL;

namespace Barboek
{
    public partial class Form1 : Form
    {
        //connection string database server=84.31.134.4;database=;username=newuser;password=test;
        public Form1()
        {
            InitializeComponent();
        }

        //(~˘▾˘)~ Universal Variables (~˘▾˘)~
        MemberMySQLContext MemberSQL;
        List<MemberDTO> members = new List<MemberDTO> { };
        List<string> tables = new List<string> { "adres", "betaling", "certificaat", "certificaat-lid-combo", "dienst", "leden", "lid-dienst-combo", "nietbeschikbaar", "schema", "schema-dienst-combo", "vereniging" };
        List<string> usedTables = new List<string> { };
        List<string> usedColumns = new List<string> { };
        string NameSQLSpecifier = "";
        string ShiftDateSQLSpecifier = "";
        string AgeSQLSpecifier = "";
        string AbsenceSQLSpecifier = "";
        string GroupSQLSpecifier = "";
        readonly string connectionString = "Server=84.31.134.4;Database=barboekmain;User Id=newuser;Password=test;";
        //(~˘▾˘)~ MySQL (~˘▾˘)~
        private bool ConnectToDatabase()
        {
            try
            {
                MemberSQL = new MemberMySQLContext(connectionString);
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

        private bool ExecuteGivenQuery()
        {
            if (ConnectToDatabase())
            {
                string query = composeQuery();
                List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
                DataSet results = ExecuteQuery(query, parameters);
                dgvShowResults.AutoGenerateColumns = true;
                dgvShowResults.DataSource = results; // dataset
                dgvShowResults.DataMember = "Results";

                return true;

            }
            else
            {
                return false;
            }
        }

        public DataSet ExecuteQuery(string query, List<KeyValuePair<string, string>> parameters)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = conn.CreateCommand();
                foreach (KeyValuePair<string, string> kvp in parameters)
                {
                    MySqlParameter para = new MySqlParameter();
                    para.ParameterName = "@" + kvp.Key;
                    para.Value = "@" + kvp.Value;
                    cmd.Parameters.Add(para);
                }
                cmd.CommandText = query;
                da.SelectCommand = cmd;

                conn.Open();
                da.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            return ds;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            AllMembers();
            foreach (MemberDTO m in members)
            {
                CLBMembers.Items.Add(m.Name);
            }
            fillLBTables();

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
            dgvShowResults.Visible = false;
            dgvShowResults.Enabled = false;
        }

        //(~˘▾˘)~ Interactions with Interface (~˘▾˘)~
        //ʕ•́ᴥ•̀ʔっ Radiobox Changed ʕ•́ᴥ•̀ʔっ
        private void RBName_CheckedChanged(object sender, EventArgs e)
        {
            if (RBName.Checked)
            {
                setAllInvisibleDisabled();
                LContains.Visible = true;
                TBContains.Enabled = true;
                TBContains.Visible = true;
                TBContains.Clear();
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
                TBFrom.Clear();
                TBTill.Clear();
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

        //ʕ•́ᴥ•̀ʔっ Select All Button ʕ•́ᴥ•̀ʔっ
        private void CBSelectAllGro_CheckedChanged(object sender, EventArgs e)
        {
            selectAllInCheckBoxList(CBSelectAllGro, CLBGroups);
        }
        private void CBSelectAllMem_CheckedChanged(object sender, EventArgs e)
        {
            selectAllInCheckBoxList(CBSelectAllMem, CLBMembers);
        }
        private void CBSelectAllColumns_CheckedChanged(object sender, EventArgs e)
        {
            selectAllInCheckBoxList(CBSelectAllColumns, CLBColumns);
        }

        //ʕ•́ᴥ•̀ʔっ Select different Tables ʕ•́ᴥ•̀ʔっ 
        private void LBTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = LBTables.SelectedItem.ToString();
            fillForSelected(selected);
        }

        private void selectAllInCheckBoxList(CheckBox checkChanged, CheckedListBox toSelectAll)
        {
            bool isChecked = checkChanged.Checked;
            for (int i = 0; i < toSelectAll.Items.Count; i++)
            {
                toSelectAll.SetItemChecked(i, isChecked);
            }
        }

        //ʕ•́ᴥ•̀ʔっ Buttons ʕ•́ᴥ•̀ʔっ
        private void bAddSpecifier_Click(object sender, EventArgs e)
        {
            string rb = findSelectedRadioButton();
            addSpecifier(rb);
        }

        private void bAddColumn_Click(object sender, EventArgs e)
        {
            addSelectedColumns();
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            // ¯\_(ツ)_/¯ Save Template to Database ¯\_(ツ)_/¯
        }
        private void bGenerateRapport_Click(object sender, EventArgs e)
        {
            ExecuteGivenQuery();
            dgvShowResults.Visible = true;
            dgvShowResults.Enabled = true;
        }

        //(~˘▾˘)~ Fill Stuff (~˘▾˘)~
        private void fillLBTables()
        {
            foreach (string table in tables)
            {
                LBTables.Items.Add(table);
            }
        }
        private void fillForSelected(string selected)
        {
            CLBColumns.Items.Clear();
            List<string> columns;
            switch (selected)
            {
                case "adres": { columns = fillForAdres(); break; };
                case "betaling": { columns = fillForBetaling(); break; };
                case "certificaat": { columns = fillForCertificaat(); break; };
                case "certificaat-lid-combo": { columns = fillForCertificaatLidCombo(); break; };
                case "dienst": { columns = fillForDienst(); break; };
                case "leden": { columns = fillForLeden(); break; };
                case "lid-dienst-combo": { columns = fillForLidDienstCombo(); break; };
                case "nietbeschikbaar": { columns = fillForNietBeschikbaar(); break; };
                case "schema": { columns = fillForSchema(); break; };
                case "schema-dienst-combo": { columns = fillForSchemaDienstCombo(); break; };
                case "vereniging": { columns = fillForVereniging(); break; };
                default: { columns = new List<string> { "Geen tabel geselecteerd" }; break; };
            }

            foreach (string columnName in columns)
            {
                CLBColumns.Items.Add(columnName);
                int index = CLBColumns.Items.IndexOf(columnName);
                if (index != -1)
                {
                    if (usedColumns.Contains(LBTables.SelectedItem.ToString() + "." + columnName))
                    {
                        CLBColumns.SetItemChecked(index, true);
                    }
                }
            }
        }

        //ʕ•́ᴥ•̀ʔっ Fill for specific table ʕ•́ᴥ•̀ʔっ 
        private List<string> fillForAdres()
        {
            List<string> columns = new List<string> { "ID", "zipcode", "number", "addition" };
            return columns;
        }
        private List<string> fillForBetaling()
        {
            List<string> columns = new List<string> { "ID", "Lid_Dienst_ID", "geslaagd" };
            return columns;
        }
        private List<string> fillForCertificaat()
        {
            List<string> columns = new List<string> { "ID", "naam" };
            return columns;
        }
        private List<string> fillForCertificaatLidCombo()
        {
            List<string> columns = new List<string> { "ID", "certificaatID", "lidID", "behaaldOp", "verstrekingsDatum" };
            return columns;
        }
        private List<string> fillForDienst()
        {
            List<string> columns = new List<string> { "ID", "naam", "startMoment", "eindMoment", "soort", "maxLeden" };
            return columns;
        }
        private List<string> fillForLeden()
        {
            List<string> columns = new List<string> { "ID", "naam", "adresID", "geboortedatum", "email", "toegang", "bondsnummer", "achternaam", "voorletters", "tussenvoegsel", "telefoon", "geslacht", "telefoonWerk", "telefoonMobiel" };
            return columns;
        }
        private List<string> fillForLidDienstCombo()
        {
            List<string> columns = new List<string> { "ID", "lidID", "dienstID" };
            return columns;
        }
        private List<string> fillForNietBeschikbaar()
        {
            List<string> columns = new List<string> { "ID", "lidID", "beginMoment", "eindMoment" };
            return columns;
        }
        private List<string> fillForSchema()
        {
            List<string> columns = new List<string> { "ID", "naam", "verenigingID" };
            return columns;
        }
        private List<string> fillForSchemaDienstCombo()
        {
            List<string> columns = new List<string> { "ID", "dienstID", "schemaID" };
            return columns;
        }
        private List<string> fillForVereniging()
        {
            List<string> columns = new List<string> { "ID", "naam", "adresID", "email", "schemaID" };
            return columns;
        }

        //(~˘▾˘)~ Add stuff (~˘▾˘)~
        private void addSpecifier(string rbSelected)
        {
            switch (rbSelected)
            {
                case "name": NameSQLSpecifier = NameSQLSpecifier + addWhenNameRBSelected(); break;
                case "date": ShiftDateSQLSpecifier = ShiftDateSQLSpecifier + addWhenDateRBSelected(); break;
                case "age": AgeSQLSpecifier = AgeSQLSpecifier + addWhenAgeRBSelected(); break;
                case "exceptionAbsence": AbsenceSQLSpecifier = AbsenceSQLSpecifier + addWhenExceptionRBSelected(); break;
                case "group": GroupSQLSpecifier = GroupSQLSpecifier + addWhenGroupRBSelected(); break;
                case "none": addWhenNoRBSelected(); break;
                default: addWhenNoRBSelected(); break;
            }
        }
        private void addSelectedColumns()
        {
            foreach (string column in CLBColumns.CheckedItems)
            {
                string usedTable = LBTables.SelectedItem.ToString();
                string toUse = "`" + usedTable + "`." + column;
                if (!usedColumns.Contains(toUse))
                {
                    usedColumns.Add(toUse);
                }

            }
            if (LBTables.SelectedItem != null)
            {
                usedTables.Add(LBTables.SelectedItem.ToString());
            }
            foreach (string s in usedColumns)
            {
                MessageBox.Show(s);
            }
        }

        //ʕ•́ᴥ•̀ʔっ Add specific stuff ʕ•́ᴥ•̀ʔっ 
        private string addWhenNameRBSelected()
        {
            string nameContains = "";
            if (TBContains.Text != null)
            {
                nameContains = "((`leden`.naam LIKE '%" + TBContains.Text + "%') OR (`leden`.achternaam LIKE '%" + TBContains.Text + "%'))";
            }
            return nameContains;
        }
        private string addWhenDateRBSelected()
        {
            DateTime dtFromInput = dtFrom.Value;
            DateTime dtTillInput = dtTill.Value;
            string dateFilter = "";
            if (dtFromInput == null && dtTillInput != null)
            {
                dateFilter = "(`dienst`.eindMoment > " + dtTillInput.ToString() + ")";
            }
            else if (dtTillInput == null && dtFromInput != null)
            {
                dateFilter = "(`dienst`.startMoment < " + dtTillInput.ToString() + ")";
            }
            else if (dtFromInput < dtTillInput)
            {
                dateFilter = "((`dienst`.startMoment > " + dtFromInput.ToString() + ") AND (`dienst`.eindMoment < " + dtTillInput.ToString() + "))";
            }
            else if (dtFromInput > dtTillInput)
            {
                dateFilter = "((`dienst`.startMoment > " + dtFromInput.ToString() + ") OR (`dienst`.eindMoment < " + dtTillInput.ToString() + "))";
            }
            else if (dtFromInput == null && dtTillInput == null)
            {
                dateFilter = "";
            }
            return dateFilter;


        }
        private string addWhenAgeRBSelected()
        {
            string fromInput = TBFrom.Text;
            string tillInput = TBTill.Text;
            string ageFilter = "";
            bool successFrom = int.TryParse(fromInput, out int fromAge);
            bool successTill = int.TryParse(tillInput, out int tillAge);
            DateTime Today = DateTime.Now;
            DateTime BirthdayFrom;
            DateTime BirthdayTill;
            if (successFrom == false && successTill == true)
            {
                BirthdayTill = Today.AddYears((tillAge) * -1);
                ageFilter = "(`leden`.geboortedatum < " + BirthdayTill.ToString() + ")";
            }
            else if (successTill == false && successFrom == true)
            {
                BirthdayFrom = Today.AddYears((fromAge + 1) * -1);
                ageFilter = "(`leden`.geboortedatum >  " + BirthdayFrom.ToString() + ")";
            }
            else if (successFrom == false && successTill == false)
            {
                ageFilter = "";

            }
            else if (fromAge > tillAge)
            {
                BirthdayFrom = Today.AddYears((fromAge + 1) * -1);
                BirthdayTill = Today.AddYears((tillAge) * -1);
                ageFilter = "((`leden`.geboortedatum < " + BirthdayTill.ToString() + ") OR (`leden`.geboortedatum >  " + BirthdayFrom.ToString() + "))";
            }
            else if (fromAge < tillAge)
            {
                BirthdayFrom = Today.AddYears((fromAge + 1) * -1);
                BirthdayTill = Today.AddYears((tillAge) * -1);
                ageFilter = "((`leden`.geboortedatum < " + BirthdayTill.ToString() + ") AND (`leden`.geboortedatum >  " + BirthdayFrom.ToString() + "))";
            }
            else if (fromAge == tillAge)
            {
                BirthdayFrom = Today.AddYears((fromAge + 1) * -1);
                BirthdayTill = Today.AddYears((tillAge) * -1);
                ageFilter = "((`leden`.geboortedatum < " + BirthdayTill.ToString() + ") AND (`leden`.geboortedatum >  " + BirthdayFrom.ToString() + "))";
            }
            return ageFilter;

        }
        private string addWhenExceptionRBSelected()
        {

            DateTime dtFromInput = dtFrom.Value;
            DateTime dtTillInput = dtTill.Value;
            string dateFilter = "";
            //¯\_(ツ)_/¯ Add Absence to Database / Class Diagram ¯\_(ツ)_/¯
            if (dtFromInput == null && dtTillInput != null)
            {
                /*dateFilter = "(`dienst`.eindMoment > " + dtTillInput.ToString() + ")";*/
            }
            else if (dtTillInput == null && dtFromInput != null)
            {
                //dateFilter = "(`dienst`.startMoment < " + dtTillInput.ToString() + ")";
            }
            else if (dtFromInput < dtTillInput)
            {
                //dateFilter = "((`dienst`.startMoment > " + dtFromInput.ToString() + ") AND (`dienst`.eindMoment < " + dtTillInput.ToString() + "))";
            }
            else if (dtFromInput > dtTillInput)
            {
                //dateFilter = "((`dienst`.startMoment > " + dtFromInput.ToString() + ") OR (`dienst`.eindMoment < " + dtTillInput.ToString() + "))";
            }
            else if (dtFromInput == null && dtTillInput == null)
            {
                //dateFilter = "";
            }
            return dateFilter;
        }
        private string addWhenGroupRBSelected()
        {
            string groupContains = "";
            if (TBContains.Text != null)
            {
                //¯\_(ツ)_/¯ ADD GROUPS TO DATABASE + CLASS DIAGRAM ¯\_(ツ)_/¯
                //groupContains = "((`leden`.naam LIKE '%" + TBContains.Text + "%') OR (`leden`.achternaam LIKE '%" + TBContains.Text + "%'))";
            }
            return groupContains;
        }
        private void addWhenNoRBSelected()
        {
            MessageBox.Show("Er is geen RadioButton geselecteerd.");
        }

        //(~˘▾˘)~ Find stuff (~˘▾˘)~
        private string findSelectedRadioButton()
        {
            if (RBName.Checked)
            {
                return "name";
            }
            else if (RBDate.Checked)
            {
                return "date";
            }
            else if (RBAge.Checked)
            {
                return "age";
            }
            else if (RBExceptionAbsence.Checked)
            {
                return "exceptionAbsence";
            }
            else if (RBGroup.Checked)
            {
                return "group";
            }
            return "none";
        }

        //(~˘▾˘)~ Compose stuff (~˘▾˘)~
        public string composeQuery()
        {
            string composedQuery = "SELECT " + usedColumnsString() + " FROM " + usedTablesString() + " WHERE " + combinedSpecificationsString();
            return composedQuery;
        }

        public string usedTablesString()
        {
            string usedTablesString = "";
            int count = usedTables.Count;
            int tablesUsed = 1;
            foreach (string table in usedTables)
            {
                usedTablesString = usedTablesString + "`" + table + "`";
                if (tablesUsed < count)
                {
                    usedTablesString = usedTablesString + ", ";
                }
                tablesUsed++;
            }
            return usedTablesString;
        }

        public string usedColumnsString()
        {
            string usedColumnsString = "";
            int count = usedColumns.Count;
            int columnsUsed = 1;
            foreach (string column in usedColumns)
            {
                usedColumnsString = usedColumnsString + "`" + column + "`";
                if (columnsUsed < count)
                {
                    usedColumnsString = usedColumnsString + ", ";
                }
                columnsUsed++;
            }
            return usedColumnsString;
        }

        public string combinedSpecificationsString()
        {
            string combinedSpecificationsString = "";

            combinedSpecificationsString = combinedSpecificationsString + NameSQLSpecifier;
            combinedSpecificationsString = addAndBetweenStringsWhenLastStringIsNotEmpty(combinedSpecificationsString, ShiftDateSQLSpecifier);
            combinedSpecificationsString = addAndBetweenStringsWhenLastStringIsNotEmpty(combinedSpecificationsString, AgeSQLSpecifier);
            combinedSpecificationsString = addAndBetweenStringsWhenLastStringIsNotEmpty(combinedSpecificationsString, AbsenceSQLSpecifier);
            combinedSpecificationsString = addAndBetweenStringsWhenLastStringIsNotEmpty(combinedSpecificationsString, GroupSQLSpecifier);

            return combinedSpecificationsString;
        }

        public bool stringHasValue(string toCheck)
        {
            bool result = false;
            if (toCheck.Length > 0)
            {
                result = true;
            }
            return result;
        }

        public string addAndBetweenStringsWhenLastStringIsNotEmpty(string first, string last)
        {

            string result = "";
            if (stringHasValue(last))
            {
                result = first + " AND " + last;
            }
            return result;
        }
    }
}
