using System;
namespace МЕТОДЫ_И_ПАРАМЕТРЫ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Console.Write("Задание 1\nВведите 3 числа: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Максимальное число: " + Main1(c, Main1(a, b)));

            Console.Write("\nВведите 2 числа: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Максимальное число: " + Main1(d, e));
            // Задание 2
            Console.Write("\nЗадание 2\nВведите два числа: ");
            int f = Convert.ToInt32(Console.ReadLine());
            int g = Convert.ToInt32(Console.ReadLine());
            Main2(f, g);
            // Задание 3
            Console.Write("\nЗадание 3\nВведите два числа: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ответ: " + Math.Max(a1, b1 * 3 + 4) * Math.Max(3 - a1 * 2, b1 - 7));
        }
        static int Main1(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main2(int c, int d)
        {
            Console.WriteLine("Первое число: " + d);
            Console.WriteLine("Второе число: " + c);
        }
    }
}