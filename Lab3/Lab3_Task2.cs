using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
            arr[i] = rnd.Next(-30, 46);

        Console.WriteLine("Массив:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{arr[i],4}");
            if ((i + 1) % 10 == 0)
                Console.WriteLine();
        }

        Console.WriteLine("\nВ обратном порядке (без отрицательных):");
        for (int i = n - 1; i >= 0; i--)
        {
            if (arr[i] >= 0)
                Console.Write($"{arr[i]} ");
        }
    }
}
