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
    public partial class VoegKlasToe : Form
    {
        public VoegKlasToe()
        {
            InitializeComponent();
        }

        static List<Klas> klaslijst = new List<Klas>();
        static List<Groep> groeplijst = new List<Groep>();

        private void VoegKlasToe_Load(object sender, EventArgs e)
        {
         
            klaslijst = Program.GetLijst();
            groeplijst = Program.GetGroepen();
            VulCmbKlas();
            VulCmbGroep();

        }

        public void VulCmbKlas()
        {
            foreach (Klas klas in klaslijst)
            {
                
                if(klas.GetIngepland()!=true)
                    {
                    cmbKlassen.Items.Add(klas.GetNaam());
                    }
                 
            }
        }

        public void VulCmbGroep()
        {
            foreach (Groep groep in groeplijst)
            {
               
                cmbGroepen.Items.Add(groep.GetVerantwoordelijke());
                

            }
        }

        //toevoegen van een klas bij de juiste groep
        private void btnPlanKlas_Click(object sender, EventArgs e)
        {
            if (cmbGroepen.Text != null && cmbKlassen != null) 
            {
                String naamGroep = cmbGroepen.Text;
                String klas = cmbKlassen.Text;
                Int32 aantalLln = 12;
                Int32 minPerLln = 5; 

                if(txtAantalLln.Text!= "")
                {
                    aantalLln = Convert.ToInt32(txtAantalLln.Text);
                }
                
                if (txtVoegKlasToeMinutenPerLln.Text!="")
                {
                    minPerLln = Convert.ToInt32(txtVoegKlasToeMinutenPerLln.Text);
                }
                    
                Program.VoegKlasToe(naamGroep, klas, aantalLln, minPerLln);

            Close();
            }
            else
            {
                MessageBox.Show("Vul alle gegevens in");
            }
            

        }

        private void btnTestOverlap_Click(object sender, EventArgs e)
        {
            String naamGroep = cmbGroepen.Text;
            String klas = cmbKlassen.Text;
            Int32 aantalLln = 0;
            Int32 minPerLln = 0;
            List<Klas> overlap = new List<Klas>();

            if (txtAantalLln.Text != "")
            {
                aantalLln = Convert.ToInt32(txtAantalLln.Text);
            }

            if (txtVoegKlasToeMinutenPerLln.Text != "")
            {
                minPerLln = Convert.ToInt32(txtVoegKlasToeMinutenPerLln.Text);
            }

         

            string antwoord =  Program.Vergelijkklassen(naamGroep, klas, aantalLln, minPerLln);



            

            MessageBox.Show(antwoord);
        }

        private void cmbKlassen_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Klas k in klaslijst)
            {
                if (cmbKlassen.SelectedItem==k.GetNaam())
                {
                    txtAantalLln.Text =Convert.ToString(k.GetAantalLeerlingen());
                }
            }
            
        }
    }
}
