using LAB2;
using static System.Net.Mime.MediaTypeNames;

    class Program()
{
    static void Main(string[] args)
    {
        //Zadanie 1 
        Osoba jan = new Osoba("Jan", "Kowalski", 44);
        jan.WyswietlInformacje();
        //Zadanie 2
        BankAccount Mbank = new BankAccount("Jan Kowalski", 4999);
        Mbank.Wplata(500);
        Mbank.Wyplata(100);
        //Zadanie 3
        Student janek = new Student("Jan", "Kowalski");
        janek.DodajOcene(5);
        janek.DodajOcene(1);
        Console.WriteLine($"Średnia ocen: {janek.SredniaOcen}");
        //Zadanie 4
        Licz liczba = new Licz(100);
        liczba.Dodaj(100);
        liczba.Odejmij(50);
        liczba.view();
        //Zadanie 5
        Sumator nowy = new Sumator();
        nowy.Dodajliczbe(4);
        nowy.Dodajliczbe(5);
        nowy.Dodajliczbe(10);
        nowy.Dodajliczbe(1);
        nowy.Dodajliczbe(88);
        nowy.Suma();
        nowy.SumaPodziel2();
        nowy.IleElementow();
        nowy.Wypisz();
        nowy.WypiszZakres(2, 10);
    }

}