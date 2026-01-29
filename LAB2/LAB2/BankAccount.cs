using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class BankAccount
    {
        private decimal saldo;
        private string wlasciciel;
        private decimal kwota;

        public BankAccount(string wlasciciel, decimal saldoPoczatkowe) //konstruktor - musi miec taką samą nazwe jak klasa!
        {
            Wlasciciel = wlasciciel;
            this.saldo=saldoPoczatkowe;
        }

        public string Wlasciciel
        {
            get { return wlasciciel; }
            set
            {
                if (value.Length >= 2) wlasciciel = value;
                else Console.WriteLine("Imie jest za krotkie!");
            }
        }

        public decimal Saldo { get { return saldo; } }

        public void Wplata(decimal kwota)
        {
             if (kwota > 0)
            {
                saldo += kwota;
                Console.WriteLine($"Wpłacono {kwota}zł, twoje saldo wynosi obecnie: {Saldo}");
            }
        }
        public void Wyplata(decimal kwota)
        {
            if (kwota > 0)
            {
                saldo -= kwota;
                Console.WriteLine($"Wypłacono {kwota}zł, twoje saldo wynosi obecnie: {Saldo}");
            }
        }

    }
}
