// See https://aka.ms/new-console-template for more information
using Lab4_zad3;
class Program
{
    static void Main(string[] args)
    {
        List<Osoba> listaOsob = new List<Osoba>
        {
            new Osoba("Jan", "Kowalski"),
            new Osoba("Anna", "Zielińska"),
            new Osoba("Bartosz", "Wojciechowski"),
            new Osoba("Celina", "Adamska")
        };

        listaOsob.WypiszOsoby();

        listaOsob.PosortujOsobyPoNazwisku();
        listaOsob.WypiszOsoby();

        List<StudentWSIiZ> listaStudentow = new List<StudentWSIiZ>
        {
            new StudentWSIiZ("Ewa", "Nowak", "Zarządzanie", 3, 5),
            new StudentWSIiZ("Hubert", "Pająk", "Informatyka", 4, 7),
            new StudentWSIiZ("Grażyna", "Lewandowska", "Finanse", 1, 4)
        };

        listaStudentow.WypiszOsoby();

        Console.ReadKey();
    }
}