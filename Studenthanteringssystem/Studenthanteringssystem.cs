using System.Linq.Expressions;

namespace Studenthanteringssystem
{
    public class Studenthanteringssystem
    {
        public List<Elev> elever = new List<Elev>();

        public Studenthanteringssystem()
        {
            Elev elev1 = new Elev("Isak Regell", 2004, 111);
            Elev elev2 = new Elev("Amanda Frykmer", 2005, 222);
            elev1.Betyg.Add(49);
            elev2.Betyg.Add(89);
            elever.Add(elev1);
            elever.Add(elev2);
        }

        public void LäggTillElev()
        {
            Console.WriteLine("Vad heter eleven du vill lägga till? : ");
            string nyElevNamn = Console.ReadLine()!;

            Console.WriteLine("Vilket år är eleven född? : ");
            int nyElevFödelseår = Convert.ToInt32(Console.ReadLine())!;

            Console.WriteLine("Vad ska den nya eleven ha för student ID? : ");
            int nyElevStudentId = Convert.ToInt32(Console.ReadLine())!;

            Console.WriteLine("Vad är den nya elevens betyg? : ");
            int nyElevBetyg = Convert.ToInt32(Console.ReadLine())!;

            Elev skapadElev = new Elev(nyElevNamn, nyElevFödelseår, nyElevStudentId);
            elever.Add(skapadElev);
            skapadElev.Betyg.Add(nyElevBetyg);

            Console.WriteLine("Den angivna Eleven är nu tillagd");
            Console.WriteLine($"Detta är den nya eleven värden Namn: *{nyElevNamn}*  Födelseår : *{nyElevFödelseår}*  StudentID : *{nyElevStudentId}* BETYG : ({nyElevBetyg})");
        }

        public void TabortElev() // Denna var ny men tror jag fattar hur vi söker igenom listan
        {
            {
                Console.WriteLine("Vänligen ange student ID på eleven du vill ta bort : ");
                int elevAttTabort = Convert.ToInt32(Console.ReadLine())!;

                // Hitta eleven med det angivna StudentId
                Elev elevTillTabort = elever.FirstOrDefault(e => e.StudentId == elevAttTabort)!;

                if (elevTillTabort != null) // Kontrollera om eleven hittades
                {
                    elever.Remove(elevTillTabort); // Ta bort eleven från listan
                    Console.WriteLine($"Eleven med Student ID {elevAttTabort} har tagits bort.");
                }
                else
                {
                    Console.WriteLine($"Ingen elev hittades med Student ID {elevAttTabort}.");
                }
            }
        }

        public void RäknautGenomsnittBetyg()
        {

        }
        public void VisaAllaEleverMedBetygHögreÄn(int minBetyg)
             //List<Elev> //  Andvänds vid return
        {
            bool hittadElev = false;
            //List<Elev>allaelevmedhögrebetyg = new List<Elev> ();    //  Andvänds vid return
            foreach (var elev in elever)
            {
                if (elev.Betyg.Any(b => b >= minBetyg))
                {
                    Console.WriteLine($"Detta är alla Elever med Betyg *{minBetyg}* Eller högre");
                    string betygLista = string.Join(", ", elev.Betyg);
                    Console.WriteLine($"Namn: *{elev.Namn}* Födelseår: *{elev.FödelseÅr}* StudentID: *{elev.StudentId}* ELEVENS BETYG: {betygLista}");
                    hittadElev = true;
                    //allaelevmedhögrebetyg.Add(elev);      //  Andvänds vid return
                }
            }
            if (!hittadElev)
            {
                Console.WriteLine($"Inga elever med betyg högre än eller lika med *{minBetyg}* hittades.");
            }
            //return allaelevmedhögrebetyg;   //  Andvänds vid return
        }

        public void VisaAllaElever()
        {
            Console.WriteLine("Lista över alla elever:");
            foreach (var elev in elever)
            {
                string betygLista = string.Join(", ", elev.Betyg);
                Console.WriteLine($"Namn: {elev.Namn}, Födelseår: {elev.FödelseÅr}, StudentId: {elev.StudentId}  DETTA ÄR ELEVENS BETYG: {betygLista}");
            }
            
        }
        public void Pausa()
        {
            Console.WriteLine("\n Tryck på en tangent för att fortsätta...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
