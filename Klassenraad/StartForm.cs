using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klassenraad.Klasses;


namespace Klassenraad
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            Program.VulLijst();
        }

        //laat groepen toevoegen en pas het scherm aan
        private void btnKeuzemenuStap1_Click(object sender, EventArgs e)
        {
            GroepAanmaken GroepScherm = new GroepAanmaken();
            GroepScherm.ShowDialog();
            GroepScherm = null;
            lblPlaning.Text = Program.PasSchermAan();

        }

        private void btnKeuzemenuStap2_Click(object sender, EventArgs e)
        {
            VoegKlasToe KlasToevoegen = new VoegKlasToe();
            KlasToevoegen.ShowDialog();
            KlasToevoegen = null;
            lblPlaning.Text =Program.PasSchermAan();
           
        }

        private void btnVerwijderKlas_Click(object sender, EventArgs e)
        {
            VerwijderKlas KlasVerwijderen = new VerwijderKlas();
            KlasVerwijderen.ShowDialog();
            KlasVerwijderen = null;
            lblPlaning.Text = Program.PasSchermAan();
        }
    }
}
