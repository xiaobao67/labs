using System;

class Program
{
    static int Determinant(int[,] a, int n)
    {
        if (n == 1)
            return a[0, 0];

        int det = 0;
        int sign = 1;

        for (int f = 0; f < n; f++)
        {
            int[,] temp = new int[n - 1, n - 1];
            int ti = 0;

            for (int i = 1; i < n; i++)
            {
                int tj = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == f) continue;
                    temp[ti, tj++] = a[i, j];
                }
                ti++;
            }

            det += sign * a[0, f] * Determinant(temp, n - 1);
            sign = -sign;
        }

        return det;
    }

    static void Main()
    {
        int[,] a =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Определитель = " + Determinant(a, 3));
    }
}
