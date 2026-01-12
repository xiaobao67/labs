using System;
namespace Lab1_Task4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите целое число для переменной a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите целое число для переменной b: ");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.Write($"Результат обмена значениями: a={a}, b={b}");
            Console.ReadKey();
        }
    }
}
