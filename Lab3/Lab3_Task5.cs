using System;

class Program
{
    static void Main()
    {
        int[,] a = new int[5, 5];
        int[,] b = new int[5, 5];
        int[,] c = new int[5, 5];
        Random rnd = new Random();

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                a[i, j] = rnd.Next(1, 5);
                b[i, j] = rnd.Next(1, 5);
            }

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                for (int k = 0; k < 5; k++)
                    c[i, j] += a[i, k] * b[k, j];

        Console.WriteLine("Результат умножения:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
                Console.Write($"{c[i, j],5}");
            Console.WriteLine();
        }
    }
}
