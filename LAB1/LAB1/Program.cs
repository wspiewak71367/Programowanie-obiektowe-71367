using System;



//Zadanie 1 
//double delta, a, b, c, x1, x2;
//Console.WriteLine("Podaj a");
//a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Podaj b");
//b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Podaj c");
//c = Convert.ToDouble(Console.ReadLine());

//if (a == 0)
//{
//    Console.WriteLine("Brak rozwiązań");
//}

//else {
//    delta = b * b - 4 * a * c;

//    if (delta > 0)
//    {
//        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//        Console.WriteLine($"Twoja delta to {delta}, x1={x1}, x2={x2}");
//    }

//    else if (delta == 0)
//    {
//        x1 = -b / (2 * a);
//        Console.WriteLine($"Delta = 0, jedno rozwiązanie {x1}");
//    }

//    else Console.WriteLine("Brak rozwiązań");
//}

//Zadanie 2 

//int[] tablica = new int[10];
//Console.WriteLine("Podaj 10 liczb");

//for (int i = 0; i<10; i++)
//{
//    tablica[i] = int.Parse(Console.ReadLine());
//}

//int suma = 0;
//int iloczyn = 1;

//foreach (int j in tablica)
//{
//    suma += j;
//    iloczyn *= j;
//}
//Array.Sort(tablica);
//int maks = tablica[9];
//int min = tablica[0];
//int avg = suma / 10;
//Console.WriteLine($"Suma twoich licz to {suma}, iloczyn twoich liczb to {iloczyn}, średnia to {avg}, wartość maksymalna to {maks}, wartość minimalna to {min}");

//Zadanie 3


//for(int i = 20; i>=0; i--)
//{
//    if(i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
//    {
//        continue;
//    }
//    Console.WriteLine(i + " ");
//}
//Console.WriteLine();

//Zadanie 4

//int a;
//Console.WriteLine("Podaj liczbe całkowitą większą od 0");
//a = Convert.ToInt32(Console.ReadLine());

//while (a > 0) {
//    Console.WriteLine("Podaj liczbe całkowitą większą od 0");
//    a = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("Podano złą liczbe");

//Zadanie 5

    Console.WriteLine("Podaj liczbe elementów do sortowania: ");
    int n = int.Parse(Console.ReadLine());

    int[] liczby = new int[n];

    Console.WriteLine("Podaj liczby: ");
    for (int i = 0; i < n; i++)
    {
        liczby[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - 1; j++)
        {
            if (liczby[j] > liczby[j + 1])
            {
                int temp = liczby[j];
                liczby[j] = liczby[j + 1];
                liczby[j + 1] = temp;
            }
        }
    }

    Console.WriteLine("Posortowane liczby: ");
    foreach (int liczba in liczby)
    {
        Console.WriteLine(liczba);
    }