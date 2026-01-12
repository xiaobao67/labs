using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество слагаемых: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        int sign = 1;

        for (int i = 0; i < n; i++)
        {
            sum += sign * 1.0 / (2 * i + 1);
            sign = -sign;
        }

        double pi = 4 * sum;
        Console.WriteLine($"π ≈ {pi}");
    }
}
