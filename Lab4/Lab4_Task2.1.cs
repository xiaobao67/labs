using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string s = Console.ReadLine();

        int word = 0;
        bool inWord = false;

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (char.IsLetter(c))
            {
                if (!inWord)
                {
                    inWord = true;
                    word++;
                }
                Console.Write(c);
            }
            else
            {
                if (inWord)
                {
                    Console.Write($"({word})");
                    inWord = false;
                }
                Console.Write(c);
            }
        }
    }
}
