using System;

class Program
{
    static int GetQuarter(double x, double y)
    {
        if (x > 0 && y > 0) return 1;
        if (x < 0 && y > 0) return 2;
        if (x < 0 && y < 0) return 3;
        return 4;
    }

    static void Main()
    {
        Console.Write("Введите x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Введите y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Введите x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Введите y2: ");
        double y2 = double.Parse(Console.ReadLine());

        if (x1 == 0  y1 == 0  x2 == 0 || y2 == 0)
        {
            Console.WriteLine("Zero coord");
            return;
        }

        int q1 = GetQuarter(x1, y1);
        int q2 = GetQuarter(x2, y2);

        Console.WriteLine(q1 == q2);
    }
}
