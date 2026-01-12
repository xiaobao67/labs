using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите четное N: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        int count = 0;

        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                if (Math.Abs(a[i] - a[j]) <= 5)
                    count++;

        Console.WriteLine("Количество пар: " + count);
    }
}
