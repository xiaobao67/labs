using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите N: ");
        int N = int.Parse(Console.ReadLine());

        bool found = false;

        for (int x = 1; x * x * x <= N; x++)
            for (int y = 1; y * y * y <= N; y++)
                for (int z = 1; z * z * z <= N; z++)
                    if (x * x * x + y * y * y + z * z * z == N)
                    {
                        Console.WriteLine($"x={x}, y={y}, z={z}");
                        found = true;
                    }

        if (!found)
            Console.WriteLine("No such combinations!");
    }
}
