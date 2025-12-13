// See https://aka.ms/new-console-template for more information
using Lab3._2;

class Program
{
    static void Main(string[] args)
    {
        SamochodOsobowy so1 = new SamochodOsobowy();

        Samochod s1 = new Samochod();

        Samochod s2 = new Samochod(
                "Toyota", "Corolla", "Hatchback", "Srebrny", 2018, 120000);

        Console.WriteLine();
        so1.Wyswietl();
        s1.Wyswietl();
        s2.Wyswietl();

    }
}
