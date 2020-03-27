namespace DienstToevoegen
{
    partial class DienstToevoegen
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
            this.BeginDateSelect = new System.Windows.Forms.DateTimePicker();
            this.EndDateSelect = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EndTimeSelect = new System.Windows.Forms.DateTimePicker();
            this.BeginTimeSelect = new System.Windows.Forms.DateTimePicker();
            this.UserAmountSelect = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.EventSelectBox = new System.Windows.Forms.ComboBox();
            this.ToevoegenButton = new System.Windows.Forms.Button();
            this.EventButton = new System.Windows.Forms.CheckBox();
            this.PeriodicityButton = new System.Windows.Forms.CheckBox();
            this.OnceCheckButton = new System.Windows.Forms.CheckBox();
            this.DaysListSelect = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserAmountSelect)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BeginDateSelect
            // 
            this.BeginDateSelect.Enabled = false;
            this.BeginDateSelect.Location = new System.Drawing.Point(10, 38);
            this.BeginDateSelect.Name = "BeginDateSelect";
            this.BeginDateSelect.Size = new System.Drawing.Size(210, 22);
            this.BeginDateSelect.TabIndex = 2;
            this.BeginDateSelect.ValueChanged += new System.EventHandler(this.BeginDateSelect_ValueChanged);
            // 
            // EndDateSelect
            // 
            this.EndDateSelect.Enabled = false;
            this.EndDateSelect.Location = new System.Drawing.Point(247, 38);
            this.EndDateSelect.Name = "EndDateSelect";
            this.EndDateSelect.Size = new System.Drawing.Size(219, 22);
            this.EndDateSelect.TabIndex = 3;
            this.EndDateSelect.ValueChanged += new System.EventHandler(this.EndDateSelect_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Begintijd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eindtijd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Begindatum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Einddatum";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BeginDateSelect);
            this.groupBox1.Controls.Add(this.EndDateSelect);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EndTimeSelect);
            this.groupBox2.Controls.Add(this.BeginTimeSelect);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 73);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // EndTimeSelect
            // 
            this.EndTimeSelect.Enabled = false;
            this.EndTimeSelect.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimeSelect.Location = new System.Drawing.Point(132, 38);
            this.EndTimeSelect.Name = "EndTimeSelect";
            this.EndTimeSelect.Size = new System.Drawing.Size(97, 22);
            this.EndTimeSelect.TabIndex = 7;
            this.EndTimeSelect.ValueChanged += new System.EventHandler(this.EndTimeSelect_ValueChanged);
            // 
            // BeginTimeSelect
            // 
            this.BeginTimeSelect.Enabled = false;
            this.BeginTimeSelect.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BeginTimeSelect.Location = new System.Drawing.Point(10, 38);
            this.BeginTimeSelect.Name = "BeginTimeSelect";
            this.BeginTimeSelect.Size = new System.Drawing.Size(97, 22);
            this.BeginTimeSelect.TabIndex = 6;
            this.BeginTimeSelect.ValueChanged += new System.EventHandler(this.BeginTimeSelect_ValueChanged);
            // 
            // UserAmountSelect
            // 
            this.UserAmountSelect.Enabled = false;
            this.UserAmountSelect.Location = new System.Drawing.Point(18, 419);
            this.UserAmountSelect.Name = "UserAmountSelect";
            this.UserAmountSelect.Size = new System.Drawing.Size(58, 22);
            this.UserAmountSelect.TabIndex = 10;
            this.UserAmountSelect.ValueChanged += new System.EventHandler(this.UserAmountSelect_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(15, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vrijwilligers nodig";
            // 
            // EventSelectBox
            // 
            this.EventSelectBox.Enabled = false;
            this.EventSelectBox.FormattingEnabled = true;
            this.EventSelectBox.Items.AddRange(new object[] {
            "Voorbeeld",
            "Voorbeeld",
            "Voorbeeld",
            "Voorbeeld"});
            this.EventSelectBox.Location = new System.Drawing.Point(201, 33);
            this.EventSelectBox.Name = "EventSelectBox";
            this.EventSelectBox.Size = new System.Drawing.Size(121, 24);
            this.EventSelectBox.TabIndex = 13;
            this.EventSelectBox.SelectedIndexChanged += new System.EventHandler(this.EventSelectBox_SelectedIndexChanged);
            // 
            // ToevoegenButton
            // 
            this.ToevoegenButton.Location = new System.Drawing.Point(609, 466);
            this.ToevoegenButton.Name = "ToevoegenButton";
            this.ToevoegenButton.Size = new System.Drawing.Size(107, 29);
            this.ToevoegenButton.TabIndex = 14;
            this.ToevoegenButton.Text = "Toevoegen";
            this.ToevoegenButton.UseVisualStyleBackColor = true;
            this.ToevoegenButton.Click += new System.EventHandler(this.ToevoegenButton_Click);
            // 
            // EventButton
            // 
            this.EventButton.AutoSize = true;
            this.EventButton.Location = new System.Drawing.Point(201, 6);
            this.EventButton.Name = "EventButton";
            this.EventButton.Size = new System.Drawing.Size(101, 21);
            this.EventButton.TabIndex = 15;
            this.EventButton.Text = "Evenement";
            this.EventButton.UseVisualStyleBackColor = true;
            this.EventButton.CheckedChanged += new System.EventHandler(this.EventButton_CheckedChanged);
            // 
            // PeriodicityButton
            // 
            this.PeriodicityButton.AutoSize = true;
            this.PeriodicityButton.Location = new System.Drawing.Point(106, 6);
            this.PeriodicityButton.Name = "PeriodicityButton";
            this.PeriodicityButton.Size = new System.Drawing.Size(89, 21);
            this.PeriodicityButton.TabIndex = 16;
            this.PeriodicityButton.Text = "Periodiek";
            this.PeriodicityButton.UseVisualStyleBackColor = true;
            this.PeriodicityButton.CheckedChanged += new System.EventHandler(this.PeriodicityButton_CheckedChanged);
            // 
            // OnceCheckButton
            // 
            this.OnceCheckButton.AutoSize = true;
            this.OnceCheckButton.Location = new System.Drawing.Point(12, 6);
            this.OnceCheckButton.Name = "OnceCheckButton";
            this.OnceCheckButton.Size = new System.Drawing.Size(88, 21);
            this.OnceCheckButton.TabIndex = 17;
            this.OnceCheckButton.Text = "Eenmalig";
            this.OnceCheckButton.UseVisualStyleBackColor = true;
            this.OnceCheckButton.CheckedChanged += new System.EventHandler(this.OnceCheckButton_CheckedChanged);
            // 
            // DaysListSelect
            // 
            this.DaysListSelect.BackColor = System.Drawing.SystemColors.Control;
            this.DaysListSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DaysListSelect.Enabled = false;
            this.DaysListSelect.FormattingEnabled = true;
            this.DaysListSelect.Items.AddRange(new object[] {
            "Maandag",
            "Dinsdag",
            "Woensdag",
            "Donderdag",
            "Vrijdag",
            "Zaterdag",
            "Zondag"});
            this.DaysListSelect.Location = new System.Drawing.Point(6, 21);
            this.DaysListSelect.Name = "DaysListSelect";
            this.DaysListSelect.Size = new System.Drawing.Size(106, 119);
            this.DaysListSelect.TabIndex = 19;
            this.DaysListSelect.SelectedIndexChanged += new System.EventHandler(this.DaysListSelect_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DaysListSelect);
            this.groupBox3.Location = new System.Drawing.Point(12, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 150);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // DienstToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 502);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.OnceCheckButton);
            this.Controls.Add(this.PeriodicityButton);
            this.Controls.Add(this.EventButton);
            this.Controls.Add(this.ToevoegenButton);
            this.Controls.Add(this.EventSelectBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserAmountSelect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DienstToevoegen";
            this.Text = "Dienst Toevoegen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserAmountSelect)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker BeginDateSelect;
        private System.Windows.Forms.DateTimePicker EndDateSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown UserAmountSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EventSelectBox;
        private System.Windows.Forms.Button ToevoegenButton;
        private System.Windows.Forms.CheckBox EventButton;
        private System.Windows.Forms.DateTimePicker EndTimeSelect;
        private System.Windows.Forms.DateTimePicker BeginTimeSelect;
        private System.Windows.Forms.CheckBox PeriodicityButton;
        private System.Windows.Forms.CheckBox OnceCheckButton;
        private System.Windows.Forms.CheckedListBox DaysListSelect;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

