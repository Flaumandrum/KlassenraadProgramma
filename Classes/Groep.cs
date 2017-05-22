using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Groep
    {
       
         // velden 
       
        string verantwoordelijke = "";
        Int32 beginuur = 0;
        Int32 beginmin = 0;
        Int32 laatsteKlasUur = 0;
        Int32 laatsteKlasMin = 0;
        DateTime laatsteKlas =new DateTime();

        List<Klas> geplandeKlassen = new List<Klas>();

        //klas toevoegen
        public void AddKlas(Klas item)
        {
            geplandeKlassen.Add(item);

        }

        // hele lijst van klassen toevoegen
        public void SetGeplandeKlassen(List<Klas> lijst)
        {
            geplandeKlassen = lijst;
        }
       
        public string GetVerantwoordelijke()
        {
            return verantwoordelijke;
        }
      
        public  List<Klas> GetKlassen()
        {
            return geplandeKlassen;
        }

        public void Verwijder(Int32 indexklas)
        {
            geplandeKlassen.RemoveAt(indexklas);
        }

        public Int32 GetUur()
        {
            return beginuur;
        }

        public Int32 GetMin()
        {
            return beginmin;
        }

        public string GetTekstUurVolledig()
        {
            String tekstUur;

            tekstUur = Convert.ToString(beginuur) + ":" + Convert.ToString(beginmin);

            return tekstUur;
        }

        //get het einduur van de laatste geplande klas
        public void VulLaatsteUurIn()
        {
            foreach(Klas k in geplandeKlassen)
            {
                laatsteKlasUur = k.GetIntEinduur();
                laatsteKlasMin = k.GetIntEindMin();
                laatsteKlas = k.GetEinduur();
            }
        }

        //stuur datetime van laatste klas door
        public DateTime GetDateTimeLaatsteKlas()
        {
            if(geplandeKlassen.Count == 0)
            {
                laatsteKlas = DateTime.Now;
                laatsteKlas = laatsteKlas.Date.Add(new TimeSpan(beginuur, beginmin, 0));
            }
            return laatsteKlas;
        }

        //stuur uur van de laatste klas door
        public Int32 GetUurlaatsteKlas()
        {
            return laatsteKlasUur;
        }

        //stuur uur van de laatste klas door
        public Int32 GetMinlaatsteKlas()
        {
            return laatsteKlasMin;
        }

        //constructors
        public Groep()
        {
            verantwoordelijke = "John Doe";
        }

       

        public Groep(string constructVerantwoordelijke, Int32 gegUur, Int32 gegMin)
        {
            
            verantwoordelijke = constructVerantwoordelijke;
            beginuur = gegUur;
            beginmin = gegMin;

        }

    }
}
