using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class Nauczyciel : Uczen 
    {
        public string TytulNaukowy { get; set; }
        public List<Uczen> PodwladniUczniowie { get; set; } = new List<Uczen>();

        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            Console.WriteLine($"Lista uczniów mogących wrócić samodzielnie (stan na {dateToCheck:yyyy-MM-dd}):");
            foreach (var uczen in PodwladniUczniowie)
            {
                if (uczen.CanGoAloneToHome())
                {
                    Console.WriteLine($"- {uczen.GetFullName()}");
                }
            }
        }
    }
}
