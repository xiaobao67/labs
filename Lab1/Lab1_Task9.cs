using System;

namespace Lab1_Task9
{
    class Program
    {
        static void Main()
        {
            string[] names = { "a1", "b1", "c1", "d1", "a2", "b2", "c2", "d2", "a3", "b3", "c3", "d3" };

            double[] k = new double[12];

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Введите значение {names[i]}: ");
                k[i] = double.Parse(Console.ReadLine());
            }

            double a1 = k[0], b1 = k[1], c1 = k[2], d1 = k[3];
            double a2 = k[4], b2 = k[5], c2 = k[6], d2 = k[7];
            double a3 = k[8], b3 = k[9], c3 = k[10], d3 = k[11];

            double D = a1 * b2 * c3 + b1 * c2 * a3 + c1 * a2 * b3 -
                       c1 * b2 * a3 - b1 * a2 * c3 - a1 * c2 * b3;

            if (Math.Abs(D) < 0.000001)
            {
                Console.WriteLine("\nОпределитель D = 0. Система не имеет единственного решения.");
            }
            else
            {
                double Dx = d1 * b2 * c3 + b1 * c2 * d3 + c1 * d2 * b3 -
                            c1 * b2 * d3 - b1 * d2 * c3 - d1 * c2 * b3;

                double Dy = a1 * d2 * c3 + d1 * c2 * a3 + c1 * a2 * d3 -
                            c1 * d2 * a3 - d1 * a2 * c3 - a1 * c2 * d3;

                double Dz = a1 * b2 * d3 + b1 * d2 * a3 + d1 * a2 * b3 -
                            d1 * b2 * a3 - b1 * a2 * d3 - a1 * d2 * b3;

                double x = Dx / D;
                double y = Dy / D;
                double z = Dz / D;

                Console.WriteLine("\nРезультаты");
                Console.WriteLine($"x = {x:F4}");
                Console.WriteLine($"y = {y:F4}");
                Console.WriteLine($"z = {z:F4}");
            }

            Console.ReadKey();
        }
    }
}
