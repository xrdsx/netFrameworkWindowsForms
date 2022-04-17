using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWarsztatSamochodowy
{
    public class Naprawa
    {
        public string NrRej;
        public DateTime DataNaprawy = DateTime.Today;
        public Mechanik Mechanicy;
    
        public decimal KosztCzesci;
        public decimal CzasPracy;
        public decimal Suma;


        static public List<Naprawa> ListaNapraw = new List<Naprawa>();
    }
}
