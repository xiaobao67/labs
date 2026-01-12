using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите c: ");
        double c = double.Parse(Console.ReadLine());

        double d = b * b - 4 * a * c;

        if (d > 0)
        {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"x1 = {x1}, x2 = {x2}");
        }
        else if (d == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"x = {x}");
        }
        else
        {
            double real = -b / (2 * a);
            double imag = Math.Sqrt(-d) / (2 * a);
            Console.WriteLine($"x1 = {real} + i{imag}");
            Console.WriteLine($"x2 = {real} - i{imag}");
        }
    }
}
