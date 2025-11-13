using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Sumator
    {
        private int[] Liczby;

        public Sumator(int[] liczby)
        {
            Liczby = liczby;
        }

        public int Suma()
        {
            int suma = 0;
            foreach (int liczba in Liczby)
            {
                suma += liczba;
            }
            return suma;
        }

        public int SumaPodziel2()
        {
            int suma = 0;
            foreach (int liczba in Liczby)
            {
                if(liczba % 2 == 0)
                {
                    suma += liczba;
                }
            }
            return suma;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Wyniki: ");
            foreach (int liczba in Liczby)
            {
                Console.WriteLine(liczba + " ");
            }
            Console.WriteLine();
        }



    }
}
