using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class BankAccount
    {
        private decimal saldo;
        public decimal Saldo
        {
            get { return saldo; }
        }

        public string Wlasciciel { get; set; }

        public BankAccount(string wlasciciel, decimal poczatkowe)
        {
            Wlasciciel = wlasciciel;
            saldo = poczatkowe >= 0 ? poczatkowe : 0;
        }

        public void Wplata(decimal kwota)
        {
            if (kwota > 0)
                saldo += kwota;
        }

        public void Wyplata(decimal kwota)
        {
            if (kwota > 0 && saldo >= kwota)
                saldo -= kwota;
            else
                Console.WriteLine("Brak wystarczajacych srodkow");
        }


    }
}
