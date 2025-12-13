using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Shape
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("Nieokreślony kształt");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rysuje prostokąt");
        }
    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rysuje trójkąt");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rysuje okrąg");
        }
    }
}
