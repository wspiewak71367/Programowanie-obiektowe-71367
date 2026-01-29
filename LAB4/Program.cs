using LAB4;
using System;

public class Program
{
    static void Main(string[] args)
    {
        List<Shape> figury = new List<Shape>();

        figury.Add(new Rectangle { X = 10, Y = 10, Width = 50, Height = 20 });
        figury.Add(new Triangle { X = 20, Y = 30, Width = 30, Height = 30 });
        figury.Add(new Circle { X = 5, Y = 5, Width = 15, Height = 15 });

        Console.WriteLine("=== RYSOWANIE FIGUR ===");

        foreach (Shape figura in figury)
        {
            figura.Draw();
        }
        //-=-=-=-=-=-=-=- Zadanie 2 -=-=-=-=-=-=-=-=-

        Uczen u1 = new Uczen();
        u1.SetFirstName("Jan");
        u1.SetLastName("Kowalski");
        u1.SetPesel("15211512345"); 
        u1.SetCanGoHomeAlone(false);

        Uczen u2 = new Uczen();
        u2.SetFirstName("Anna");
        u2.SetLastName("Zaradna");
        u2.SetPesel("12211554321");
        u2.SetCanGoHomeAlone(false);

        Uczen u3 = new Uczen();
        u3.SetFirstName("Kamil");
        u3.SetLastName("Młody");
        u3.SetPesel("16211598765"); 
        u3.SetCanGoHomeAlone(true);

        Nauczyciel prof = new Nauczyciel { TytulNaukowy = "Mgr", Szkola = "SP nr 1" };
        prof.SetFirstName("Adam");
        prof.SetLastName("Belfer");
        prof.PodwladniUczniowie.AddRange(new[] { u1, u2, u3 });

        prof.WhichStudentCanGoHomeAlone(DateTime.Now);

        //-=-=-=-=-=-=-=- Zadanie 3 -=-=-=-=-=-=-=-=-

        List<IOsoba> osoby = new List<IOsoba>
            {
                new Osoba1("Jan", "Kowalski"),
                new Osoba1("Anna", "Abacka"),
                new StudentWSIiZ("Marek", "Zolty", "IID-P", 2024, 2)
            };

        osoby.WypiszOsoby();
        osoby.PosortujOsobyPoNazwisku();
        osoby.WypiszOsoby();

        Console.WriteLine("--- Szczegóły Studentów ---");
        foreach (var o in osoby)
        {
            if (o is Student s)
            {
                Console.WriteLine(s.WypiszPelnaNazweIUczelnie());
            }
        }


        Console.ReadKey();
    }
}