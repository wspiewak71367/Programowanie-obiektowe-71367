// See https://aka.ms/new-console-template for more information
using Lab4_zad2;

class Program
{
    static void Main()
    {
        Nauczyciel panPiotr = new Nauczyciel
        {
            TytulNaukowy = "Mgr Inż.",
        };
        panPiotr.SetFirstName("Piotr");
        panPiotr.SetLastName("Nowak");
        panPiotr.SetPESEL("75010112345");

        Console.WriteLine($"Nauczyciel: {panPiotr.GetFullName()} ({panPiotr.GetEducationInfo()})");

        Uczen krysia = new Uczen();
        krysia.SetFirstName("Krystyna");
        krysia.SetLastName("Wójcik");
        krysia.SetPESEL("14020112348");
        krysia.SetSchool("Szkoła Podstawowa");
        krysia.SetCanGoHomeAlone(true);

        Uczen marek = new Uczen();
        marek.SetFirstName("Marek");
        marek.SetLastName("Zieliński");
        marek.SetPESEL("13010112349");
        marek.SetSchool("Gimnazjum");
        marek.SetCanGoHomeAlone(false);

        Uczen ania = new Uczen();
        ania.SetFirstName("Anna");
        ania.SetLastName("Kowalska");
        ania.SetPESEL("15030312348");
        ania.SetSchool("Szkoła Podstawowa");
        ania.SetCanGoHomeAlone(false);

        panPiotr.PodwladniUczniowie.Add(krysia);
        panPiotr.PodwladniUczniowie.Add(marek);
        panPiotr.PodwladniUczniowie.Add(ania);

        List<string> mogaIscSami = panPiotr.WhichStudentCanGoHomeAlone(DateTime.Today);

        Console.WriteLine("\n--- PODSUMOWANIE ---");
        Console.WriteLine($"Liczba uczniów mogących wrócić bez opieki: {mogaIscSami.Count}");

        Console.ReadKey();
    }

}