// See https://aka.ms/new-console-template for more information
using Lab2;

class Program
{
    static void Main()
    {

        var z = new Osoba("Kamil","Slimak",21);
        z.Wyswietl();


        var konto = new BankAccount("Jan Kowalski", 1000);
        konto.Wplata(500);
        konto.Wyplata(200);
        Console.WriteLine($"Saldo: {konto.Saldo}");


        var student = new Student("Kamil", "Slimak");
        student.DodajOcene(5);
        student.DodajOcene(4);
        student.DodajOcene(3);
        Console.WriteLine($"Średnia ocen: {student.SredniaOcen}");

        Licz liczba1 = new Licz(10);
        Licz liczba2 = new Licz(25);

        liczba1.Dodaj(5);    
        liczba1.Odejmij(3);  
        liczba1.Wyswietl();

        liczba2.Dodaj(10);  
        liczba2.Odejmij(40); 
        liczba2.Wyswietl();

        var suma = new Sumator(new int[] { 1, 2, 3, 4, 5, 6 });
        suma.Wyswietl();
        Console.WriteLine($"Suma: {suma.Suma()}");
        Console.WriteLine($"Suma podzielnych przez 2: {suma.SumaPodziel2()}");

    }


}