using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightProject
{
    class TrafficLight
    {
        public string Colour { get; set; }
        
        public TrafficLight(string colour)
        {
            this.Colour = colour;
        }

        public void NextState()
        {
            if(Colour == "Red")
            {
                Colour = "Green";
            }

            else if(Colour == "Green")
            {
                Colour = "Orange";
            }

            else if(Colour == "Orange")
            {
                Colour = "Red";
            }
        }

        

    }
}
