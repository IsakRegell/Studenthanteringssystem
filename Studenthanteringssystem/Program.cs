namespace Studenthanteringssystem
{
    internal class Program
    {
        public List<Elev> elever = new List<Elev>();
        static void Main(string[] args)
        {
            Studenthanteringssystem system = new Studenthanteringssystem();
            bool programIsRuning = true;

            while (programIsRuning)
            {
                Console.WriteLine("-----** Studentapplikation **-----");
                Console.WriteLine("Tryck på (1) för att lägga till en elev");
                Console.WriteLine("Tryck på (2) för att ta bort en elev");
                Console.WriteLine("Tryck på (3) för att räkna ut snittbetyget för alla elver");
                Console.WriteLine("Tryck på (4) för att visa alla elever med betyg högre än..");
                Console.WriteLine("Tryck på (5) för att se alla elever");
                Console.WriteLine("Tryck på (9) för att stänga av programet");
                String meny1Val = Console.ReadLine()!;

                switch (meny1Val)
                {
                    case "1":
                        system.LäggTillElev();
                        system.Pausa();
                        break;
                    case "2":
                        system.TabortElev();
                        system.Pausa();

                        break;
                    case "3":
                        
                        break;
                    case "4":
                        //List<Elev> resultatavmetod = system.VisaAllaEleverMedBetygHögreÄn(50);  //  Andvänds vid return
                        system.VisaAllaEleverMedBetygHögreÄn(50);
                        system.Pausa();
                        break;
                    case "5":
                        system.VisaAllaElever();
                        system.Pausa();
                        break;
                    case "9":
                        Console.WriteLine("Du valde att stänga av programet :(");
                        programIsRuning = !true;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }
            }
            

        }
    }
}
