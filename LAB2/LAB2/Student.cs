using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class Student
    {
        private string imie;
        private string nazwisko;
        private List<int> oceny = new List<int>();

        public Student(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public string Imie {  get { return imie; } set { imie = value; } }
        public string Nazwisko {  get { return nazwisko; } set { nazwisko = value; } }

        public void DodajOcene(int ocena)
        {
            oceny.Add(ocena);
        }

        public double SredniaOcen
        {
            get { if (oceny.Count == 0)
                    return 0;
                double suma = 0;
                foreach (int i in oceny)
                    suma += i;
                return suma / oceny.Count;
            }
        }

    }
}
