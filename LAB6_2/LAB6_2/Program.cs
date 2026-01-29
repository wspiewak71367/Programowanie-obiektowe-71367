using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace AnalizaPopulacji
{
    public class RootRecord
    {
        public CountryInfo country { get; set; }
        public string value { get; set; }
        public string date { get; set; }
    }

    public class CountryInfo
    {
        public string id { get; set; }
        public string value { get; set; }
    }

    public class PopulationRecord
    {
        public string Country { get; set; }
        public int Year { get; set; }
        public long Value { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "db.json";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Błąd: Nie odnaleziono pliku db.json.");
                return;
            }

            string jsonString = File.ReadAllText(filePath);

            var raw = JsonSerializer.Deserialize<List<RootRecord>>(jsonString);

            var data = raw
                .Where(r => r.value != null)
                .Select(r => new PopulationRecord
                {
                    Country = r.country.value,
                    Year = int.Parse(r.date),
                    Value = long.Parse(r.value)
                })
                .ToList();

            bool dzialaj = true;
            while (dzialaj)
            {
                Console.WriteLine("--- MENU ANALIZY ---");
                Console.WriteLine("1. Wyświetl populację (wybrany kraj i rok)");
                Console.WriteLine("2. Sprawdź różnicę populacji w zakresie lat");
                Console.WriteLine("3. Sprawdź procentowy wzrost (względem roku poprzedniego)");
                Console.WriteLine("0. Wyjście");
                Console.Write("Wybór: ");

                string wybor = Console.ReadLine();
                try
                {
                    switch (wybor)
                    {
                        case "1":
                            ObsluzWyswietlanie(data);
                            break;
                        case "2":
                            ObsluzZakres(data);
                            break;
                        case "3":
                            ObsluzWzrost(data);
                            break;
                        case "0":
                            dzialaj = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił błąd: {ex.Message}"); 
                }
            }
        }

        static void WyswietlRoznice(List<PopulationRecord> data, string country, int y1, int y2)
        {
            var p1 = data.FirstOrDefault(d => string.Equals(d.Country, country, StringComparison.OrdinalIgnoreCase) && d.Year == y1);
            var p2 = data.FirstOrDefault(d =>string.Equals(d.Country, country, StringComparison.OrdinalIgnoreCase)&& d.Year == y2);

            if (p1 != null && p2 != null)
            {
                long roznica = p2.Value - p1.Value;
                Console.WriteLine($"Różnica populacji dla {country} ({y1}-{y2}): {roznica:N0}");
            }
        }

        static void ObsluzWyswietlanie(List<PopulationRecord> data)
        {
            Console.Write("Podaj kraj (USA, India, China): ");
            string kraj = Console.ReadLine();
            Console.Write("Podaj rok: ");
            int rok = int.Parse(Console.ReadLine()); 

            var wynik = data.FirstOrDefault(d => d.Country.Equals(kraj, StringComparison.OrdinalIgnoreCase) && d.Year == rok);
            if (wynik != null)
                Console.WriteLine($"Populacja {kraj} w roku {rok} wynosiła: {wynik.Value:N0}");
            else
                Console.WriteLine("Brak danych dla podanych parametrów.");
        }

        static void ObsluzZakres(List<PopulationRecord> data)
        {
            Console.Write("Podaj kraj: ");
            string kraj = Console.ReadLine();
            Console.Write("Rok początkowy: ");
            int r1 = int.Parse(Console.ReadLine());
            Console.Write("Rok końcowy: ");
            int r2 = int.Parse(Console.ReadLine());

            WyswietlRoznice(data, kraj, r1, r2);
        }

        static void ObsluzWzrost(List<PopulationRecord> data)
        {
            Console.Write("Podaj rok docelowy: ");
            int rok = int.Parse(Console.ReadLine());

            var kraje = data.Select(d => d.Country).Distinct().ToList(); 

            foreach (var kraj in kraje)
            {
                var obecny = data.FirstOrDefault(d => d.Country == kraj && d.Year == rok);
                var poprzedni = data.FirstOrDefault(d => d.Country == kraj && d.Year == rok - 1);

                if (obecny != null && poprzedni != null)
                {
                    double wzrost = ((double)(obecny.Value - poprzedni.Value) / poprzedni.Value) * 100;
                    Console.WriteLine($"{kraj}: Wzrost o {wzrost:F2}% względem roku {rok - 1}");
                }
            }
        }
    }
}