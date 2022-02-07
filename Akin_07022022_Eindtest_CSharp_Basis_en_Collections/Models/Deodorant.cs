using Akin_07022022_Eindtest_CSharp_Basis_en_Collections.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akin_07022022_Eindtest_CSharp_Basis_en_Collections.Models
{
    public enum DeoType
    {
        VAPO,
        STICK
    }
    public class Deodorant : Product
    {
        public Deodorant(int productnummer, string merk, string naam, int volume, double prijs,DeoType soort) : base(productnummer, merk, naam, volume, prijs)
        {
            ProductNummer = productnummer;
            Merk = merk;
            Naam = naam;
            Volume = volume;
            Prijs = prijs;            
        }
        public DeoType soort { get; set; }
        public override string ToString()
        {
            return $"{soort}";
        }
    }
}
