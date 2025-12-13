using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
    public class Samochod
    {
        public string Marka {  get; set; }
        public string Model { get; set; }
        public string Nadwozie { get; set; }
        public string Kolor { get; set; }
        public int RokProdukcji { get; set; }
        public int Przebieg { get; set; }

        public Samochod() {
            Console.Write("Podaj markę: ");
            Marka = Console.ReadLine();

            Console.Write("Podaj model: ");
            Model = Console.ReadLine();

            Console.Write("Podaj nadwozie: ");
            Nadwozie = Console.ReadLine();

            Console.Write("Podaj kolor: ");
            Kolor = Console.ReadLine();

            Console.Write("Podaj rok produkcji: ");
            RokProdukcji = int.Parse(Console.ReadLine());

            Console.Write("Podaj przebieg (km): ");
            int przebieg;
            while (!int.TryParse(Console.ReadLine(), out przebieg) || przebieg < 0)
            {
                Console.Write("Przebieg nie może być ujemny. Podaj ponownie: ");
            }
            Przebieg = przebieg;
        }

        public Samochod(string marka, string model, string nadwozie,
                        string kolor, int rokProdukcji, int przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rokProdukcji;
            Przebieg = przebieg < 0 ? 0 : przebieg;
        }

        public virtual void Wyswietl()
        {
            Console.WriteLine(
                $"Samochód: {Marka} {Model}, nadwozie: {Nadwozie}, kolor: {Kolor}, rok: {RokProdukcji}, przebieg: {Przebieg} km");
        }
    }







    public class SamochodOsobowy : Samochod
    {
        public double Waga { get; set; }
        public double Poj { get; set; }
        public int IloscOsob { get; set; }

        public SamochodOsobowy() : base()
        {
            Console.Write("Podaj wagę (t) 2.0–4.5: ");
            double waga;
            while (!double.TryParse(Console.ReadLine(), out waga) || waga < 2.0 || waga > 4.5)
            {
                Console.Write("Waga musi być z przedziału 2.0–4.5 t. Podaj ponownie: ");
            }
            Waga = waga;

            Console.Write("Podaj pojemność silnika (l) 0.8–3.0: ");
            double poj;
            while (!double.TryParse(Console.ReadLine(), out poj) || poj < 0.8 || poj > 3.0)
            {
                Console.Write("Pojemność musi być z przedziału 0.8–3.0 l. Podaj ponownie: ");
            }
            Poj = poj;

            Console.Write("Podaj ilość osób: ");
            IloscOsob = int.Parse(Console.ReadLine());
        }

        public override void Wyswietl()
        {
            Console.WriteLine(
                $"Samochód osobowy: {Marka} {Model}, nadwozie: {Nadwozie}, kolor: {Kolor}, rok: {RokProdukcji}, przebieg: {Przebieg} km, " +
                $"waga: {Waga} t, pojemność: {Poj} l, ilość osób: {IloscOsob}");
        }
    }
}
