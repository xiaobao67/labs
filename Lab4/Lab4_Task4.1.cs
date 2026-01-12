using System;

class Program
{
    static bool HasCom(string s)
    {
        string word = "";
        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c) || c == '.')
                word += c;
            else
            {
                if (word.EndsWith(".com", StringComparison.OrdinalIgnoreCase))
                    return true;
                word = "";
            }
        }
        return word.EndsWith(".com", StringComparison.OrdinalIgnoreCase);
    }

    static void Main()
    {
        string[] lines = new string[7];
        int minSpaces = int.MaxValue, minIndex = 0;

        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Строка {i + 1}: ");
            lines[i] = Console.ReadLine();

            int spaces = 0;
            foreach (char c in lines[i])
                if (c == ' ') spaces++;

            if (spaces < minSpaces)
            {
                minSpaces = spaces;
                minIndex = i;
            }
        }

        Console.WriteLine("\nСтроки с .com:");
        foreach (string s in lines)
            if (HasCom(s))
                Console.WriteLine(s);

        Console.WriteLine($"\nМинимум пробелов в строке № {minIndex + 1}");
    }
}
