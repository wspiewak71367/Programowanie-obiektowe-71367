using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student
    {
        public string Imie {  get; set; }
        public string Nazwisko { get; set; }

        private List<int> oceny = new List<int>();

        public Student(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public void DodajOcene(int ocena)
        {
            oceny.Add(ocena);
        }

        public double SredniaOcen
        {
            get
            {
                if(oceny.Count == 0)
                    return 0;
                double suma  = 0;
                foreach (int o in oceny)
                    suma += o;
                return suma / oceny.Count;
            }
        }

    }
}
