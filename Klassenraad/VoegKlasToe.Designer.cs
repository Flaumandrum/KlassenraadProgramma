namespace Klassenraad
{
    partial class VoegKlasToe
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
            this.cmbGroepen = new System.Windows.Forms.ComboBox();
            this.cmbKlassen = new System.Windows.Forms.ComboBox();
            this.lblKiesGroep = new System.Windows.Forms.Label();
            this.lblKiesKlas = new System.Windows.Forms.Label();
            this.btnTestOverlap = new System.Windows.Forms.Button();
            this.lblTestOverlap = new System.Windows.Forms.Label();
            this.lblPlanKlas = new System.Windows.Forms.Label();
            this.btnPlanKlas = new System.Windows.Forms.Button();
            this.lblAantalLln = new System.Windows.Forms.Label();
            this.txtAantalLln = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoegKlasToeMinutenPerLln = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbGroepen
            // 
            this.cmbGroepen.FormattingEnabled = true;
            this.cmbGroepen.Location = new System.Drawing.Point(132, 41);
            this.cmbGroepen.Name = "cmbGroepen";
            this.cmbGroepen.Size = new System.Drawing.Size(121, 21);
            this.cmbGroepen.TabIndex = 0;
            // 
            // cmbKlassen
            // 
            this.cmbKlassen.FormattingEnabled = true;
            this.cmbKlassen.Location = new System.Drawing.Point(132, 89);
            this.cmbKlassen.Name = "cmbKlassen";
            this.cmbKlassen.Size = new System.Drawing.Size(121, 21);
            this.cmbKlassen.TabIndex = 1;
            this.cmbKlassen.SelectedIndexChanged += new System.EventHandler(this.cmbKlassen_SelectedIndexChanged);
            // 
            // lblKiesGroep
            // 
            this.lblKiesGroep.AutoSize = true;
            this.lblKiesGroep.Location = new System.Drawing.Point(12, 44);
            this.lblKiesGroep.Name = "lblKiesGroep";
            this.lblKiesGroep.Size = new System.Drawing.Size(101, 13);
            this.lblKiesGroep.TabIndex = 2;
            this.lblKiesGroep.Text = "Kies hier een groep:";
            // 
            // lblKiesKlas
            // 
            this.lblKiesKlas.AutoSize = true;
            this.lblKiesKlas.Location = new System.Drawing.Point(12, 92);
            this.lblKiesKlas.Name = "lblKiesKlas";
            this.lblKiesKlas.Size = new System.Drawing.Size(94, 13);
            this.lblKiesKlas.TabIndex = 3;
            this.lblKiesKlas.Text = "Kies hier een Klas:";
            // 
            // btnTestOverlap
            // 
            this.btnTestOverlap.Location = new System.Drawing.Point(132, 230);
            this.btnTestOverlap.Name = "btnTestOverlap";
            this.btnTestOverlap.Size = new System.Drawing.Size(121, 23);
            this.btnTestOverlap.TabIndex = 4;
            this.btnTestOverlap.Text = "Test";
            this.btnTestOverlap.UseVisualStyleBackColor = true;
            this.btnTestOverlap.Click += new System.EventHandler(this.btnTestOverlap_Click);
            // 
            // lblTestOverlap
            // 
            this.lblTestOverlap.AutoSize = true;
            this.lblTestOverlap.Location = new System.Drawing.Point(12, 235);
            this.lblTestOverlap.Name = "lblTestOverlap";
            this.lblTestOverlap.Size = new System.Drawing.Size(115, 13);
            this.lblTestOverlap.TabIndex = 5;
            this.lblTestOverlap.Text = "Test hier overlapingen:";
            // 
            // lblPlanKlas
            // 
            this.lblPlanKlas.AutoSize = true;
            this.lblPlanKlas.Location = new System.Drawing.Point(12, 273);
            this.lblPlanKlas.Name = "lblPlanKlas";
            this.lblPlanKlas.Size = new System.Drawing.Size(114, 13);
            this.lblPlanKlas.TabIndex = 6;
            this.lblPlanKlas.Text = "Definitief klas plannen:";
            // 
            // btnPlanKlas
            // 
            this.btnPlanKlas.Location = new System.Drawing.Point(132, 268);
            this.btnPlanKlas.Name = "btnPlanKlas";
            this.btnPlanKlas.Size = new System.Drawing.Size(121, 23);
            this.btnPlanKlas.TabIndex = 7;
            this.btnPlanKlas.Text = "Plannen";
            this.btnPlanKlas.UseVisualStyleBackColor = true;
            this.btnPlanKlas.Click += new System.EventHandler(this.btnPlanKlas_Click);
            // 
            // lblAantalLln
            // 
            this.lblAantalLln.AutoSize = true;
            this.lblAantalLln.Location = new System.Drawing.Point(12, 144);
            this.lblAantalLln.Name = "lblAantalLln";
            this.lblAantalLln.Size = new System.Drawing.Size(69, 13);
            this.lblAantalLln.TabIndex = 8;
            this.lblAantalLln.Text = "Hoeveel lln ?";
            // 
            // txtAantalLln
            // 
            this.txtAantalLln.Location = new System.Drawing.Point(132, 141);
            this.txtAantalLln.Name = "txtAantalLln";
            this.txtAantalLln.Size = new System.Drawing.Size(121, 20);
            this.txtAantalLln.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Minuten per leerling:";
            // 
            // txtVoegKlasToeMinutenPerLln
            // 
            this.txtVoegKlasToeMinutenPerLln.Location = new System.Drawing.Point(132, 187);
            this.txtVoegKlasToeMinutenPerLln.Name = "txtVoegKlasToeMinutenPerLln";
            this.txtVoegKlasToeMinutenPerLln.Size = new System.Drawing.Size(121, 20);
            this.txtVoegKlasToeMinutenPerLln.TabIndex = 11;
            this.txtVoegKlasToeMinutenPerLln.Text = "3";
            // 
            // VoegKlasToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 333);
            this.Controls.Add(this.txtVoegKlasToeMinutenPerLln);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAantalLln);
            this.Controls.Add(this.lblAantalLln);
            this.Controls.Add(this.btnPlanKlas);
            this.Controls.Add(this.lblPlanKlas);
            this.Controls.Add(this.lblTestOverlap);
            this.Controls.Add(this.btnTestOverlap);
            this.Controls.Add(this.lblKiesKlas);
            this.Controls.Add(this.lblKiesGroep);
            this.Controls.Add(this.cmbKlassen);
            this.Controls.Add(this.cmbGroepen);
            this.Name = "VoegKlasToe";
            this.Text = "VoegKlasToe";
            this.Load += new System.EventHandler(this.VoegKlasToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGroepen;
        private System.Windows.Forms.ComboBox cmbKlassen;
        private System.Windows.Forms.Label lblKiesGroep;
        private System.Windows.Forms.Label lblKiesKlas;
        private System.Windows.Forms.Button btnTestOverlap;
        private System.Windows.Forms.Label lblTestOverlap;
        private System.Windows.Forms.Label lblPlanKlas;
        private System.Windows.Forms.Button btnPlanKlas;
        private System.Windows.Forms.Label lblAantalLln;
        private System.Windows.Forms.TextBox txtAantalLln;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVoegKlasToeMinutenPerLln;
    }
}