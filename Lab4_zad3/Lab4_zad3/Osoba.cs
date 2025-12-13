using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_zad3
{
    public interface IOsoba
    {
        string Imie { get; set; }
        string Nazwisko { get; set; }
        string ZwrocPelnaNazwe();
    }

    public interface IStudent : IOsoba
    {
        string Uczelnia { get; set; }
        string Kierunek { get; set; }
        int Rok { get; set; }
        int Semestr { get; set; }
    }

    public class Osoba : IOsoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}";
        }
    }
    public class Student : IStudent
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string Uczelnia { get; set; }
        public string Kierunek { get; set; }
        public int Rok { get; set; }
        public int Semestr { get; set; }

        public Student(string imie, string nazwisko, string uczelnia, string kierunek, int rok, int semestr)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Uczelnia = uczelnia;
            Kierunek = kierunek;
            Rok = rok;
            Semestr = semestr;
        }

        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}";
        }

        public string WypiszPelnaNazweIUczelnie()
        {
            return $"{Imie} {Nazwisko} – Rok {Rok}/{Semestr} {Kierunek} {Uczelnia}";
        }
    }
    public class StudentWSIiZ : Student
    {
        public StudentWSIiZ(string imie, string nazwisko, string kierunek, int rok, int semestr)
            : base(imie, nazwisko, "WSIiZ", kierunek, rok, semestr)
        {
        }
    }

    public static class ListExtensions
    {
        public static void WypiszOsoby(this List<Osoba> lista)
        {
            Console.WriteLine("\n--- WYPISANIE OSÓB ---");
            foreach (var osoba in lista)
            {
                Console.WriteLine(osoba.ZwrocPelnaNazwe());
            }
        }

        public static void PosortujOsobyPoNazwisku(this List<Osoba> lista)
        {
            var posortowanaLista = lista.OrderBy(o => o.Nazwisko).ToList();
            lista.Clear();
            lista.AddRange(posortowanaLista);

            Console.WriteLine("\n--- LISTA ZOSTALA POSORTOWANA PO NAZWISKU ---");
        }

        public static void WypiszOsoby(this List<StudentWSIiZ> lista)
        {
            Console.WriteLine("\n--- WYPISANIE STUDENTÓW WSIiZ ---");
            foreach (var student in lista)
            {
                Console.WriteLine(student.WypiszPelnaNazweIUczelnie());
            }
        }
    }
}
