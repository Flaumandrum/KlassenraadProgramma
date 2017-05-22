using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Klassenraad.Klasses
{
    class DBKlassenraad
    {

            //variabalen
            static string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Klassenraad.mdb";
            static OleDbConnection conn = new OleDbConnection(connStr);
            

            // haal alle klassen uit de database
            public List<Klas> GetKlassen()
            {
                List<Klas> output = new List<Klas>();

                string Sql = "SELECT * FROM Klassen ";

                OleDbCommand cmd = new OleDbCommand(Sql, conn);
                OleDbDataReader reader;

                conn.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Klas _klas = new Klas(Convert.ToInt32(reader["Id"]), Convert.ToString(reader["Klas"]), Convert.ToInt32(reader["Aantal_Leerlingen"]));
                // haalt van de gemaakte klas de leerkrachten om en voegt ze toe aan de klas
                _klas.SetLKR(GetLeerkrachten(_klas.GetId()));
                    output.Add(_klas);

                }

                conn.Close();

                return output;

            }

        public List<Leerkrachten> GetLeerkrachten(Int32 klasId)
        {
            //variabelen
            List<Leerkrachten> lijstLKR = new List<Leerkrachten>();
            List<Int32> idLKR = new List<int>();

            // sql querry om het id van de leerkrachten op te halen die lesgeven aan een bepaalde klas
            string Sql = "SELECT * FROM Klas_Leerkrachten WHERE IdKlassen = "+ Convert.ToString(klasId) +"";
            

            OleDbCommand cmd = new OleDbCommand(Sql, conn);
            OleDbDataReader reader;

           

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
              
                idLKR.Add(Convert.ToInt32(reader["IdLeerkrachten"]));

            }
            
            foreach (Int32 id in idLKR)
            {
                string Sql2 = "SELECT * FROM Leerkrachten WHERE Id=" + id + "";
                
                OleDbCommand cmd2 = new OleDbCommand(Sql2, conn);

                using (var reader2 = cmd2.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        Leerkrachten leerkracht = new Leerkrachten(id, Convert.ToString(reader2["Naam"]));
                        lijstLKR.Add(leerkracht);

                    }
                }
            }

            


            return lijstLKR;
        }
            



        
    }
}
