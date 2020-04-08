namespace BarBoekForms
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
            this.butroostergenereer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butroostergenereer
            // 
            this.butroostergenereer.Location = new System.Drawing.Point(13, 13);
            this.butroostergenereer.Name = "butroostergenereer";
            this.butroostergenereer.Size = new System.Drawing.Size(114, 23);
            this.butroostergenereer.TabIndex = 0;
            this.butroostergenereer.Text = "Rooster genereren";
            this.butroostergenereer.UseVisualStyleBackColor = true;
            this.butroostergenereer.Click += new System.EventHandler(this.butroostergenereer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butroostergenereer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butroostergenereer;
    }
}

