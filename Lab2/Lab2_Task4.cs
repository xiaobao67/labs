using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите q: ");
        double q = double.Parse(Console.ReadLine());

        double sum = 1;
        double term = 1;
        int n = 1;

        while (Math.Abs(term) >= q)
        {
            term *= -x * x / (2 * n * (2 * n - 1));
            sum += term;
            n++;
        }

        Console.WriteLine($"cos(x) ≈ {sum}");
        Console.WriteLine($"Количество слагаемых: {n}");
    }
}
