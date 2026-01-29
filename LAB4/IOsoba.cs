using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public interface IOsoba
    {
        string Imie1 { get; set; }
        string Nazwisko1 { get; set; }

        public string ZwrocPelnaNazwe();

    }

    public class Osoba1 : IOsoba
    {
        public string Imie1 { get; set; }
        public string Nazwisko1 { get; set; }

        public Osoba1(string imie, string nazwisko)
        {
            Imie1 = imie;
            Nazwisko1 = nazwisko;
        }

        public string ZwrocPelnaNazwe()
        {
            return $"{Imie1} {Nazwisko1}";
        }
    }

    public static class OsobaExtensions
    {
        public static void WypiszOsoby(this List<IOsoba> lista)
        {
            Console.WriteLine("--- Lista Osób ---");
            foreach (var osoba in lista)
            {
                Console.WriteLine($"{osoba.Imie1} {osoba.Nazwisko1}");
            }
        }

    public static void PosortujOsobyPoNazwisku(this List<IOsoba> lista)
        {
            var posortowane = lista.OrderBy(o => o.Nazwisko1).ToList();
            lista.Clear();
            lista.AddRange(posortowane);
            Console.WriteLine("Lista została posortowana po nazwisku.");
        }

    }

    public interface IStudent : IOsoba
    {
        string Uczelnia { get; set; }
        string Kierunek { get; set; }
        int Rok { get; set; }
        int Semestr { get; set; }
    }

    public class Student : Osoba1, IStudent
    {
        public string Uczelnia { get; set; }
        public string Kierunek { get; set; }
        public int Rok { get; set; }
        public int Semestr { get; set; }

        public Student(string imie, string nazwisko, string uczelnia, string kierunek, int rok, int semestr)
            : base(imie, nazwisko) 
        {
            Uczelnia = uczelnia;
            Kierunek = kierunek;
            Rok = rok;
            Semestr = semestr;
        }

        public string WypiszPelnaNazweIUczelnie()
        {
            return $"{Imie1} {Nazwisko1} – {Semestr}{Kierunek} {Rok} {Uczelnia}";
        }
    }

    public class StudentWSIiZ : Student
    {
        public StudentWSIiZ(string imie, string nazwisko, string kierunek, int rok, int semestr)
            : base(imie, nazwisko, "WSIiZ", kierunek, rok, semestr) { }
    }


}
