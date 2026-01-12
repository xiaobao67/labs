using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string s = Console.ReadLine();

        foreach (char c in s)
            if (s.IndexOf(c) == s.LastIndexOf(c))
                Console.Write(c + " ");
    }
}
