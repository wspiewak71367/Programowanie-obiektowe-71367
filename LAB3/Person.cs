using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int wiek;

        public string FirstName
        {
            get { return firstName; } 
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; } 
            set { lastName = value; }
        }
        public int Wiek
        {
            get { return wiek; } 
            set { wiek = value; }
        }


        public Person(string firstName, string lastName, int wiek)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.wiek = wiek;
        }

        public virtual void View()
        {
            Console.WriteLine($"Imię i nazwisko: {FirstName} {LastName}, Wiek: {wiek}");
        }
    }

    public class Reader : Person
    {
        public new List<Book> Books = new List<Book>();

        public Reader(string firstName, string lastName, int wiek) : base(firstName, lastName, wiek) { }

        public void ViewBook()
        {
            Console.WriteLine("Lista przeczytanych książek:");
            foreach (Book book in Books)
            {
                Console.WriteLine($"- {book.Title}");
            }
        }

        public override void View()
        {
            base.View(); 
            ViewBook();  
        }
    }

    public class Reviewer : Reader
    {
        private Random random = new Random();

        public Reviewer(string firstName, string lastName, int wiek) : base(firstName, lastName, wiek) { }

        public override void View()
        {
            Console.WriteLine($"--- Recenzent: {FirstName} {LastName} ---");
            foreach (var book in Books)
            {
                int ocena = random.Next(1, 7);
                Console.Write($"Ocena: {ocena}/6 | ");
                book.View();
            }
        }
    }


}
