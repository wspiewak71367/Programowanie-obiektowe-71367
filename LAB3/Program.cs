using LAB3;
using System;

public class Program
{
    static void Main(string[] args)
    {

        Person autor1 = new Person("Adam", "Mickiewicz", 45);
        Person autor2 = new Person("Henryk", "Sienkiewicz", 60);

        Book ksiazka1 = new Book("Pan Tadeusz", autor1, "1834-06-28");
        Book ksiazka2 = new Book("Quo Vadis", autor2, "1896-01-01");
        Book ksiazka3 = new Book("Potop", autor2, "1886-01-01");

        Reader czytelnik = new Reader("Jan", "Kowalski", 25);

        czytelnik.Books.Add(ksiazka1);
        czytelnik.Books.Add(ksiazka2);
        czytelnik.Books.Add(ksiazka3);

        Console.WriteLine("=== INFORMACJE O KSIĄŻKACH ===");
        ksiazka1.View();
        ksiazka2.View();

        Console.WriteLine("=== INFORMACJE O CZYTELNIKU ===");
        czytelnik.View();
        Console.WriteLine("=== POLIMORFIZM (LISTA OSÓB) ===");
        List<Person> ludzie = new List<Person>();
        ludzie.Add(autor1);
        ludzie.Add(czytelnik);

        foreach (Person p in ludzie)
        {
            p.View();
            Console.WriteLine("----------------");
        }


        //-=-=-=-=-Zadanie 2 -=-=-=-=-=-
        Console.WriteLine("=== ZADANIE 2: SAMOCHODY ===");
        Samochod auto1 = new Samochod("Toyota", "Corolla", "Sedan", "Srebrny", 2022, 15000);
        SamochodOsobowy autoOsobowe = new SamochodOsobowy();

        Console.WriteLine("Podsumowanie pojazdów:");
        auto1.View();
        autoOsobowe.View();

        Console.ReadKey();

    }
}
