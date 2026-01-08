using System;
using System.Collections.Generic;
using System.Text;

namespace ParProg_Pins
{
    internal class Karakter
    {
        private int Penger { get; set; } = 300;
        private int MaxBensin { get; set; } = 40;
        private int CurrBensin { get; set; }
        private Egenskap minEgenskap { get; set; }
        private List<Pin> Cowboyhatt = new List<Pin>();
        private string Lokasjon { get; set; } = "Hjemmet";

        public Karakter(Egenskap egenskap)
        {
            minEgenskap = egenskap;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Du har {Penger}kr, og {CurrBensin}L bensin i tanken");
        }
        public void TjenPenger()
        {
            Random rnd = new Random();
            int rndTall = rnd.Next(50, 200);

            Console.WriteLine($"Du spilte guitar og tjente {rndTall}kr");
            Penger += rndTall;
        }

        public void KjøpPin(Pin pin)
        {
            if (Penger < pin.Price)
            {
                Console.WriteLine($"du hakke nok penger, du har {pin.Navn}, den koster {pin.Price}, og du har bare {Penger}");
                return;
            }

            Penger -= pin.Price;
            Console.WriteLine($"du kjøpte {pin.Navn} som kostet {pin.Price}kr, du har nå {Penger}kr igjen");

            Cowboyhatt.Add(pin);
        }

        public void showHat()
        {
            Console.WriteLine("Du tar av deg hatten og ser du har:");
            foreach(Pin pin in Cowboyhatt) 
            {
                Console.WriteLine($"{pin.Navn} sin pin");
            }
        }

        public void PrintLokasjon()
        {
            Console.WriteLine($"Du er i {Lokasjon}");
        }
        
    }

    
    
    
}
