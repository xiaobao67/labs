using System;

class Program
{
    static int[,] Add(int[,] a, int[,] b, out double avg)
    {
        int[,] res = new int[3, 3];
        int sum = 0;

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                res[i, j] = a[i, j] + b[i, j];
                sum += a[i, j] + b[i, j];
            }

        avg = sum / 18.0;
        return res;
    }

    static int[,] Sub(int[,] a, int[,] b, out double avg)
    {
        int[,] res = new int[3, 3];
        int sum = 0;

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                res[i, j] = a[i, j] - b[i, j];
                sum += a[i, j] + b[i, j];
            }

        avg = sum / 18.0;
        return res;
    }

    static void Print(int[,] m)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write($"{m[i, j],4}");
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] b = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

        double avg;
        int[,] sum = Add(a, b, out avg);

        Console.WriteLine("Сложение:");
        Print(sum);
        Console.WriteLine($"Среднее значение: {avg}");

        int[,] diff = Sub(a, b, out avg);
        Console.WriteLine("\nВычитание:");
        Print(diff);
        Console.WriteLine($"Среднее значение: {avg}");
    }
}
