using System;
using System.Collections.Generic;
using ContactManager;

class Program
{
    static void Main()
    {
        var jsonRepo = new JsonContactRepository();
        List<Contact> lista = jsonRepo.Load();

        Console.WriteLine("1. Pokaż kontakty\n2. Dodaj kontakt\n3. Zapisz i Wyjdź");
        string wybor = Console.ReadLine();

        if (wybor == "2")
        {
            Console.Write("Podaj Name: ");
            string name = Console.ReadLine();
            lista.Add(new Contact { Id = lista.Count + 1, Name = name, Email = "test@x.pl" });
        }

        jsonRepo.Save(lista);
    }
}
