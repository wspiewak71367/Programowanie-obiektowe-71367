using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class Uczen : Osoba
    {
        public string Szkola { get; set; }
        public bool MozeSamWracacDoDomu { get; set; }

        public void SetSchool(string szkola) => Szkola = szkola;
        public void ChangeSchool(string szkola) => Szkola = szkola;
        public void SetCanGoHomeAlone(bool canGo) => MozeSamWracacDoDomu = canGo;

        public override string GetEducationInfo() => $"Uczeń szkoły: {Szkola}";

        public override bool CanGoAloneToHome()
        {
            return GetAge() >= 12 || MozeSamWracacDoDomu;
        }

        public void Info()
        {
            Console.WriteLine($"{GetFullName()} - Wiek: {GetAge()}, Może wracać sam: {CanGoAloneToHome()}");
        }
    }
}
