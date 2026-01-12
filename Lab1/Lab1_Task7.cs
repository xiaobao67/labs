using System;
    namespace Lab1_Task7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите трехзначное число: ");
            int n = int.Parse(Console.ReadLine());
            int a = n / 100;
            int b = (n / 10) % 10;
            int c = n % 10;
            int reversed = (c * 100) + (b * 10) + a;
            Console.Write($"Число {n} в обратном порядке: {reversed}");
            Console.ReadKey();
        }
    }
}
