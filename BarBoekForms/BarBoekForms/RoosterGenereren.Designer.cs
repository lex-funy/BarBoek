namespace BarBoekForms
{
    partial class RoosterGenereren
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ComboDate = new System.Windows.Forms.ComboBox();
            this.butgenereren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // ComboDate
            // 
            this.ComboDate.FormattingEnabled = true;
            this.ComboDate.Location = new System.Drawing.Point(25, 78);
            this.ComboDate.Name = "ComboDate";
            this.ComboDate.Size = new System.Drawing.Size(121, 21);
            this.ComboDate.TabIndex = 1;
            // 
            // butgenereren
            // 
            this.butgenereren.Location = new System.Drawing.Point(152, 78);
            this.butgenereren.Name = "butgenereren";
            this.butgenereren.Size = new System.Drawing.Size(75, 23);
            this.butgenereren.TabIndex = 2;
            this.butgenereren.Text = "Genereren";
            this.butgenereren.UseVisualStyleBackColor = true;
            this.butgenereren.Click += new System.EventHandler(this.butgenereren_Click);
            // 
            // RoosterGenereren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butgenereren);
            this.Controls.Add(this.ComboDate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RoosterGenereren";
            this.Text = "RoosterGenereren";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ComboDate;
        private System.Windows.Forms.Button butgenereren;
    }
}