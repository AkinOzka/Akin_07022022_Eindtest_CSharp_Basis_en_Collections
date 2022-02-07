using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Akin_07022022_Eindtest_CSharp_Basis_en_Collections.Models
{
    public class SchrijfNaarBestand
    {        
        string path = Directory.GetCurrentDirectory() + "Bestellingen.txt";
        //public string directorynaam = @"C:\Users\AkinO\source\repos\Akin_07022022_Eindtest_CSharp_Basis_en_Collections";
        //public string bestandsnaam = "Bestellingen.txt";
        //public string path = Path.Combine(directorynaam, bestandsnaam);
        public void WriteToFile(List<Bestelling> bestellings, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < bestellings.Count; i++)
                {
                    sw.Write(bestellings);
                    //sw.Write(bestellings[i].Naam);
                    //sw.WriteLine(bestellings[i].Volume);
                }
            }
        }
        //internal void WriteToFile()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
