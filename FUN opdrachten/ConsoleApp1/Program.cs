using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] woord = { 'H', 'a', 'l', 'l', 'o', '!' };
            for (int i = 0; i < woord.Length; i++)
            { Console.Out.Write(woord[i]); }
            Console.Out.Write(Environment.NewLine);
        }
    }
}
