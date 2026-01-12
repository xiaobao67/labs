using System;

namespace Lab1_Indiv2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Вариант 3");
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите m: ");
            double m = double.Parse(Console.ReadLine());

            Console.Write("Введите c: ");
            double c = double.Parse(Console.ReadLine());

            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());

            double sinX = Math.Sin(x);
            double z = (sinX / Math.Sqrt(Math.Pow(m, 2) + Math.Pow(sinX, 2))) - (c * m * Math.Log(m * x));

            double s = Math.Exp(-a * x) * Math.Sqrt(x + 1) + Math.Exp(-b * x) * Math.Sqrt(x + 1.5);

            Console.WriteLine("\nРезультаты");
            Console.WriteLine($"Значение z = {z:F4}");
            Console.WriteLine($"Значение s = {s:F4}");
            Console.ReadKey();
        }
    }
}
