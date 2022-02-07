using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akin_07022022_Eindtest_CSharp_Basis_en_Collections.Models
{
    public abstract class Product:IComparable<Product>
    {
        public int ProductNummer { get; set; }
        public string Merk { get; set; }
        public string Naam { get; set; }
        public int Volume { get; set; }
        public double Prijs { get; set; }

        public Product(int productnummer, string merk, string naam, int volume, double prijs)
        {
            ProductNummer = productnummer;
            Merk = merk;
            Naam = naam;
            Volume = volume;
            Prijs = prijs;
        }

        public int CompareTo(Product other)
        {
            return this.Merk.CompareTo(other.Merk) ;
        }
        public override string ToString()
        {
            return $"{ProductNummer,-10} Merk: {Merk,-15} Naam: {Naam,-25} Volume: {Volume,-15} Prijs:{Prijs,-10} Code: {GetProductCode(),-15}";
        }
        public string GetProductCode()
        {
            return $"{Merk.PadRight(3).Substring(0, 3).Replace(" ", "_").ToUpper() + Naam.PadRight(3).Substring(0, 3).Replace(" ", " _").ToUpper() + Volume}";
        }

    }
}
