using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    
    public class Klas 
    {
        //Variabelen
        Int32 id = 0;
        string naam = "";
        bool ingepland = false;
        DateTime beginuur = DateTime.Now;
        DateTime einduur;
        Int32 aantalLeerlingen = 12;
        Int32 minutenPerLln = 5;
        List<Leerkrachten> leerkrachten = new List<Leerkrachten>();

            //bereken het einduur van de klas
            public void BerekenEinduur()
        {
            Int32 minuten = (minutenPerLln * aantalLeerlingen);
            einduur = beginuur.AddMinutes(minuten);
        }
        
            //verander het aantal minuten per leerling
            public void SetMinutenPerLeerling(Int32 waarde)
            {
                minutenPerLln = waarde;
            }

            // get ID van de klas
            public Int32 GetId()
            {
                return id;
            }

            // get de naam van de klas
            public string GetNaam()
            {
                return naam;
            }

            //Geeft weer of een klas reeds is gepland of niet.
            public bool GetIngepland()
            {
                return ingepland;
            }
            
            //get dateTime versie van beginuur
            public DateTime GetBeginuur()
            {

                return beginuur;           
            }

            // get dateTime versie van einduur
            public DateTime GetEinduur()
            {

                return einduur;
            }

            //get intversie van einduur
            public Int32 GetIntEinduur()
            {
            Int32 uur;
            uur = Convert.ToInt32(einduur.Hour);

            return uur;
            }

             //get intversie van eindmin
             public Int32 GetIntEindMin()
        {
            Int32 min;
            min = Convert.ToInt32(einduur.Minute);

            return min;
        }

            //get tekstversie van beginuur
            public string GetTekstBeginuur()
            {
                String antwoord;
                Int32 uur;
                Int32 min; 

                uur = Convert.ToInt32(beginuur.Hour);
                min = Convert.ToInt32(beginuur.Minute);

                antwoord = Convert.ToString(uur) + ":" + Convert.ToString(min);

                return antwoord;
            }



        // get tekstversie van einduur
            public string GetTekstEinduur()
            {
                String antwoord;
                Int32 uur;
                Int32 min;

                uur = Convert.ToInt32(einduur.Hour);
                min = Convert.ToInt32(einduur.Minute);

                antwoord = Convert.ToString(uur) + ":" + Convert.ToString(min);

                return antwoord;
            }

        // geeft het aantal leerlingen in een klas 
        public Int32 GetAantalLeerlingen()
            {
               return aantalLeerlingen;
            }


        //Set uur via integers
        public void SetUurenMin(Int32 uur, Int32 min)
        {
            beginuur= beginuur.Date.Add(new TimeSpan(uur, min, 0));
        }

        //set uur via datetime
        public void SetBeginduur(DateTime startuur)
        {
            beginuur = startuur;
        }

        // voegt leekrachten toe aan een klas
        public void SetLKR(List<Leerkrachten> lijstje)
        {
            leerkrachten = lijstje;
        }
        
        //geeft de lijst van leerkrachten weer die in deze klas lesgeeft
        public List<Leerkrachten> GetLeerkachten()
        {
            return leerkrachten;
        }

        // veranderd het aantal van de leerlingen 
        public void SetLlnAantal(Int32 Aantal)
        {
            aantalLeerlingen = Aantal;
        }

        // veranderd naar ingepland of niet
        public void SetIngepland()
        {
            if(ingepland)
            {
                ingepland = false;
            }
            else
            {
                ingepland = true;
            }
        }


        //vergelijk een lijst met leerkrachten om de overlappende eruit te halen.
        public List<Leerkrachten> OverlappendeLeerkrachten(List<Leerkrachten> teVergelijken)
        {
            List<Leerkrachten> overlapLKR = new List<Leerkrachten>();
            foreach (Leerkrachten lkr in teVergelijken)
            {
                foreach(Leerkrachten lkrInklas in leerkrachten)
                {
                    if(lkr.GetNaam() == lkrInklas.GetNaam())
                    {
                        overlapLKR.Add(lkr);
                    }
                }
            }

            return overlapLKR;
        }

            // constructor
            public Klas(Int32 constructId, string constructNaam, Int32 aantalLln)
            {
                id = constructId;
                naam = constructNaam;
                aantalLeerlingen = aantalLln;
                
            }

            public Klas()
        {
            id = 9999;
            naam = "leeg";
        }



    }
}
