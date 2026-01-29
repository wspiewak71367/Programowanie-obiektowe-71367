using System;
enum Operacje
{
    Dodawanie = 1,
    Odejmowanie,
    Mnozenie,
    Dzielenie,
}

class Program
{

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Podaj 1 liczbę");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wybierz operację:");
            Console.WriteLine("1 - Dodawanie");
            Console.WriteLine("2 - Odejmowanie");
            Console.WriteLine("3 - Mnożenie");
            Console.WriteLine("4 - Dzielenie");
            Console.Write("Twój wybór: ");
            int wybor = Convert.ToInt32(Console.ReadLine());
            Operacje wybranaOp = (Operacje)wybor;
            Console.WriteLine("Podaj 2 liczbę");
            double b = Convert.ToDouble(Console.ReadLine());

            double wynik = kalkulator(a, b, wybranaOp);
            Console.WriteLine($"Wynik: {wynik}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}"); 
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił nieoczekiwany błąd: {ex.Message}"); 
        }

        Console.ReadKey();
    }

    static double kalkulator(double a, double b, Operacje op)
    {
        switch (op)
        {
            case Operacje.Dodawanie:
                return a + b;
            case Operacje.Odejmowanie:
                return a - b;
            case Operacje.Mnozenie:
                return a * b;
            case Operacje.Dzielenie:
                {
                    if (b != 0)
                    {
                        return a / b;
                    }
                    else throw new DivideByZeroException("Nie można dzielić przez zero!");
                }
            default:
                throw new ArgumentOutOfRangeException();

        }
    }   
        
}

