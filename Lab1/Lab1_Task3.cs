using System;
namespace Lab1_Task3
{
class Program
{
    static void Main()
    {
        Console.Write("Введите часы (0-11): ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Введите минуты (0-59): ");
        int minutes = int.Parse(Console.ReadLine());
        Console.Write("Введите секунды (0-59): ");
        int seconds = int.Parse(Console.ReadLine());
        double angle = (hours * 30) + (minutes * 0.5) + (seconds * (0.5 / 60));
        Console.Write($"Угол часовой стрелки: {angle} градусов");
        Console.ReadKey();
    }
}
}
