using System;

class Program
{
    static int GetShift(char keyChar)
    {
        if (char.IsUpper(keyChar))
            return keyChar - 'A';
        return keyChar - 'a';
    }

    static string Encrypt(string text, string key)
    {
        string result = "";
        int keyIndex = 0;

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                int shift = GetShift(key[keyIndex % key.Length]);
                result += Shift(c, shift);
                keyIndex++;
            }
            else
                result += c;
        }

        return result;
    }

    static string Decrypt(string text, string key)
    {
        string result = "";
        int keyIndex = 0;

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                int shift = GetShift(key[keyIndex % key.Length]);
                result += Shift(c, -shift);
                keyIndex++;
            }
            else
                result += c;
        }

        return result;
    }

    static char Shift(char c, int k)
    {
        if (char.IsUpper(c))
            return (char)('A' + (c - 'A' + k + 26) % 26);
        return (char)('a' + (c - 'a' + k + 26) % 26);
    }

    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        Console.Write("Введите ключ: ");
        string key = Console.ReadLine();

        string encrypted = Encrypt(text, key);
        string decrypted = Decrypt(encrypted, key);

        Console.WriteLine("Зашифрованный текст:");
        Console.WriteLine(encrypted);

        Console.WriteLine("Расшифрованный текст:");
        Console.WriteLine(decrypted);
    }
}
