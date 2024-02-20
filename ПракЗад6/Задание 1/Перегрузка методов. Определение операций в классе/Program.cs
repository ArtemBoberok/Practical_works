using System;

namespace Перегрузка_методов._Определение_операций_в_классе
{
    class Program
    {
        static void Perim(int a, int b)
        {
            Console.WriteLine("Периметр прямоугольника = {0}", 2 * a + 2 * b);
        }
        static void Perim(int a, int b, int d)
        {
            Console.WriteLine("Периметр треугольника = {0}", a + b + d);
        }
        static void Perim(params int[] ar)
        {
            int p = 0;
            foreach (int x in ar)
                p += x;
            Console.WriteLine("Периметр {0} угольника = {1}", ar.Length, p);
        }
        static void Perim(int a)
        {
            Console.WriteLine("Периметр квадрата = {0}", 4 * a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1"); // Задание 1
            Perim(10, 20);
            Perim(3, 4, 5);
            Perim(2, 3, 4, 5, 6, 7, 9);
            Perim(5);
            Console.ReadKey();
        }
    }
}
