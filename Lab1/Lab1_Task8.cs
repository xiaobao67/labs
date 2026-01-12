using System;
namespace Lab1_Task8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите действительное число x: ");
            double x = double.Parse(Console.ReadLine());
            double result = (((3 * x - 5) * x + 2) * x - 1) * x + 7;
            Console.Write($"Результат вычисления уравнения: {result}");
            Console.ReadKey();
        }
    }
}
