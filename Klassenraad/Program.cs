using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

using Classes;


namespace Klassenraad
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }

        // Programma voor het inroosteren van klassenraden
        // start 03/02/2017
        // Tom Adriaens


        // Velden
        static List<Klas> lijst = new List<Klas>();
        static List<Groep> GeplandeGroepen = new List<Groep>();
        
        


        //vul de lijst met klassen
        static public void VulLijst()
        {
            DBKlassenraad datab = new DBKlassenraad();

            lijst = datab.GetKlassen();
                                

        }

        // return de lijst met alle klassen
        static public List<Klas> GetLijst()
        {
            return lijst;
        }

        //return de list van geplandeGroepen
        static public List<Groep> GetGroepen()
        {
            return GeplandeGroepen;
        }

        //voegt een nieuwe groep toe aan de lijst
        static public void  AddGroep(string groepsnaam, Int32 beginuur, Int32 min)
        {
           
            Groep nieuweGroep = new Groep(groepsnaam, beginuur, min);
            GeplandeGroepen.Add(nieuweGroep);

        }
        
        // maakt de tekst aan die onder planning wordt getoond.
        static public string PasSchermAan()
        {
            String tekstOmTeTonen = "";
            foreach (Groep groep in GeplandeGroepen)
            {
                tekstOmTeTonen += "\n"+groep.GetVerantwoordelijke() + "   Start om: " + groep.GetTekstUurVolledig();
                tekstOmTeTonen += "\n          Klas     #lln     beginuur     einduur";
                List<Klas> klassen = new List<Klas>();
                klassen=groep.GetKlassen();
                foreach (Klas klas in klassen)
                {
                    Int32 lengteKlasnaam = klas.GetNaam().Length;
                    string spaties = "      ";
                    if(lengteKlasnaam > 3)
                    {
                        spaties = spaties.Substring(0, (spaties.Length - (lengteKlasnaam - 3)));
                    }
                    tekstOmTeTonen += "\n          " + klas.GetNaam() + spaties + klas.GetAantalLeerlingen()+"      "+ klas.GetTekstBeginuur() + "         " + klas.GetTekstEinduur();
                }
                tekstOmTeTonen += "\n";
            }
            return tekstOmTeTonen;
        }

        // klas toevoegen in de juiste groep
        static public void VoegKlasToe(string groepsnaam, string klasnaam, Int32 aantalLln, Int32 aantalMin)
        {
            // loop alle geplande groepen af om de juiste te vinden
            Int32 indexGroep =-1;
            Int32 indexKlas;
            Int32 beginuur= 0;
            Int32 beginmin =0;
            
                //GeplandeGroepen.FindIndex(g => g.GetVerantwoordelijke.Equals(groepsnaam));
            foreach (Groep g in GeplandeGroepen)
            {
                // loop alle klassen af om de juiste te vinden en deze toe te voegen.
                if (g.GetVerantwoordelijke()== groepsnaam)
                {
                    // sla de index van deze groep in de lijst op
                    indexGroep = GeplandeGroepen.IndexOf(g);

                    // sla de getal vorm van het beginuur en de begin minuten van deze groep op
                    beginuur = g.GetUur();
                    beginmin = g.GetMin();
                   
                }

            }

            // loop door alle klassen in de lijst
            foreach (Klas k in lijst)
            {
                // neem de klas met de juiste naam
             if (k.GetNaam() == klasnaam)
                {
                    
                    // voeg het juiste aantal LLn toe bij de klas k
                    k.SetLlnAantal(aantalLln);

                    // verander het aantal minuten 
                    k.SetMinutenPerLeerling(aantalMin);
                    //neem de index
                    indexKlas = lijst.IndexOf(k);

                    

                    //en verander waarde van ingepland in de lijst met klassen.
                    lijst[indexKlas].SetIngepland();

                    //neem een lijst met de klassen uit de geplande geselecteerde groep
                    List<Klas> klassenGroep = new List<Klas>();
                    klassenGroep = GeplandeGroepen[indexGroep].GetKlassen();

                    //verander het uur
                    if (klassenGroep.Count() == 0)
                    {// als de klas de eerst is neemt ze het beginuur van de groep over
                        k.SetUurenMin(beginuur, beginmin);
                        

                    }
                    else
                    { // als de klas niet de eerste is, neemt ze het eind uur van de vorige klas over
                        indexKlas = (klassenGroep.Count()-1);                     
                        k.SetBeginduur(klassenGroep[(indexKlas)].GetEinduur());

                    }

                    //verander het einduur van de klas
                    k.BerekenEinduur();
                    
                    
                    //voeg toe bij de juiste groep 
                    GeplandeGroepen[indexGroep].AddKlas(k);
                }

            }                 
        }

        //klas verwijderen
        static public void VerwijderKlas(string klasnaam)
        {
            Int32 indexGroep = -1;
            Int32 indexKlas = -1;
            Int32 indexKlasGroep = -1;
            Int32 groepsIndex = -1;
            Int32 beginuur = 0;
            Int32 beginmin = 0;
            List<Klas> groepsLijst = new List<Klas>();

            foreach (Groep g in GeplandeGroepen)
            {
              
              groepsLijst = g.GetKlassen();
                // loop door alle klassen in de lijst
                if (groepsLijst.Count() >= 0)
                {


                    foreach (Klas k in groepsLijst)
                    {
                        indexKlasGroep = groepsLijst.IndexOf(k);
                        // neem de klas met de juiste naam
                        if (k.GetNaam() == klasnaam)
                        {
                            //neem de index, voeg toe bij de juiste groep en verander waarde van ingepland in de lijst met klassen.
                            indexGroep = GeplandeGroepen.IndexOf(g);
                            indexKlas = lijst.IndexOf(k);
                            groepsIndex = groepsLijst.IndexOf(k);

                            //verander de waarde van ingepland in de lijst
                            lijst[indexKlas].SetIngepland();
                            //verwijder klas uit groep
                            GeplandeGroepen[indexGroep].Verwijder(indexKlasGroep);

                            //de uren van de klassen aanpassen
                            groepsLijst = g.GetKlassen();
                            beginuur = g.GetUur();
                            beginmin = g.GetMin();
                            foreach (Klas kl in groepsLijst)
                            {
                                if (groepsLijst.IndexOf(kl) == 0)
                                {// als de klaslijst l de eerst is neemt ze het beginuur van de groep over
                                    kl.SetUurenMin(beginuur, beginmin);


                                }

                                else
                               { // als de klas niet de eerste is, neemt ze het eind uur van de vorige klas over
                                     indexKlas = (groepsLijst.IndexOf(kl) - 1);
                                    kl.SetBeginduur(groepsLijst[(indexKlas)].GetEinduur());

                                }
                                kl.BerekenEinduur();
                            }

                            GeplandeGroepen[indexGroep].SetGeplandeKlassen(groepsLijst);
                            break;

                        }


                    
                    
                    }
                }

            }
        }

        //Klas vergelijken
        static public string Vergelijkklassen(string groepsnaam, string klasnaam, Int32 aantalLln, Int32 aantalMinPerLln
            )
        {
            //variabelen
            List<Leerkrachten> dubbeleBoekeningen = new List<Leerkrachten>();
            List<Klas> geplandeKlassen = new List<Klas>();
            List<Klas> alleKlassen = new List<Klas>();
            List<Klas> overlapKlassen = new List<Klas>();
            Klas teTestenKlas = new Klas();
            Int32 indexGroep=-1;
            Int32 theoretischBeginuur = 0;
            Int32 theoretischBeginmin = 0;
            string antwoord = "De overlappende LKR per klas zijn:";

            //zoek de gegevens van de klas
            alleKlassen = Program.GetLijst();
            foreach(Klas k1 in alleKlassen)
            {
                if(k1.GetNaam()==klasnaam)
                {
                    teTestenKlas = k1;
                }
            }

            //Index van de groep zoeken
            foreach(Groep g in GeplandeGroepen)
            {
                if(g.GetVerantwoordelijke() == groepsnaam)
                {
                    indexGroep = GeplandeGroepen.IndexOf(g);
                }
            }

            // zorg dat er het aantal lln wordt veranderen of er standaard 12 leerlingen worden toegevoegd 
            if (aantalLln!= 0)
            {
                //zorg dat het juiste aantal leerlingen aanwezig is
                teTestenKlas.SetLlnAantal(aantalLln);
            }
            else
            {
                teTestenKlas.SetLlnAantal(12);
            }

            // zorg dat het juiste aantal minuten per leerling wordt ingesteld 
            if (aantalMinPerLln!=0)
            {
                teTestenKlas.SetMinutenPerLeerling(aantalMinPerLln);
            }

            // laad de laatsteklas in de groep waarin ze de klas willen toevoegen
            // sla ik ni op !!!! mag weg!!!
            GeplandeGroepen[indexGroep].GetUurlaatsteKlas();

            // vul het theoretische beginuur in, in de te testen klas
            teTestenKlas.SetBeginduur(GeplandeGroepen[indexGroep].GetDateTimeLaatsteKlas());

            //maak het einduur van de te testen klas
            teTestenKlas.BerekenEinduur();

            //maak een lijst met de overlappende klassen van andere groepen
            foreach (Groep g in GeplandeGroepen)
            {
                // neem alle groepen die niet gelijk zijn aan de groep waarbij men de klas wil toevoegen
                if(GeplandeGroepen.IndexOf(g)!= indexGroep)
                {
                    //Neem alle klassen die de deze groepen zitten
                    foreach(Klas k in g.GetKlassen())
                    {
                        //Kijk van deze klassen of het beginuur vroeger is dan het beginuur van de klas die we willen plannen
                        // Als dat zo is, dan moeten we kijken of het einduur later valt dan het beginuur van de te testen klas
                        // als dit het geval is dan overlappen ze en moeten we de LKR controleren 
                        DateTime tijd1 = k.GetBeginuur();
                        DateTime tijd2 = teTestenKlas.GetBeginuur();
                        Int32 test1 = DateTime.Compare(tijd1, tijd2);
                        Int32 test2 = DateTime.Compare(k.GetEinduur(), teTestenKlas.GetBeginuur());
                        if (DateTime.Compare(k.GetBeginuur(),teTestenKlas.GetBeginuur())<0 && DateTime.Compare(k.GetEinduur(),teTestenKlas.GetBeginuur())>0)
                        {
                            overlapKlassen.Add(k);
                        }
                        //Kijk van deze klassen of het beginuur later is dan het beginuur van de klas die we willen plannen
                        // Als dat zo is, dan moeten we kijken of dit beginuur later valt dan het einduur van de te testen klas
                        // als dit het geval is dan overlappen ze en moeten we de LKR controleren 
                        else if (DateTime.Compare(k.GetBeginuur(),teTestenKlas.GetBeginuur())>0 && DateTime.Compare(k.GetBeginuur(), teTestenKlas.GetEinduur())<0)
                        {
                            overlapKlassen.Add(k);
                        }
                    }

                    //check alle klassen die overlappen en geef alle specifieke leerkachten weer die overlappen.
                    
                }
            }

          foreach(Klas k in overlapKlassen)
            {

                antwoord = VulOverlapAan(antwoord, k.GetNaam(), k.OverlappendeLeerkrachten(teTestenKlas.GetLeerkachten()));
            }

            return antwoord;

        }

        //maak een string van de overlappende klassen en hun overlappende leerkrachten
       static private string VulOverlapAan(string beginTekst, string naamklas, List<Leerkrachten> overlapLkr)
        {
            beginTekst += "\n  " + naamklas + " : ";
            foreach (Leerkrachten lkr in overlapLkr)
            {
                beginTekst += "\n     " +lkr.GetNaam();
            }
            return beginTekst;
        }

    }
}
