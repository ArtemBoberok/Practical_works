//пр.р.2 БобриковАА
using System;

namespace Задание1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание1
            Console.Write("Задание 1\nСтепени 2 от 0 до 20\n");
            for (int j = 0; j <= 20; j++)
            {
                Console.Write("Степень " + j + " ");
                Console.WriteLine(Math.Pow(2, j));
            }

            //Задание2
            Console.Write("\nЗадание 2\nВведите е: ");
            double S = 0, m = 1, i = 1;
            double e = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите целое число х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            do
            {
                m = Math.Pow(-1, i - 1) * i / Math.Pow(x, i);
                S += m;
                i++;
            } while (Math.Abs(m) > e);
            Console.WriteLine("S = " + S);

            //Задание3
            Console.Write("\nЗадание 3\n");
            double b = 10, d = 0, q = 0;
            while (q <= 100)
            {
                q += b;
                b *= 1.1;
                d++;
            }
            Console.WriteLine("Суммарный пробег превысил 100км в " + d + " день");

            //Задание4
            int a = 1;
            Console.Write("\nЗадание 4\n");
            for (int j = 3; j <= 24; j += 3)
            {
                Console.Write("Час: " + j + " Амеб: ");
                Console.WriteLine(a *= 2);
            }
        }
    }
}
