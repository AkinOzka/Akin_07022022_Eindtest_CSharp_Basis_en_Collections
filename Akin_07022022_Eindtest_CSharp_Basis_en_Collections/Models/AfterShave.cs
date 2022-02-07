using Akin_07022022_Eindtest_CSharp_Basis_en_Collections.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akin_07022022_Eindtest_CSharp_Basis_en_Collections.Models
{
    public enum Soort
    {
        VAPO,
        GEL
    }
    public class AfterShave : Product
    {     
        public AfterShave(int productnummer, string merk, string naam, int volume, double prijs, Soort soort) : base(productnummer, merk, naam, volume, prijs)
        {
            ProductNummer = productnummer;
            Merk = merk;
            Naam = naam;
            Volume = volume;
            Prijs = prijs;           
        }
        public Soort soort { get; set; }
        public override string ToString()
        {
            return $"{soort}";
        }       
    }
}
