namespace Studenthanteringssystem
{
    public class Elev
    {
        public string Namn { get; set; }
        public int FödelseÅr { get; set; }
        public int StudentId { get; set; }
        public List<int> Betyg { get; set; }




        public Elev(string namn, int födelseår, int studentId)
        {
            Namn = namn;
            FödelseÅr = födelseår;
            StudentId = studentId;
            Betyg = new List<int>();
        }
    }

    
    
}
