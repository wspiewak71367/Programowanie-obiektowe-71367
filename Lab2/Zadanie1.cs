using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;

        public string Imie
        {
            get { return imie; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 2)
                    imie = value;
                else
                    imie = "Brak";
            }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 2)
                    nazwisko = value;
                else
                    nazwisko = "Brak";
            }
        }
        public int Wiek
        {
            get { return wiek; }
            set
            {
                if (value > 0)
                    wiek = value;
                else
                    wiek = 1;
            }
        }

        public Osoba(string imie, string nazwisko, int wiek)    
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Imię: " + Imie);
            Console.WriteLine("Nazwisko: " + Nazwisko);
            Console.WriteLine("Wiek: " + Wiek);
        }
    }
}
