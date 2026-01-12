using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());

        int n = arr.Length;
        k %= n;

        for (int s = 0; s < k; s++)
        {
            int first = arr[0];
            for (int i = 0; i < n - 1; i++)
                arr[i] = arr[i + 1];
            arr[n - 1] = first;
        }

        Console.WriteLine("Результат:");
        foreach (int x in arr)
            Console.Write(x + " ");
    }
}
