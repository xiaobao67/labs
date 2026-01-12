using System;

class Program
{
    static void Main()
    {
        int n = 9;
        int[,] a = new int[n, n];

        int value = 1;
        int top = 0, bottom = n - 1, left = 0, right = n - 1;

        while (value <= n * n)
        {
            for (int j = left; j <= right; j++)
                a[top, j] = value++;
            top++;

            for (int i = top; i <= bottom; i++)
                a[i, right] = value++;
            right--;

            for (int j = right; j >= left; j--)
                a[bottom, j] = value++;
            bottom--;

            for (int i = bottom; i >= top; i--)
                a[i, left] = value++;
            left++;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write($"{a[i, j],4}");
            Console.WriteLine();
        }
    }
}
