using System;

namespace Lab1_Indiv1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Вариант 3");

            string[] titles = new string[3];
            string[] directors = new string[3];
            int[] years = new int[3];
            string[] types = new string[3];
                        
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ввод данных для фильма №{i + 1}");
                Console.Write("Название: ");
                titles[i] = Console.ReadLine();

                Console.Write("Режиссер: ");
                directors[i] = Console.ReadLine();

                Console.Write("Год выпуска: ");
                years[i] = int.Parse(Console.ReadLine());

                Console.Write("Тип (К/А/М): ");
                types[i] = Console.ReadLine();
                Console.WriteLine();
            }
            Console.Clear();

            string line = new string('-', 69);

            Console.WriteLine(line);
            Console.WriteLine("| {0, -65} |", "Кинопродукция");
            Console.WriteLine(line);

            Console.WriteLine("| {0, -20} | {1, -20} | {2, -12} | {3, -4} |", "Фильм", "Режиссер", "Год выпуска", "Тип");
            Console.WriteLine(line);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("| {0, -20} | {1, -20} | {2, -12} | {3, -4} |", titles[i], directors[i], years[i], types[i]);
            }
            Console.WriteLine(line);
            Console.WriteLine("| {0, -65} |", "Перечисляемый тип: Д-драма, К-комедия, М-мелодрама, Б-боевик,");
            Console.WriteLine("| {0, -65} |", "А-мультфильм");
            Console.WriteLine(line);
            Console.ReadKey();
        }
    }
}
