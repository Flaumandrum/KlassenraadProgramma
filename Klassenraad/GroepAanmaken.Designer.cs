namespace Klassenraad
{
    partial class GroepAanmaken
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
            this.lblGroepsverantwoordelijke = new System.Windows.Forms.Label();
            this.txtGroepsverantwoordelijke = new System.Windows.Forms.TextBox();
            this.btnAanmakenGroep = new System.Windows.Forms.Button();
            this.cmbUur = new System.Windows.Forms.ComboBox();
            this.cmbMin = new System.Windows.Forms.ComboBox();
            this.lblTekstBeginuur = new System.Windows.Forms.Label();
            this.lblUur = new System.Windows.Forms.Label();
            this.lblMinuten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGroepsverantwoordelijke
            // 
            this.lblGroepsverantwoordelijke.AutoSize = true;
            this.lblGroepsverantwoordelijke.Location = new System.Drawing.Point(13, 41);
            this.lblGroepsverantwoordelijke.Name = "lblGroepsverantwoordelijke";
            this.lblGroepsverantwoordelijke.Size = new System.Drawing.Size(195, 13);
            this.lblGroepsverantwoordelijke.TabIndex = 0;
            this.lblGroepsverantwoordelijke.Text = "Geef naam de groepsverantwoordelijke:";
            // 
            // txtGroepsverantwoordelijke
            // 
            this.txtGroepsverantwoordelijke.Location = new System.Drawing.Point(16, 74);
            this.txtGroepsverantwoordelijke.Name = "txtGroepsverantwoordelijke";
            this.txtGroepsverantwoordelijke.Size = new System.Drawing.Size(183, 20);
            this.txtGroepsverantwoordelijke.TabIndex = 1;
            this.txtGroepsverantwoordelijke.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGroepsverantwoordelijke_KeyDown);
            // 
            // btnAanmakenGroep
            // 
            this.btnAanmakenGroep.Location = new System.Drawing.Point(16, 217);
            this.btnAanmakenGroep.Name = "btnAanmakenGroep";
            this.btnAanmakenGroep.Size = new System.Drawing.Size(183, 23);
            this.btnAanmakenGroep.TabIndex = 2;
            this.btnAanmakenGroep.Text = "Groep Aanmaken";
            this.btnAanmakenGroep.UseVisualStyleBackColor = true;
            this.btnAanmakenGroep.Click += new System.EventHandler(this.btnAanmakenGroep_Click);
            // 
            // cmbUur
            // 
            this.cmbUur.FormattingEnabled = true;
            this.cmbUur.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cmbUur.Location = new System.Drawing.Point(93, 136);
            this.cmbUur.Name = "cmbUur";
            this.cmbUur.Size = new System.Drawing.Size(60, 21);
            this.cmbUur.TabIndex = 3;
            // 
            // cmbMin
            // 
            this.cmbMin.FormattingEnabled = true;
            this.cmbMin.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cmbMin.Location = new System.Drawing.Point(93, 163);
            this.cmbMin.Name = "cmbMin";
            this.cmbMin.Size = new System.Drawing.Size(60, 21);
            this.cmbMin.TabIndex = 4;
            // 
            // lblTekstBeginuur
            // 
            this.lblTekstBeginuur.AutoSize = true;
            this.lblTekstBeginuur.Location = new System.Drawing.Point(16, 112);
            this.lblTekstBeginuur.Name = "lblTekstBeginuur";
            this.lblTekstBeginuur.Size = new System.Drawing.Size(203, 13);
            this.lblTekstBeginuur.TabIndex = 5;
            this.lblTekstBeginuur.Text = "Geef het uur in waarop deze groep begint";
            // 
            // lblUur
            // 
            this.lblUur.AutoSize = true;
            this.lblUur.Location = new System.Drawing.Point(35, 139);
            this.lblUur.Name = "lblUur";
            this.lblUur.Size = new System.Drawing.Size(25, 13);
            this.lblUur.TabIndex = 6;
            this.lblUur.Text = "uur:";
            // 
            // lblMinuten
            // 
            this.lblMinuten.AutoSize = true;
            this.lblMinuten.Location = new System.Drawing.Point(35, 166);
            this.lblMinuten.Name = "lblMinuten";
            this.lblMinuten.Size = new System.Drawing.Size(47, 13);
            this.lblMinuten.TabIndex = 7;
            this.lblMinuten.Text = "minuten:";
            // 
            // GroepAanmaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 252);
            this.Controls.Add(this.lblMinuten);
            this.Controls.Add(this.lblUur);
            this.Controls.Add(this.lblTekstBeginuur);
            this.Controls.Add(this.cmbMin);
            this.Controls.Add(this.cmbUur);
            this.Controls.Add(this.btnAanmakenGroep);
            this.Controls.Add(this.txtGroepsverantwoordelijke);
            this.Controls.Add(this.lblGroepsverantwoordelijke);
            this.Name = "GroepAanmaken";
            this.Text = "GroepAanmaken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroepsverantwoordelijke;
        private System.Windows.Forms.TextBox txtGroepsverantwoordelijke;
        private System.Windows.Forms.Button btnAanmakenGroep;
        private System.Windows.Forms.ComboBox cmbUur;
        private System.Windows.Forms.ComboBox cmbMin;
        private System.Windows.Forms.Label lblTekstBeginuur;
        private System.Windows.Forms.Label lblUur;
        private System.Windows.Forms.Label lblMinuten;
    }
}