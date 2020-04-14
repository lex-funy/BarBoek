namespace BarBoekRegistratie
{
    partial class Home
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
            this.btnRegistratie = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistratie
            // 
            this.btnRegistratie.Location = new System.Drawing.Point(1024, 71);
            this.btnRegistratie.Name = "btnRegistratie";
            this.btnRegistratie.Size = new System.Drawing.Size(105, 46);
            this.btnRegistratie.TabIndex = 0;
            this.btnRegistratie.Text = "Aanmelden";
            this.btnRegistratie.UseVisualStyleBackColor = true;
            this.btnRegistratie.Click += new System.EventHandler(this.btnRegistratie_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(441, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(715, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 22);
            this.textBox2.TabIndex = 2;
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(888, 71);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(105, 46);
            this.btnInloggen.TabIndex = 3;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRegistratie);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistratie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

