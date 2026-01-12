using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        string word;

        if (n % 100 >= 11 && n % 100 <= 14)
            word = "лет";
        else if (n % 10 == 1)
            word = "год";
        else if (n % 10 >= 2 && n % 10 <= 4)
            word = "года";
        else
            word = "лет";

        Console.WriteLine($"{n} {word}");
    }
}
