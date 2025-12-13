// See https://aka.ms/new-console-template for more information

using Lab3;

class Program
{
    static void Main()
    {
        //1a

        var p1 = new Person("Kazimierz", "Odnowiciel", 44);
        var p2 = new Person("Karolina", "Margaryna", 26);
        var p3 = new Person("Adam", "Wajda", 47);

        var b1 = new Book("Potop", "Henryk Sienkiewicz", new DateOnly(1974, 09, 4));
        var b2 = new Book("Mielone na 1000 sposobów", "Jacek Nowogrodzki", new DateOnly(2002, 11, 22));
        var b3 = new Book("Harry potter", "JK Rowling", new DateOnly(2002, 04, 21));
        var b4 = new Book("Atlas geograficzny", "Czesław Ryba", new DateOnly(2009, 04, 23));
        var b5 = new Book("Wielka encyklopedia ryb rzecznych", "Adam Kuna", new DateOnly(1976, 02, 13));

        var r1 = new Reader("Kazimierz", "Odnowiciel", 44);
        var r2 = new Reader("Karolina", "Margaryna", 26);
        var r3 = new Reader("Adam", "Wajda", 47);

        var rev1 = new Reviewer("Kazimierz", "Odnowiciel", 44);
        var rev2 = new Reviewer("Karolina", "Margaryna", 26);
        var rev3 = new Reviewer("Adam", "Wajda", 47);

        r1.Books.Add(b1);
        r1.Books.Add(b2);
        r2.Books.Add(b5);
        r2.Books.Add(b4);
        r2.Books.Add(b5);

        rev1.Books.Add(b1);
        rev1.Books.Add(b2);

        rev2.Books.Add(b2);
        rev2.Books.Add(b3);

        p1.View();
        p2.View();
        p3.View();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        b1.View();
        b2.View();
        b3.View();
        b4.View();
        b5.View();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        r1.ViewBook();
        r2.ViewBook();
        r3.ViewBook();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        r1.View();
        r2.View();
        r3.View();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        Person o = new Reader("Olgierd", "Banaszewicz", 24);
        o.View();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        rev1.Wypisz();
        rev2.Wypisz();
        Console.WriteLine("-------------------------------------------------------------------------------------------");

        List<Person> osoby = new List<Person> { r1, r2, p1, p2 };

        foreach (var k in osoby)
        {
            k.View();
        }
        Console.WriteLine("-------------------------------------------------------------------------------------------");

        var b6 = new AdventureBook("Wyprawa w góry", "Jan Podróżnik", new DateOnly(2010, 5, 1), 222);
        var b7 = new DocumentaryBook("Historia Polski", "Adam Historyk", new DateOnly(2005, 3, 15), "Historia", 320);
        Console.WriteLine("-------------------------------------------------------------------------------------------");

        r1.Books.Add(b6);
        r1.Books.Add(b7);
        Console.WriteLine("-------------------------------------------------------------------------------------------");

        r1.ViewBook();




    }
}
