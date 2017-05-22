namespace Klassenraad
{
    partial class VerwijderKlas
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
            this.cmbVerwijderKlas = new System.Windows.Forms.ComboBox();
            this.lblVerwijderklas = new System.Windows.Forms.Label();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbVerwijderKlas
            // 
            this.cmbVerwijderKlas.FormattingEnabled = true;
            this.cmbVerwijderKlas.Location = new System.Drawing.Point(48, 51);
            this.cmbVerwijderKlas.Name = "cmbVerwijderKlas";
            this.cmbVerwijderKlas.Size = new System.Drawing.Size(121, 21);
            this.cmbVerwijderKlas.TabIndex = 0;
            // 
            // lblVerwijderklas
            // 
            this.lblVerwijderklas.AutoSize = true;
            this.lblVerwijderklas.Location = new System.Drawing.Point(13, 13);
            this.lblVerwijderklas.Name = "lblVerwijderklas";
            this.lblVerwijderklas.Size = new System.Drawing.Size(156, 13);
            this.lblVerwijderklas.TabIndex = 1;
            this.lblVerwijderklas.Text = "Kies een klas om te verwijderen";
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(48, 138);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(121, 23);
            this.btnVerwijder.TabIndex = 2;
            this.btnVerwijder.Text = "Verwijder klas";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // VerwijderKlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 213);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.lblVerwijderklas);
            this.Controls.Add(this.cmbVerwijderKlas);
            this.Name = "VerwijderKlas";
            this.Text = "VerwijderKlas";
            this.Load += new System.EventHandler(this.VerwijderKlas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVerwijderKlas;
        private System.Windows.Forms.Label lblVerwijderklas;
        private System.Windows.Forms.Button btnVerwijder;
    }
}