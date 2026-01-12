using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string s = Console.ReadLine();

        Regex r = new Regex(@"\b[A-Z][a-zA-Z]*\d{2}\b");
        MatchCollection m = r.Matches(s);

        foreach (Match x in m)
            Console.WriteLine(x.Value);
    }
}
