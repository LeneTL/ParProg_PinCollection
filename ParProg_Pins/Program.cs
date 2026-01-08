namespace ParProg_Pins
{
    internal class Program
    {
        public static Karakter ourKarakter;

        public static List<Pin> pinList = new List<Pin>()
        {
            new Pin("Tønsberg", 120),
            new Pin("Stavern", 120),
            new Pin("Larvik", 120),
            new Pin("Sandefjord", 120),
            new Pin("Verdens Ende", 120),
        };
        public static List<Bensinstasjon> besinstasjonList = new List<Bensinstasjon>()
        {
            new Bensinstasjon($"{pinList[0].Navn} Bensinstasjon", pinList[0]),
            new Bensinstasjon($"{pinList[1].Navn} Bensinstasjon", pinList[1]),
            new Bensinstasjon($"{pinList[2].Navn} Bensinstasjon", pinList[2]),
            new Bensinstasjon($"{pinList[3].Navn} Bensinstasjon", pinList[3]),
            new Bensinstasjon($"{pinList[4].Navn} Bensinstasjon", pinList[4])
        };
        static void Main(string[] args)
        {
            Startgame();
            Console.WriteLine($" kul test: {ourKarakter.Penger}");
            
        }

        public static void Startgame()
        {
            Console.WriteLine("Halla! Nå skal du ut og samle Pins igjen! Denne gangen fra VESTFOLD!!(og telemark)");
            Console.WriteLine("så hva er din egenskap??");
            Console.WriteLine("1. Balltre med glitter");
            Console.WriteLine("2. Pins Prins");
            Console.WriteLine("3. Wånderbævm i Ruta");
            string svar = Console.ReadLine();
            Egenskap våregenskap = new Egenskap(svar);
            Console.Clear();
            Console.WriteLine($"Din egenskap er:");
            Console.WriteLine($" kul test 2{våregenskap.minEgenskap}");
            våregenskap.PrintEgensap();

            Karakter vårkarakter = new Karakter(våregenskap);
            ourKarakter = vårkarakter;
        }

        public static void Travel(Karakter karakter)
        {
            karakter.PrintLokasjon();
            Console.WriteLine("Hvor vil du?");
        }
    }
}
