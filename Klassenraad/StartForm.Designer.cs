namespace Klassenraad
{
    partial class StartForm
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
            this.lblKeuzemenuWelkomstekst = new System.Windows.Forms.Label();
            this.btnKeuzemenuStap1 = new System.Windows.Forms.Button();
            this.lblPlaning = new System.Windows.Forms.Label();
            this.btnKeuzemenuStap2 = new System.Windows.Forms.Button();
            this.btnVerwijderKlas = new System.Windows.Forms.Button();
            this.lblVerwijderKlas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKeuzemenuWelkomstekst
            // 
            this.lblKeuzemenuWelkomstekst.AutoSize = true;
            this.lblKeuzemenuWelkomstekst.Location = new System.Drawing.Point(13, 13);
            this.lblKeuzemenuWelkomstekst.Name = "lblKeuzemenuWelkomstekst";
            this.lblKeuzemenuWelkomstekst.Size = new System.Drawing.Size(174, 26);
            this.lblKeuzemenuWelkomstekst.TabIndex = 2;
            this.lblKeuzemenuWelkomstekst.Text = "Welkom op de klassenraadplanner.\r\nVolg onderstaand stappenplan:";
            // 
            // btnKeuzemenuStap1
            // 
            this.btnKeuzemenuStap1.Location = new System.Drawing.Point(42, 79);
            this.btnKeuzemenuStap1.Name = "btnKeuzemenuStap1";
            this.btnKeuzemenuStap1.Size = new System.Drawing.Size(191, 23);
            this.btnKeuzemenuStap1.TabIndex = 3;
            this.btnKeuzemenuStap1.Text = "Stap1: Maak een nieuwe groep aan";
            this.btnKeuzemenuStap1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeuzemenuStap1.UseVisualStyleBackColor = true;
            this.btnKeuzemenuStap1.Click += new System.EventHandler(this.btnKeuzemenuStap1_Click);
            // 
            // lblPlaning
            // 
            this.lblPlaning.AutoSize = true;
            this.lblPlaning.Location = new System.Drawing.Point(307, 25);
            this.lblPlaning.Name = "lblPlaning";
            this.lblPlaning.Size = new System.Drawing.Size(51, 13);
            this.lblPlaning.TabIndex = 4;
            this.lblPlaning.Text = "Planning:";
            // 
            // btnKeuzemenuStap2
            // 
            this.btnKeuzemenuStap2.Location = new System.Drawing.Point(42, 121);
            this.btnKeuzemenuStap2.Name = "btnKeuzemenuStap2";
            this.btnKeuzemenuStap2.Size = new System.Drawing.Size(191, 23);
            this.btnKeuzemenuStap2.TabIndex = 5;
            this.btnKeuzemenuStap2.Text = "Stap 2: Voeg een klas toe";
            this.btnKeuzemenuStap2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeuzemenuStap2.UseVisualStyleBackColor = true;
            this.btnKeuzemenuStap2.Click += new System.EventHandler(this.btnKeuzemenuStap2_Click);
            // 
            // btnVerwijderKlas
            // 
            this.btnVerwijderKlas.Location = new System.Drawing.Point(42, 222);
            this.btnVerwijderKlas.Name = "btnVerwijderKlas";
            this.btnVerwijderKlas.Size = new System.Drawing.Size(191, 23);
            this.btnVerwijderKlas.TabIndex = 6;
            this.btnVerwijderKlas.Text = "Verwijder een klas";
            this.btnVerwijderKlas.UseVisualStyleBackColor = true;
            this.btnVerwijderKlas.Click += new System.EventHandler(this.btnVerwijderKlas_Click);
            // 
            // lblVerwijderKlas
            // 
            this.lblVerwijderKlas.AutoSize = true;
            this.lblVerwijderKlas.Location = new System.Drawing.Point(13, 189);
            this.lblVerwijderKlas.Name = "lblVerwijderKlas";
            this.lblVerwijderKlas.Size = new System.Drawing.Size(186, 13);
            this.lblVerwijderKlas.TabIndex = 7;
            this.lblVerwijderKlas.Text = "Eventueel kan je klassen verwijderen:";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 411);
            this.Controls.Add(this.lblVerwijderKlas);
            this.Controls.Add(this.btnVerwijderKlas);
            this.Controls.Add(this.btnKeuzemenuStap2);
            this.Controls.Add(this.lblPlaning);
            this.Controls.Add(this.btnKeuzemenuStap1);
            this.Controls.Add(this.lblKeuzemenuWelkomstekst);
            this.Name = "StartForm";
            this.Text = "Keuze menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKeuzemenuWelkomstekst;
        private System.Windows.Forms.Button btnKeuzemenuStap1;
        private System.Windows.Forms.Label lblPlaning;
        private System.Windows.Forms.Button btnKeuzemenuStap2;
        private System.Windows.Forms.Button btnVerwijderKlas;
        private System.Windows.Forms.Label lblVerwijderKlas;
    }
}

