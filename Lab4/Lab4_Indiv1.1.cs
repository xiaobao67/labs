using System;

class Program
{
    static char Shift(char c, int k)
    {
        if (char.IsUpper(c))
            return (char)('A' + (c - 'A' + k + 26) % 26);

        if (char.IsLower(c))
            return (char)('a' + (c - 'a' + k + 26) % 26);

        return c;
    }

    static string Encrypt(string text, int k)
    {
        string result = "";
        foreach (char c in text)
            result += Shift(c, k);
        return result;
    }

    static string Decrypt(string text, int k)
    {
        return Encrypt(text, -k);
    }

    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        Console.Write("Введите сдвиг: ");
        int k = int.Parse(Console.ReadLine());

        string encrypted = Encrypt(text, k);
        string decrypted = Decrypt(encrypted, k);

        Console.WriteLine("Зашифрованный текст:");
        Console.WriteLine(encrypted);

        Console.WriteLine("Расшифрованный текст:");
        Console.WriteLine(decrypted);
    }
}
