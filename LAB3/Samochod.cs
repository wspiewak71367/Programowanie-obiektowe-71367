using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Samochod
    {
        public string Marka, Model, Nadwozie, Kolor;
        public int RokProdukcji;
        private int przebieg;

        public int Przebieg
        {
            get => przebieg;
            set => przebieg = value >= 0 ? value : 0;
        }
        public Samochod(string marka, string model, string nadwozie, string kolor, int rok, int przebieg)
        {
            Marka = marka; Model = model; Nadwozie = nadwozie; Kolor = kolor;
            RokProdukcji = rok; Przebieg = przebieg;
        }

        public Samochod()
        {
            Console.WriteLine("Wprowadź dane samochodu:");
            Console.Write("Marka: "); Marka = Console.ReadLine();
            Console.Write("Model: "); Model = Console.ReadLine();
            Console.Write("Przebieg: "); Przebieg = int.Parse(Console.ReadLine() ?? "0");
        }

        public virtual void View()
        {
            Console.WriteLine($"Samochód: {Marka} {Model}, Rok: {RokProdukcji}, Przebieg: {Przebieg}km");
        }
    }

    public class SamochodOsobowy : Samochod
    {
        public double Waga, PojemnoscSilnika;
        public int IloscOsob;

        public SamochodOsobowy() : base()
        {
            Console.Write("Waga (2-4.5t): "); Waga = double.Parse(Console.ReadLine());
            Console.Write("Pojemność (0.8-3.0): "); PojemnoscSilnika = double.Parse(Console.ReadLine());
        }
        public override void View()
        {
            base.View();
            Console.WriteLine($"Osobowy -> Waga: {Waga}t, Silnik: {PojemnoscSilnika}L");
        }
    }
}
