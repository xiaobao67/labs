using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string s = Console.ReadLine();

        string[] words = s.Trim('.').Split(' ');
        Array.Reverse(words);

        Console.WriteLine(string.Join(" ", words) + ".");
    }
}
