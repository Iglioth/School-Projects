using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUN12Oefeningen
{
    class Speler
    {
        private string Naam; private int AantalLevens; private int Score;
        
        public void SetNaam(string naam) { Naam = naam; }

        public void SetAantalLevens(int levens) { AantalLevens = levens; }

        public void VerdienPunten(int punten) { if (IsGameOver() == false) { Score = Score + punten; } }

        public void VerliesLeven() { if (IsGameOver() == false) { AantalLevens = AantalLevens - 1; } }

        public bool IsGameOver() { if (AantalLevens <= 0) { return true; } else { return false; } }

        public override string ToString() { return Naam + ": " + Score; }
    }
}
