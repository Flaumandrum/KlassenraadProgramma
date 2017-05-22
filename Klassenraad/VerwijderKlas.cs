using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Klassenraad
{
    public partial class VerwijderKlas : Form
    {
        public VerwijderKlas()
        {
            InitializeComponent();
            
        }

        // variabelen 
        List<Klas> klaslijst = new List<Klas>();
       

        public void VulCmb()
        {
            foreach (Klas klas in klaslijst)
            {
                if (klas.GetIngepland())
                {
                    cmbVerwijderKlas.Items.Add(klas.GetNaam());
                }                  
                
            }
        }

        private void VerwijderKlas_Load(object sender, EventArgs e)
        {   
            klaslijst = Program.GetLijst();
            VulCmb();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            Program.VerwijderKlas(cmbVerwijderKlas.Text);
            Close();
        }
    }

  
}
