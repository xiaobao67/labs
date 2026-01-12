using System;

class Program
{
    static void Main()
    {
        string[] lines = new string[7];
        int minSpaces = int.MaxValue, minIndex = 0;

        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Строка {i + 1}: ");
            lines[i] = Console.ReadLine();

            int spaces = lines[i].Split(' ').Length - 1;
            if (spaces < minSpaces)
            {
                minSpaces = spaces;
                minIndex = i;
            }
        }

        Console.WriteLine("\nСтроки с .com:");
        foreach (string s in lines)
            foreach (string w in s.Split(' ', ',', '.'))
                if (w.EndsWith("com", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(s);
                    break;
                }

        Console.WriteLine($"\nМинимум пробелов в строке № {minIndex + 1}");
    }
}
