// See https://aka.ms/new-console-template for more information
using Lab4;

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Rectangle { X = 10, Y = 10, Width = 100, Height = 50 });
        shapes.Add(new Triangle { X = 20, Y = 20, Width = 40, Height = 40 });
        shapes.Add(new Circle { X = 50, Y = 50, Width = 30, Height = 30 });

        Console.WriteLine("Rysuje figure");

        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}