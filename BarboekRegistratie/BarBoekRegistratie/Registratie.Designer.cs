namespace BarBoekRegistratie
{
    partial class Registratie
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVnaam = new System.Windows.Forms.TextBox();
            this.txtContactpersoon = new System.Windows.Forms.TextBox();
            this.txtStraat = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtPlaats = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbDemo = new System.Windows.Forms.RadioButton();
            this.rbJaar = new System.Windows.Forms.RadioButton();
            this.btnRegistreren = new System.Windows.Forms.Button();
            this.txtOpmerking = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.linkTerug = new System.Windows.Forms.LinkLabel();
            this.txtBnr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vereniging Registreren";
            // 
            // txtVnaam
            // 
            this.txtVnaam.Location = new System.Drawing.Point(103, 207);
            this.txtVnaam.Name = "txtVnaam";
            this.txtVnaam.Size = new System.Drawing.Size(180, 22);
            this.txtVnaam.TabIndex = 1;
            // 
            // txtContactpersoon
            // 
            this.txtContactpersoon.Location = new System.Drawing.Point(103, 280);
            this.txtContactpersoon.Name = "txtContactpersoon";
            this.txtContactpersoon.Size = new System.Drawing.Size(180, 22);
            this.txtContactpersoon.TabIndex = 2;
            this.txtContactpersoon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactpersoon_KeyPress);
            // 
            // txtStraat
            // 
            this.txtStraat.Location = new System.Drawing.Point(103, 358);
            this.txtStraat.Name = "txtStraat";
            this.txtStraat.Size = new System.Drawing.Size(180, 22);
            this.txtStraat.TabIndex = 3;
            this.txtStraat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStraat_KeyPress);
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(103, 432);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(180, 22);
            this.txtPostcode.TabIndex = 4;
            this.txtPostcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostcode_KeyPress);
            // 
            // txtPlaats
            // 
            this.txtPlaats.Location = new System.Drawing.Point(103, 503);
            this.txtPlaats.Name = "txtPlaats";
            this.txtPlaats.Size = new System.Drawing.Size(180, 22);
            this.txtPlaats.TabIndex = 5;
            this.txtPlaats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaats_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 569);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // rbDemo
            // 
            this.rbDemo.AutoSize = true;
            this.rbDemo.Location = new System.Drawing.Point(572, 254);
            this.rbDemo.Name = "rbDemo";
            this.rbDemo.Size = new System.Drawing.Size(123, 21);
            this.rbDemo.TabIndex = 7;
            this.rbDemo.TabStop = true;
            this.rbDemo.Text = "1 maand demo";
            this.rbDemo.UseVisualStyleBackColor = true;
            // 
            // rbJaar
            // 
            this.rbJaar.AutoSize = true;
            this.rbJaar.Location = new System.Drawing.Point(572, 281);
            this.rbJaar.Name = "rbJaar";
            this.rbJaar.Size = new System.Drawing.Size(254, 21);
            this.rbJaar.TabIndex = 8;
            this.rbJaar.TabStop = true;
            this.rbJaar.Text = "Jaarabonnement(à 172, -excl BTW)";
            this.rbJaar.UseVisualStyleBackColor = true;
            // 
            // btnRegistreren
            // 
            this.btnRegistreren.Location = new System.Drawing.Point(697, 539);
            this.btnRegistreren.Name = "btnRegistreren";
            this.btnRegistreren.Size = new System.Drawing.Size(99, 40);
            this.btnRegistreren.TabIndex = 10;
            this.btnRegistreren.Text = "Registreren";
            this.btnRegistreren.UseVisualStyleBackColor = true;
            this.btnRegistreren.Click += new System.EventHandler(this.btnRegistreren_Click);
            // 
            // txtOpmerking
            // 
            this.txtOpmerking.Location = new System.Drawing.Point(572, 358);
            this.txtOpmerking.Name = "txtOpmerking";
            this.txtOpmerking.Size = new System.Drawing.Size(268, 134);
            this.txtOpmerking.TabIndex = 11;
            this.txtOpmerking.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Naam vereniging*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contactpersoon*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Straat*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Postcode*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Plaats*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "E-mail*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Opmerking";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(569, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Verenigingstype";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(569, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Aanmelden voor:";
            // 
            // linkTerug
            // 
            this.linkTerug.AutoSize = true;
            this.linkTerug.Location = new System.Drawing.Point(12, 21);
            this.linkTerug.Name = "linkTerug";
            this.linkTerug.Size = new System.Drawing.Size(54, 17);
            this.linkTerug.TabIndex = 21;
            this.linkTerug.TabStop = true;
            this.linkTerug.Text = "<Terug";
            this.linkTerug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTerug_LinkClicked);
            // 
            // txtBnr
            // 
            this.txtBnr.Location = new System.Drawing.Point(103, 639);
            this.txtBnr.MaxLength = 6;
            this.txtBnr.Name = "txtBnr";
            this.txtBnr.Size = new System.Drawing.Size(180, 22);
            this.txtBnr.TabIndex = 22;
            this.txtBnr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBnr_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 619);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Bondnummer*";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(314, 358);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 22);
            this.txtAdd.TabIndex = 24;
            this.txtAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdd_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(311, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Toevoeging";
            // 
            // Registratie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 742);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBnr);
            this.Controls.Add(this.linkTerug);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOpmerking);
            this.Controls.Add(this.btnRegistreren);
            this.Controls.Add(this.rbJaar);
            this.Controls.Add(this.rbDemo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPlaats);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtStraat);
            this.Controls.Add(this.txtContactpersoon);
            this.Controls.Add(this.txtVnaam);
            this.Controls.Add(this.label1);
            this.Name = "Registratie";
            this.Text = "Registratir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVnaam;
        private System.Windows.Forms.TextBox txtContactpersoon;
        private System.Windows.Forms.TextBox txtStraat;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtPlaats;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rbDemo;
        private System.Windows.Forms.RadioButton rbJaar;
        private System.Windows.Forms.Button btnRegistreren;
        private System.Windows.Forms.RichTextBox txtOpmerking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkTerug;
        private System.Windows.Forms.TextBox txtBnr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label12;
    }
}