using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string s = Console.ReadLine();

        string[] words = s.Trim('.').Split(' ');
        StringBuilder sb = new StringBuilder();

        for (int i = words.Length - 1; i >= 0; i--)
        {
            sb.Append(words[i]);
            sb.Append(" ");
        }

        Console.WriteLine(sb.ToString().Trim() + ".");
    }
}
