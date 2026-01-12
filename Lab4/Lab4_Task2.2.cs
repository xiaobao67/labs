using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string s = Console.ReadLine();

        char[] sep = { ' ', ',', '-', '–' };
        string[] words = s.Split(sep, StringSplitOptions.RemoveEmptyEntries);

        int i = 1;
        foreach (string w in words)
        {
            s = s.Replace(w, w + $"({i})");
            i++;
        }

        Console.WriteLine(s);
    }
}
