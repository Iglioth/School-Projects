using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BallBlowerKlassen1
{
    public class Bal
    {

        public double diameter { get; set; }
        public Color kleur { get; set; }

        public Bal(double Diameter, Color Kleur )
        {
            this.diameter = Diameter;
            this.kleur = Kleur;
        }

        public bool VerderOpblazen(double extra)
        {

            diameter = diameter + extra;

            if (diameter < 1.50)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
