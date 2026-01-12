using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string s = Console.ReadLine();

        foreach (string w in s.Split(' ', ',', '.'))
        {
            if (w.Length >= 3 &&
                w[0] >= 'A' && w[0] <= 'Z' &&
                char.IsDigit(w[^1]) && char.IsDigit(w[^2]))
            {
                Console.WriteLine(w);
            }
        }
    }
}
