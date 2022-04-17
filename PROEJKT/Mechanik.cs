using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWarsztatSamochodowy
{
    public class Mechanik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int RokRozpoczecia{ get; set; }
        public int Stawka { get; set; }
        
        
        public string PelnaNazwa
        {
            get 
            {
                
                return Imie + " " + Nazwisko + "Rok rozp."+ " "  + RokRozpoczecia;
            }
        }

        public static List<Mechanik> ListaMechaników = new List<Mechanik>();

        
    }
}