using System;

class Program
{
    static void Main()
    {
        int f1 = 1, f2 = 1;
        int count = 0;

        while (true)
        {
            int f = f1 + f2;
            if (f >= 1000 && f <= 9999)
                count++;

            if (f > 9999)
                break;

            f1 = f2;
            f2 = f;
        }

        Console.WriteLine($"Количество четырехзначных чисел: {count}");
    }
}
