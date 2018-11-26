using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUN12Oefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            Speler s = new Speler(); s.SetNaam("Scott Pilgrim"); s.SetAantalLevens(3);

            while (s.IsGameOver() != false) { s.VerdienPunten(100); s.VerliesLeven(); }

            Console.Out.WriteLine(s);
        }
    }
}
