using System;

namespace Sklep
{
    public enum StatusZamowienia
    {
        Oczekujace,
        Przyjete,
        Zrealizowane,
        Anulowane
    }

    public class Sklep
    {
        private Dictionary<int, List<string>> zamowieniaProdukty = new Dictionary<int, List<string>>();
        private Dictionary<int, StatusZamowienia> zamowieniaStatusy = new Dictionary<int, StatusZamowienia>();

        public void DodajZamowienie(int numer, List<string> produkty)
        {
            zamowieniaProdukty.Add(numer, produkty);
            zamowieniaStatusy.Add(numer, StatusZamowienia.Oczekujace);
        }

        public void ZmienStatus(int numerZamowienia, StatusZamowienia nowyStatus)
        {
            if (!zamowieniaStatusy.ContainsKey(numerZamowienia))
            {
                throw new KeyNotFoundException($"Błąd: Zamówienie o numerze {numerZamowienia} nie istnieje w systemie.");
            }

            if (zamowieniaStatusy[numerZamowienia] == nowyStatus)
            {
                throw new ArgumentException($"Błąd: Zamówienie #{numerZamowienia} posiada już status {nowyStatus}.");
            }

            zamowieniaStatusy[numerZamowienia] = nowyStatus;
            Console.WriteLine($"Status zamówienia #{numerZamowienia} został zaktualizowany na: {nowyStatus}.");
        }

        public void WyswietlZamowienia()
        {
            Console.WriteLine("--- AKTUALNA LISTA ZAMÓWIEŃ ---");
            foreach (var wpis in zamowieniaProdukty)
            {
                int nr = wpis.Key;
                string produkty = string.Join(", ", wpis.Value);
                StatusZamowienia status = zamowieniaStatusy[nr];

                Console.WriteLine($"Zamówienie #{nr} | Status: {status} | Produkty: {produkty}");
            }
        }


    }
    class program
    {
        static void Main(string[] args)
        {
            Sklep mojSklep = new Sklep();

            mojSklep.DodajZamowienie(101, new List<string> { "Kawa", "Cukier" });
            mojSklep.DodajZamowienie(102, new List<string> { "Laptop", "Myszka bezprzewodowa" });

            mojSklep.WyswietlZamowienia();

            try
            {
                mojSklep.ZmienStatus(101, StatusZamowienia.Przyjete);

                Console.Write("Podaj numer zamówienia do zmiany na 'Zrealizowane': ");
                int id = int.Parse(Console.ReadLine() ?? "0");

                mojSklep.ZmienStatus(id, StatusZamowienia.Zrealizowane);
                mojSklep.WyswietlZamowienia();
            }

            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd: Wprowadzono nieprawidłowy format numeru zamówienia.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił nieoczekiwany błąd: " + ex.Message);
            }

            Console.ReadKey();
        }
    }

}