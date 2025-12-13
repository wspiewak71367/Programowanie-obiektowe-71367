using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_zad2
{
    public abstract class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string PESEL { get; set; }
        public int Wiek { get; set; }
        public string Płeć { get; set; }

        public void SetFirstName(string Imie) => this.Imie = Imie;
        public void SetLastName(string Nazwisko) => this.Nazwisko = Nazwisko;
        public void SetPESEL(string PESEL) => this.PESEL = PESEL;

        public int GetAge()
        {
            if (string.IsNullOrEmpty(PESEL)) throw new Exception("PESEL nie został ustawiony.");

            int rok = int.Parse(PESEL.Substring(0, 2));
            int miesiacKod = int.Parse(PESEL.Substring(2, 2));
            int pelnyRok;

            if (miesiacKod >= 21 && miesiacKod <= 32)
            {
                pelnyRok = 2000 + rok;
            }
            else if (miesiacKod >= 1 && miesiacKod <= 12)
            {
                pelnyRok = 1900 + rok;
            }
            else
            {
                throw new Exception("Nieobsługiwany kod miesiąca w numerze PESEL.");
            }

            return DateTime.Now.Year - pelnyRok;
        }

        public string GetGender()
        {
            if (string.IsNullOrEmpty(PESEL)) throw new Exception("PESEL nie został ustawiony.");

            int cyfra = int.Parse(PESEL.Substring(9, 1));

            if (cyfra % 2 == 0)
            {
                return "Kobieta";
            }
            else
            {
                return "Mężczyzna";
            }
        }

        public string GetFullName() => $"{Imie} {Nazwisko}";
        public abstract string GetEducationInfo();
        public abstract bool CanGoAloneToHome(DateTime dateToCheck);
    }

    public class Uczen : Osoba
    {
        public string Szkola { get; private set; }
        public bool MozeSamWracacDoDomu { get; private set; }

        public void SetSchool(string szkola) => Szkola = szkola;
        public void ChangeSchool(string nowaSzkola) => Szkola = nowaSzkola;
        public void SetCanGoHomeAlone(bool mozeSam) => MozeSamWracacDoDomu = mozeSam;

        public override string GetEducationInfo() => $"Uczeń uczęszczający do: {Szkola}";

        public override bool CanGoAloneToHome(DateTime dateToCheck)
        {
            int wiek = GetAge();

            if (wiek < 12)
            {
                return MozeSamWracacDoDomu;
            }
            else
            {
                return true;
            }
        }
    }

    public class Nauczyciel : Uczen
    {
        public string TytulNaukowy { get; set; }
        public List<Uczen> PodwladniUczniowie { get; set; } = new List<Uczen>();

        public List<string> WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            List<string> uczniowieZPozwoleniem = new List<string>();

            Console.WriteLine($"\n--- Uczniowie, którzy mogą wracać sami ({dateToCheck.ToShortDateString()}) ---");

            foreach (var uczen in PodwladniUczniowie)
            {
                if (uczen.CanGoAloneToHome(dateToCheck))
                {
                    uczniowieZPozwoleniem.Add(uczen.GetFullName());
                    Console.WriteLine($"[TAK] {uczen.GetFullName()} (Wiek: {uczen.GetAge()}, Pozwolenie: {uczen.MozeSamWracacDoDomu})");
                }
                else
                {
                    Console.WriteLine($"[NIE] {uczen.GetFullName()} (Wiek: {uczen.GetAge()}, Wymagana opieka dorosłego)");
                }
            }

            return uczniowieZPozwoleniem;
        }

        public override string GetEducationInfo() => $"{TytulNaukowy} prowadzi zajęcia.";
    }
}
