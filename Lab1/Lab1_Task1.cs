using System;
namespace Lab1_Task1
{ class Program
    { static void Main()
        { Console.Write("Введите число ");
            double x = 
                double.Parse(Console.ReadLine());
            int d = (int)(x * 10 % 10);
            Console.WriteLine($"Первая цифра дробной части числа {x} – {d}");
            Console.ReadKey();
        }
    }
}
