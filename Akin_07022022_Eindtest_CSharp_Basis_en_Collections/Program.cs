using Akin_07022022_Eindtest_CSharp_Basis_en_Collections.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akin_07022022_Eindtest_CSharp_Basis_en_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bestelling bestelling = new Bestelling();

            bestelling.VoegProductToe(new Parfum(1000, "BVLGARI", "BLV", 75, 61.52));
            bestelling.VoegProductToe(new Parfum(1001, "Dolce&Gabbana", "Light Blue", 100, 66.72));
            bestelling.VoegProductToe(new Parfum(1002, "Georgio Armani", "Code Donna", 50, 59.32));
            bestelling.VoegProductToe(new Parfum(1003, "Georgio Armani", "Code Donna", 30, 39.84));
            bestelling.VoegProductToe(new Parfum(1004, "Georgio Armani", "Code Donna", 75, 76.00));
            bestelling.VoegProductToe(new Parfum(1005, "Givency", "Absolutely Irresistible", 75, 75.42));
            bestelling.VoegProductToe(new Parfum(1006, "Ted Lapidus", "Pour Elle", 50, 44.48));
            bestelling.VoegProductToe(new AfterShave(1007, "Cacharel", "Anais", 50, 24.50, Soort.VAPO));
            bestelling.VoegProductToe(new Deodorant(1008, "DKNY", "Be Delicious Man", 100, 33.65, DeoType.STICK));
            bestelling.VoegProductToe(new AfterShave(1009, "Yves Saint Laurent", "Jazz", 50, 59.32, Soort.VAPO));
            bestelling.VoegProductToe(new AfterShave(10010, "Yves Saint Laurent", "Jazz", 100, 59.32, Soort.VAPO));

            bestelling.ToonLijst();
            bestelling.ToonPerMerk("Georgio Armani");
            bestelling.ToonParfums();
            
            //bestelling.ZoekDuursteProduct();
          
            SchrijfNaarBestand schrijfNaarBestand = new SchrijfNaarBestand();
            //schrijfNaarBestand.WriteToFile();




        }
    }
}
