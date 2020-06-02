namespace Barboek
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CBSelectAllGro = new System.Windows.Forms.CheckBox();
            this.RBName = new System.Windows.Forms.RadioButton();
            this.RBDate = new System.Windows.Forms.RadioButton();
            this.RBAge = new System.Windows.Forms.RadioButton();
            this.RBExceptionAbsence = new System.Windows.Forms.RadioButton();
            this.RBGroup = new System.Windows.Forms.RadioButton();
            this.CLBMembers = new System.Windows.Forms.CheckedListBox();
            this.CBSelectAllMem = new System.Windows.Forms.CheckBox();
            this.CBApplyTemplate = new System.Windows.Forms.ComboBox();
            this.BApplyTemplate = new System.Windows.Forms.Button();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTill = new System.Windows.Forms.DateTimePicker();
            this.TBContains = new System.Windows.Forms.TextBox();
            this.BSave = new System.Windows.Forms.Button();
            this.LApplyTemplate = new System.Windows.Forms.Label();
            this.LFrom = new System.Windows.Forms.Label();
            this.LUntill = new System.Windows.Forms.Label();
            this.LContains = new System.Windows.Forms.Label();
            this.LStudents = new System.Windows.Forms.Label();
            this.LTitle = new System.Windows.Forms.Label();
            this.TBFrom = new System.Windows.Forms.TextBox();
            this.TBTill = new System.Windows.Forms.TextBox();
            this.LGroups = new System.Windows.Forms.Label();
            this.CLBGroups = new System.Windows.Forms.CheckedListBox();
            this.bAddColumn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBSelectAllColumns = new System.Windows.Forms.CheckBox();
            this.CLBColumns = new System.Windows.Forms.CheckedListBox();
            this.LBTables = new System.Windows.Forms.ListBox();
            this.bAddSpecifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBSelectAllGro
            // 
            this.CBSelectAllGro.AutoSize = true;
            this.CBSelectAllGro.Location = new System.Drawing.Point(722, 308);
            this.CBSelectAllGro.Name = "CBSelectAllGro";
            this.CBSelectAllGro.Size = new System.Drawing.Size(130, 21);
            this.CBSelectAllGro.TabIndex = 22;
            this.CBSelectAllGro.Text = "Alles selecteren";
            this.CBSelectAllGro.UseVisualStyleBackColor = true;
            this.CBSelectAllGro.CheckedChanged += new System.EventHandler(this.CBSelectAllGro_CheckedChanged);
            // 
            // RBName
            // 
            this.RBName.AutoSize = true;
            this.RBName.Location = new System.Drawing.Point(39, 140);
            this.RBName.Name = "RBName";
            this.RBName.Size = new System.Drawing.Size(66, 21);
            this.RBName.TabIndex = 0;
            this.RBName.Text = "Naam";
            this.RBName.UseVisualStyleBackColor = true;
            this.RBName.CheckedChanged += new System.EventHandler(this.RBName_CheckedChanged);
            // 
            // RBDate
            // 
            this.RBDate.AutoSize = true;
            this.RBDate.Location = new System.Drawing.Point(39, 183);
            this.RBDate.Name = "RBDate";
            this.RBDate.Size = new System.Drawing.Size(112, 21);
            this.RBDate.TabIndex = 1;
            this.RBDate.Text = "Datum dienst";
            this.RBDate.UseVisualStyleBackColor = true;
            this.RBDate.CheckedChanged += new System.EventHandler(this.RBDate_CheckedChanged);
            // 
            // RBAge
            // 
            this.RBAge.AutoSize = true;
            this.RBAge.Location = new System.Drawing.Point(39, 229);
            this.RBAge.Name = "RBAge";
            this.RBAge.Size = new System.Drawing.Size(75, 21);
            this.RBAge.TabIndex = 2;
            this.RBAge.Text = "Leeftijd";
            this.RBAge.UseVisualStyleBackColor = true;
            this.RBAge.CheckedChanged += new System.EventHandler(this.RBAge_CheckedChanged);
            // 
            // RBExceptionAbsence
            // 
            this.RBExceptionAbsence.AutoSize = true;
            this.RBExceptionAbsence.Location = new System.Drawing.Point(39, 272);
            this.RBExceptionAbsence.Name = "RBExceptionAbsence";
            this.RBExceptionAbsence.Size = new System.Drawing.Size(109, 21);
            this.RBExceptionAbsence.TabIndex = 4;
            this.RBExceptionAbsence.Text = "Ziekte/Verlof";
            this.RBExceptionAbsence.UseVisualStyleBackColor = true;
            this.RBExceptionAbsence.CheckedChanged += new System.EventHandler(this.RBExceptionAbsence_CheckedChanged);
            // 
            // RBGroup
            // 
            this.RBGroup.AutoSize = true;
            this.RBGroup.Location = new System.Drawing.Point(39, 310);
            this.RBGroup.Name = "RBGroup";
            this.RBGroup.Size = new System.Drawing.Size(69, 21);
            this.RBGroup.TabIndex = 3;
            this.RBGroup.Text = "Groep";
            this.RBGroup.UseVisualStyleBackColor = true;
            this.RBGroup.CheckedChanged += new System.EventHandler(this.RBGroup_CheckedChanged);
            // 
            // CLBMembers
            // 
            this.CLBMembers.FormattingEnabled = true;
            this.CLBMembers.Location = new System.Drawing.Point(218, 142);
            this.CLBMembers.Name = "CLBMembers";
            this.CLBMembers.Size = new System.Drawing.Size(228, 157);
            this.CLBMembers.TabIndex = 5;
            // 
            // CBSelectAllMem
            // 
            this.CBSelectAllMem.AutoSize = true;
            this.CBSelectAllMem.Location = new System.Drawing.Point(218, 310);
            this.CBSelectAllMem.Name = "CBSelectAllMem";
            this.CBSelectAllMem.Size = new System.Drawing.Size(130, 21);
            this.CBSelectAllMem.TabIndex = 6;
            this.CBSelectAllMem.Text = "Alles selecteren";
            this.CBSelectAllMem.UseVisualStyleBackColor = true;
            this.CBSelectAllMem.CheckedChanged += new System.EventHandler(this.CBSelectAllMem_CheckedChanged);
            // 
            // CBApplyTemplate
            // 
            this.CBApplyTemplate.FormattingEnabled = true;
            this.CBApplyTemplate.Location = new System.Drawing.Point(1021, 43);
            this.CBApplyTemplate.Name = "CBApplyTemplate";
            this.CBApplyTemplate.Size = new System.Drawing.Size(230, 24);
            this.CBApplyTemplate.TabIndex = 7;
            // 
            // BApplyTemplate
            // 
            this.BApplyTemplate.Location = new System.Drawing.Point(1136, 73);
            this.BApplyTemplate.Name = "BApplyTemplate";
            this.BApplyTemplate.Size = new System.Drawing.Size(115, 39);
            this.BApplyTemplate.TabIndex = 8;
            this.BApplyTemplate.Text = "Toepassen";
            this.BApplyTemplate.UseVisualStyleBackColor = true;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(464, 161);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(232, 22);
            this.dtFrom.TabIndex = 9;
            // 
            // dtTill
            // 
            this.dtTill.Location = new System.Drawing.Point(464, 215);
            this.dtTill.Name = "dtTill";
            this.dtTill.Size = new System.Drawing.Size(232, 22);
            this.dtTill.TabIndex = 10;
            // 
            // TBContains
            // 
            this.TBContains.Location = new System.Drawing.Point(470, 277);
            this.TBContains.Name = "TBContains";
            this.TBContains.Size = new System.Drawing.Size(226, 22);
            this.TBContains.TabIndex = 11;
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(1172, 355);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(75, 31);
            this.BSave.TabIndex = 12;
            this.BSave.Text = "Opslaan";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // LApplyTemplate
            // 
            this.LApplyTemplate.AutoSize = true;
            this.LApplyTemplate.Location = new System.Drawing.Point(1018, 23);
            this.LApplyTemplate.Name = "LApplyTemplate";
            this.LApplyTemplate.Size = new System.Drawing.Size(137, 17);
            this.LApplyTemplate.TabIndex = 13;
            this.LApplyTemplate.Text = "Template toepassen";
            // 
            // LFrom
            // 
            this.LFrom.AutoSize = true;
            this.LFrom.Location = new System.Drawing.Point(461, 141);
            this.LFrom.Name = "LFrom";
            this.LFrom.Size = new System.Drawing.Size(45, 17);
            this.LFrom.TabIndex = 14;
            this.LFrom.Text = "Vanaf";
            // 
            // LUntill
            // 
            this.LUntill.AutoSize = true;
            this.LUntill.Location = new System.Drawing.Point(461, 195);
            this.LUntill.Name = "LUntill";
            this.LUntill.Size = new System.Drawing.Size(29, 17);
            this.LUntill.TabIndex = 15;
            this.LUntill.Text = "Tot";
            // 
            // LContains
            // 
            this.LContains.AutoSize = true;
            this.LContains.Location = new System.Drawing.Point(461, 257);
            this.LContains.Name = "LContains";
            this.LContains.Size = new System.Drawing.Size(44, 17);
            this.LContains.TabIndex = 16;
            this.LContains.Text = "Bevat";
            // 
            // LStudents
            // 
            this.LStudents.AutoSize = true;
            this.LStudents.Location = new System.Drawing.Point(215, 112);
            this.LStudents.Name = "LStudents";
            this.LStudents.Size = new System.Drawing.Size(73, 17);
            this.LStudents.TabIndex = 17;
            this.LStudents.Text = "Studenten";
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Location = new System.Drawing.Point(36, 40);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(129, 17);
            this.LTitle.TabIndex = 18;
            this.LTitle.Text = "Rapport genereren";
            // 
            // TBFrom
            // 
            this.TBFrom.Location = new System.Drawing.Point(464, 161);
            this.TBFrom.Name = "TBFrom";
            this.TBFrom.Size = new System.Drawing.Size(89, 22);
            this.TBFrom.TabIndex = 19;
            this.TBFrom.Visible = false;
            // 
            // TBTill
            // 
            this.TBTill.Location = new System.Drawing.Point(464, 215);
            this.TBTill.Name = "TBTill";
            this.TBTill.Size = new System.Drawing.Size(89, 22);
            this.TBTill.TabIndex = 20;
            this.TBTill.Visible = false;
            // 
            // LGroups
            // 
            this.LGroups.AutoSize = true;
            this.LGroups.Location = new System.Drawing.Point(719, 110);
            this.LGroups.Name = "LGroups";
            this.LGroups.Size = new System.Drawing.Size(64, 17);
            this.LGroups.TabIndex = 23;
            this.LGroups.Text = "Groepen";
            // 
            // CLBGroups
            // 
            this.CLBGroups.FormattingEnabled = true;
            this.CLBGroups.Location = new System.Drawing.Point(722, 140);
            this.CLBGroups.Name = "CLBGroups";
            this.CLBGroups.Size = new System.Drawing.Size(130, 157);
            this.CLBGroups.TabIndex = 21;
            // 
            // bAddColumn
            // 
            this.bAddColumn.Location = new System.Drawing.Point(1048, 355);
            this.bAddColumn.Name = "bAddColumn";
            this.bAddColumn.Size = new System.Drawing.Size(103, 31);
            this.bAddColumn.TabIndex = 24;
            this.bAddColumn.Text = "Toevoegen";
            this.bAddColumn.UseVisualStyleBackColor = true;
            this.bAddColumn.Click += new System.EventHandler(this.bAddColumn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(868, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tabellen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1056, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Kolommen";
            // 
            // CBSelectAllColumns
            // 
            this.CBSelectAllColumns.AutoSize = true;
            this.CBSelectAllColumns.Location = new System.Drawing.Point(1059, 308);
            this.CBSelectAllColumns.Name = "CBSelectAllColumns";
            this.CBSelectAllColumns.Size = new System.Drawing.Size(130, 21);
            this.CBSelectAllColumns.TabIndex = 29;
            this.CBSelectAllColumns.Text = "Alles selecteren";
            this.CBSelectAllColumns.UseVisualStyleBackColor = true;
            this.CBSelectAllColumns.CheckedChanged += new System.EventHandler(this.CBSelectAllColumns_CheckedChanged);
            // 
            // CLBColumns
            // 
            this.CLBColumns.FormattingEnabled = true;
            this.CLBColumns.Location = new System.Drawing.Point(1059, 140);
            this.CLBColumns.Name = "CLBColumns";
            this.CLBColumns.Size = new System.Drawing.Size(188, 157);
            this.CLBColumns.TabIndex = 28;
            // 
            // LBTables
            // 
            this.LBTables.FormattingEnabled = true;
            this.LBTables.ItemHeight = 16;
            this.LBTables.Location = new System.Drawing.Point(871, 133);
            this.LBTables.Name = "LBTables";
            this.LBTables.Size = new System.Drawing.Size(166, 164);
            this.LBTables.TabIndex = 31;
            this.LBTables.SelectedIndexChanged += new System.EventHandler(this.LBTables_SelectedIndexChanged);
            // 
            // bAddSpecifier
            // 
            this.bAddSpecifier.Location = new System.Drawing.Point(593, 355);
            this.bAddSpecifier.Name = "bAddSpecifier";
            this.bAddSpecifier.Size = new System.Drawing.Size(103, 31);
            this.bAddSpecifier.TabIndex = 32;
            this.bAddSpecifier.Text = "Toevoegen";
            this.bAddSpecifier.UseVisualStyleBackColor = true;
            this.bAddSpecifier.Click += new System.EventHandler(this.bAddSpecifier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 488);
            this.Controls.Add(this.bAddSpecifier);
            this.Controls.Add(this.LBTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBSelectAllColumns);
            this.Controls.Add(this.CLBColumns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAddColumn);
            this.Controls.Add(this.LGroups);
            this.Controls.Add(this.CBSelectAllGro);
            this.Controls.Add(this.CLBGroups);
            this.Controls.Add(this.TBTill);
            this.Controls.Add(this.TBFrom);
            this.Controls.Add(this.LTitle);
            this.Controls.Add(this.LStudents);
            this.Controls.Add(this.LContains);
            this.Controls.Add(this.LUntill);
            this.Controls.Add(this.LFrom);
            this.Controls.Add(this.LApplyTemplate);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.TBContains);
            this.Controls.Add(this.dtTill);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.BApplyTemplate);
            this.Controls.Add(this.CBApplyTemplate);
            this.Controls.Add(this.CBSelectAllMem);
            this.Controls.Add(this.CLBMembers);
            this.Controls.Add(this.RBExceptionAbsence);
            this.Controls.Add(this.RBGroup);
            this.Controls.Add(this.RBAge);
            this.Controls.Add(this.RBDate);
            this.Controls.Add(this.RBName);
            this.Name = "Form1";
            this.Text = "Studenten";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBName;
        private System.Windows.Forms.RadioButton RBDate;
        private System.Windows.Forms.RadioButton RBAge;
        private System.Windows.Forms.RadioButton RBExceptionAbsence;
        private System.Windows.Forms.RadioButton RBGroup;
        private System.Windows.Forms.CheckedListBox CLBMembers;
        private System.Windows.Forms.CheckBox CBSelectAllMem;
        private System.Windows.Forms.ComboBox CBApplyTemplate;
        private System.Windows.Forms.Button BApplyTemplate;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTill;
        private System.Windows.Forms.TextBox TBContains;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Label LApplyTemplate;
        private System.Windows.Forms.Label LFrom;
        private System.Windows.Forms.Label LUntill;
        private System.Windows.Forms.Label LContains;
        private System.Windows.Forms.Label LStudents;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.TextBox TBFrom;
        private System.Windows.Forms.TextBox TBTill;
        private System.Windows.Forms.Label LGroups;
        private System.Windows.Forms.CheckedListBox CLBGroups;
        private System.Windows.Forms.Button bAddColumn;
        private System.Windows.Forms.CheckBox CBSelectAllGro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CBSelectAllColumns;
        private System.Windows.Forms.CheckedListBox CLBColumns;
        private System.Windows.Forms.ListBox LBTables;
        private System.Windows.Forms.Button bAddSpecifier;
    }
}

