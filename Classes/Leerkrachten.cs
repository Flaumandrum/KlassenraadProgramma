using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Leerkrachten
    {
        //variabelen
        Int32 id;
        String naam = "";

        //geef naam terug
        public string GetNaam()
        {
            return naam;
        }

        //constructor
        public Leerkrachten(Int32 constructId, string constructNaam)
        {
            id = constructId;
            naam = constructNaam;
        }
    }
}
