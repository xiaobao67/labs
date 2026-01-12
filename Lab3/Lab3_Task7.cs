using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"f({n}) = {Fibonacci(n)}");
    }
}
