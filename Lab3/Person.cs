using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int wiek;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public int Wiek
        {
            get => wiek;
            set => wiek = value;
        }


        public Person(string FirstName, string LastName, int wiek){
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.wiek = wiek;
        }
        
        public virtual void View()
        {
            Console.WriteLine($"Osoba: {FirstName} {LastName}, wiek: {wiek}");
        }
    }



    public class Book
    {
        protected string title;
        protected string author;
        protected DateOnly date;

        public string Title => title;
        public string Author => author;
        public DateOnly Date => date;


        public Book(string title, string author, DateOnly date)
        {
            this.title = title;
            this.author = author;
            this.date = date;

        }

        public virtual void View()
        { 
         Console.WriteLine($"Tytuł, autor oraz data wydania: {title}, {author}, {date}");
        }

        
    }

    public class Reader : Person
    {
        public List<Book> Books;

        public Reader(string FirstName, string LastName, int wiek) : base(FirstName, LastName, wiek)
        {
            Books = new List<Book>();
        }

        public void ViewBook()
        {
            Console.WriteLine($"Książki przeczytane przez {FirstName} {LastName}:");
            if (Books.Count == 0)
            {
                Console.WriteLine("Brak przeczytanych książek.");
                return;
            }

            foreach (var book in Books)
            {
                book.View();
            }
        }
        public override void View()
        {
            Console.WriteLine($"Osoba: {FirstName} {LastName}, wiek: {Wiek}");
        }

    }

    public class Reviewer : Reader
    {
        private static readonly Random rng = new Random();
        public Reviewer(string FirstName, string LastName, int wiek) : base(FirstName, LastName, wiek)
        {
        }

        public void Wypisz()
        {
            Console.WriteLine($"Recenzent: {FirstName} {LastName}");
            if (Books.Count == 0)
            {
                Console.WriteLine("Brak przeczytanych książek.");
                return;
            }

            foreach (var book in Books)
            {
                int ocena = rng.Next(1, 11);
                Console.WriteLine($"- {book.Title} – ocena: {ocena}/10");
            }
        }
    }

    public class AdventureBook : Book
    {
        public int Pages { get; set; }
        public AdventureBook(string title, string author, DateOnly date, int Pages) 
            : base(title, author, date)
        {
            Pages = Pages; 
        }
        public override void View()
        {
            Console.WriteLine($"[Przygodowe] {title}, {author}, {date}, długość książki: {Pages}");
        }

    }
    public class DocumentaryBook : Book
    {
        public string Topic { get; set; }
        public int Pages { get; set; }
        public DocumentaryBook(string title, string author, DateOnly date, string Topic, int Pages) 
            : base(title, author, date)
        {
            Topic = Topic;
            Pages = Pages;

        }
        public override void View()
        {
            Console.WriteLine($"[Dokumentalne] {title}, {author}, {date},temat: {Topic}, długość książki: {Pages}");
        }

    }

}
