using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string s = Console.ReadLine();

        char[] chars = s.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < chars.Length; j++)
                if (chars[i] == chars[j])
                    count++;

            if (count == 1)
                Console.Write(chars[i] + " ");
        }
    }
}
