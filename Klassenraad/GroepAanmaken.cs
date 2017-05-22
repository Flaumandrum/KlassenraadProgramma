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
    public partial class GroepAanmaken : Form
    {
        public GroepAanmaken()
        {
            InitializeComponent();
        }

        private void btnAanmakenGroep_Click(object sender, EventArgs e)
        {
            Int32 uur;
            Int32 min;
            string naamVerantwoordelijke = txtGroepsverantwoordelijke.Text;

            if (cmbUur.SelectedItem == null || cmbMin.SelectedItem == null)
            {


                MessageBox.Show("Vul eerst een start uur in");
            }
            else
            {
                uur = Convert.ToInt32(cmbUur.SelectedItem);
                min = Convert.ToInt32(cmbMin.SelectedItem);
 
                Program.AddGroep(naamVerantwoordelijke, uur, min);
                Close();
            }
           

        }

        // zorg dat de groep wordt aangemaakt indien er op enter wordt gedrukt
        private void txtGroepsverantwoordelijke_KeyDown(object sender, KeyEventArgs e)
        {
            
            


                if (e.KeyCode == Keys.Enter)
                {
                    

                        btnAanmakenGroep_Click(this, new EventArgs());
                    
                }
            
        }
    }
}
