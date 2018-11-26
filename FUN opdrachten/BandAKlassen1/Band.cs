using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandAKlassen1
{
    public class Band
    {
        public string Naam { get; set; }
        public string Genre { get; set; }
        public double UurTarief { get; set; }
        public int AantalBandleden { get; set; }

        public Band(string Naam, string Genre, double UurTarief, int AantalBandleden)
        {
            this.Naam = Naam;
            this.Genre = Genre;
            this.UurTarief = UurTarief;
            this.AantalBandleden = AantalBandleden;
        }
        
        public double Optreden (double Tijd)
        {
            
            return Tijd * (UurTarief / 60);
        }

        public double MuziekSchrijvenTarief (string NaamLiedje)
        {
            if(NaamLiedje.Length >= 7)
            {
                return 9.90;
            }
            else
            {
                return 0;
            }
        }

    }
}
