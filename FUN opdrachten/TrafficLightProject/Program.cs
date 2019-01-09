using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight("Red");

            while (true)
            {
                    
                    trafficLight.NextState();
                    Console.WriteLine(trafficLight.Colour);
                    Console.WriteLine("How else can I help you?");

                

        
                    Console.WriteLine(trafficLight.Colour);
                    Console.WriteLine("How else can I help you?");
                
            }
        }

        




    }
}
