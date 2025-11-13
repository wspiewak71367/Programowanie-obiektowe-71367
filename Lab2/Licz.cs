using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Licz
    {
        private int value;

        public Licz(int liczba) 
        {
          value = liczba;
        }

        public void Dodaj(int liczba)
        {
            value += liczba;
        }

        public void Odejmij(int liczba)
        {
            value -= liczba;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Aktualna wartość:  " + value);
        }
    }
}
