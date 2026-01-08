using System;
using System.Collections.Generic;
using System.Text;

namespace ParProg_Pins
{
    public enum alleEgenskaper {Balltre, Prins, Wånderbævm };
    internal class Egenskap
    {
        public alleEgenskaper minEgenskap;

        public Egenskap(string valg)
        {
            switch (valg)
            {
                case "1":
                    minEgenskap = alleEgenskaper.Balltre; break;
                case "2":
                    minEgenskap = alleEgenskaper.Prins; break;
                case "3":
                    minEgenskap = alleEgenskaper.Wånderbævm; break;
                    default:
                    Console.WriteLine("du må skrive 1,2 eller 3. dust"); break;

            }
             
        }

        public void PrintEgensap()
        {
            Console.WriteLine($"{minEgenskap}");
        }
    }
}
