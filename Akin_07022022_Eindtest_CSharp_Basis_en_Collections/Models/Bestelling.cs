using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akin_07022022_Eindtest_CSharp_Basis_en_Collections.Models
{
    public class Bestelling
    {
        public List<Product> Bestellingen =new List<Product>();
        public static int productNummer = 1000;
        public List<Product>SelectAll()
        {
            return Bestellingen;
        }
        //public Bestelling()
        //{                       
        //}
        public void VoegProductToe(Product product)
        {
            productNummer++;
            Bestellingen.Add(product);        
        }
        public void ToonLijst()
        {
            //Bestellingen.Sort();
            //foreach (var item in Bestellingen)
            //{
            //    Console.WriteLine(item);
            //}
            var result = Bestellingen;
            result.FindAll(p => p.ToString() == ToString());
        }
        public void ToonPerMerk(string merk)
        {
            foreach (var item in Bestellingen)
            {
                if (item is Parfum)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public double ZoekDuursteProduct(List<Product> Bestelingen)
        {
            var max = Bestelingen.Max(p => p.Prijs);
            return max;
        }
        public void ToonParfums()
        {
            foreach (var item in Bestellingen.OfType<Parfum>())
            {
                Console.WriteLine(item);
            }
        }
    }
}
