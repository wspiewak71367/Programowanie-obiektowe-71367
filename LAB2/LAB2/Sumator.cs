using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class Sumator
    { 
        private List<int> liczby = new List<int>();
        public double suma = 0;
        
        public void Dodajliczbe(int liczba)
        {
            liczby.Add(liczba);
        }

        public void Suma()
        {
            foreach (int i in liczby)
            {
                suma += i;
            }
            Console.WriteLine($"Suma liczb w tablicy to: {suma}");
        }

        public void IleElementow()
        {
            
            int ile= liczby.Count;
            Console.WriteLine($"W twojej tablicy jest {ile} elementow");
        }
        public void SumaPodziel2()
        {
            suma = suma / 2;
            Console.WriteLine($"Suma liczb w tablicy podzielona przez 2 wynosi {suma}");
        }

        public void Wypisz()
        {
            foreach (int k in liczby)
                Console.WriteLine(k);
        }

        public void WypiszZakres(int lowIndex, int highIndex)
        {
            Console.WriteLine($"Elementy o indeksach od {lowIndex} do {highIndex}:");

            for (int i = 0; i < liczby.Count; i++)
            {
                if (i >= lowIndex && i <= highIndex)
                {
                    Console.WriteLine($"Indeks [{i}]: {liczby[i]}");
                }
            }
        }
    }
}
