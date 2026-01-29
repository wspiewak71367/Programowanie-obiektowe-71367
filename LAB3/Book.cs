using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Book
    {
        protected string title;
        protected Person author;
        protected string dataWydania;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public Person Author
        {
            get { return author; }
            set { author = value; }
        }
        public string DataWydania
        {
            get { return dataWydania; }
            set { dataWydania = value; }
        }

        public Book(string title, Person author, string dataWydania)
        {
            this.title = title;
            this.author = author;
            this.dataWydania = dataWydania;
        }

        public virtual void View()
        {
            Console.WriteLine($"Tytuł: {Title}, Data wydania: {DataWydania}");
            Console.Write("Autor książki: ");
            author.View();
        }
    }

    public class AdventureBook : Book
    {
        private string trudnosc;

        public AdventureBook(string title, Person author, string dataWydania, string trudnosc)
           : base(title, author, dataWydania)
        {
            this.trudnosc = trudnosc;
        }
        public override void View()
        {
            Console.Write($"[PRZYGODA - Poziom: {trudnosc}] ");
            base.View();
        }
    }

    public class DocumentaryBook : Book
    {
        private string epoka;
        public DocumentaryBook(string title, Person author, string dataWydania, string epoka)
           : base(title, author, dataWydania)
        {
            this.epoka = epoka;
        }
        public override void View()
        {
            Console.Write($"[DOKUMENT - Epoka: {epoka}] ");
            base.View();
        }
    }

}
