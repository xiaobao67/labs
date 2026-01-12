using System;
namespace Lab1_Task5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите длину первого катета: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите длину второго катета: ");
            double b = double.Parse(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            double area = (a * b) / 2;
            double perimeter = (a + b + c);
            Console.Write($"Площадь прямоугольного треугольника равна: {area}, периметр равен: {perimeter}");
            Console.ReadKey();
        }
    }
}
