using System;
using System.Collections.Generic;

class Program
{
    static char[,] table = new char[5, 5];

    static void BuildTable(string key)
    {
        key = key.ToUpper().Replace("J", "I");
        string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        string used = "";

        foreach (char c in key + alphabet)
            if (!used.Contains(c))
                used += c;

        int k = 0;
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                table[i, j] = used[k++];
    }

    static (int, int) Find(char c)
    {
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                if (table[i, j] == c)
                    return (i, j);
        return (-1, -1);
    }

    static string Prepare(string text)
    {
        text = text.ToUpper().Replace("J", "I");
        string res = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (!char.IsLetter(text[i])) continue;

            res += text[i];
            if (i + 1 < text.Length && text[i] == text[i + 1])
                res += 'X';
        }

        if (res.Length % 2 != 0)
            res += 'X';

        return res;
    }

    static string Encrypt(string text)
    {
        string result = "";

        for (int i = 0; i < text.Length; i += 2)
        {
            var a = Find(text[i]);
            var b = Find(text[i + 1]);

            if (a.Item1 == b.Item1)
            {
                result += table[a.Item1, (a.Item2 + 1) % 5];
                result += table[b.Item1, (b.Item2 + 1) % 5];
            }
            else if (a.Item2 == b.Item2)
            {
                result += table[(a.Item1 + 1) % 5, a.Item2];
                result += table[(b.Item1 + 1) % 5, b.Item2];
            }
            else
            {
                result += table[a.Item1, b.Item2];
                result += table[b.Item1, a.Item2];
            }
        }

        return result;
    }

    static string Decrypt(string text)
    {
        string result = "";

        for (int i = 0; i < text.Length; i += 2)
        {
            var a = Find(text[i]);
            var b = Find(text[i + 1]);

            if (a.Item1 == b.Item1)
            {
                result += table[a.Item1, (a.Item2 + 4) % 5];
                result += table[b.Item1, (b.Item2 + 4) % 5];
            }
            else if (a.Item2 == b.Item2)
            {
                result += table[(a.Item1 + 4) % 5, a.Item2];
                result += table[(b.Item1 + 4) % 5, b.Item2];
            }
            else
            {
                result += table[a.Item1, b.Item2];
                result += table[b.Item1, a.Item2];
            }
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Введите ключ: ");
        string key = Console.ReadLine();

        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        BuildTable(key);
        string prepared = Prepare(text);

        string encrypted = Encrypt(prepared);
        string decrypted = Decrypt(encrypted);

        Console.WriteLine("Зашифрованный текст:");
        Console.WriteLine(encrypted);

        Console.WriteLine("Расшифрованный текст:");
        Console.WriteLine(decrypted);
    }
}
