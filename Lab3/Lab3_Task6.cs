using System;

class Program
{
    static int SumIterative(int[] a)
    {
        int sum = 0;
        foreach (int x in a)
            sum += x;
        return sum;
    }

    static int SumRecursive(int[] a, int n)
    {
        if (n == 0) return 0;
        return a[n - 1] + SumRecursive(a, n - 1);
    }

    static int MinIterative(int[] a)
    {
        int min = a[0];
        foreach (int x in a)
            if (x < min) min = x;
        return min;
    }

    static int MinRecursive(int[] a, int n)
    {
        if (n == 1) return a[0];
        int min = MinRecursive(a, n - 1);
        return a[n - 1] < min ? a[n - 1] : min;
    }

    static void Main()
    {
        int[] arr = { 3, 7, -2, 5, 1 };

        Console.WriteLine("Сумма (итеративно): " + SumIterative(arr));
        Console.WriteLine("Сумма (рекурсивно): " + SumRecursive(arr, arr.Length));

        Console.WriteLine("Минимум (итеративно): " + MinIterative(arr));
        Console.WriteLine("Минимум (рекурсивно): " + MinRecursive(arr, arr.Length));
    }
}
