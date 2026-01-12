using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1)
        {
            Console.WriteLine("false");
            return;
        }

        while (n % 3 == 0)
        {
            n /= 3;
        }

        Console.WriteLine(n == 1);
    }
}
