using System;
namespace Lab1_Task2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите количество секунд: ");
            int seconds =
                int.Parse(Console.ReadLine());
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            Console.WriteLine($"Прошло полных часов: {hours}");
            Console.WriteLine($"Прошло полных минут: {minutes}");
            Console.ReadKey();
                    }
    }
}
