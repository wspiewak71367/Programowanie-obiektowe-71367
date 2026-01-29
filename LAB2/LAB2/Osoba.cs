using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;

        public Osoba(string imie, string nazwisko, int wiek) //Konstruktor
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public string Imie
        {
            get { return imie; }
            set { if (value.Length >= 2) imie = value;
                else Console.WriteLine("Błąd imie musi zawierać minimum 2 znaki"); }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (value.Length >= 2) nazwisko = value;
                else Console.WriteLine("Błąd nazwisko musi zawierać minimum 2 znaki");
            }
        }
        public int Wiek
        {
            get { return wiek; }
            set
            {
                if (value > 0) wiek = value;
                else Console.WriteLine("Błąd wiek nie może być ujemny");
            }
        }

        public void WyswietlInformacje() //Metoda
        {
            Console.WriteLine($"twoje imie to: {imie} {nazwisko}, i masz {wiek} lat");
        }
    }
}
