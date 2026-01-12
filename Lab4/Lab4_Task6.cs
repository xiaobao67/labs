using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Введите выражение: ");
        string s = Console.ReadLine();

        Regex r = new Regex(@"\s*(-?\d+)\s*\+\s*(-?\d+)\s*=\s*(-?\d+)\s*");
        Match m = r.Match(s);

        if (m.Success)
        {
            int a = int.Parse(m.Groups[1].Value);
            int b = int.Parse(m.Groups[2].Value);
            int sum = int.Parse(m.Groups[3].Value);

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"sum = {sum}");
        }
    }
}
