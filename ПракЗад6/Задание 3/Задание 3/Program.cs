using System;

namespace Задание_3
{
    class Figura
    {
        static void ShowArea(int a)
        {
            Console.WriteLine("Периметр квадрата = {0}", 4 * a);
        }
        static void ShowArea(int a, int b)
        {
            Console.WriteLine("Периметр прямоугольника = {0}", 2 * a + 2 * b);
        }
        static void ShowArea(int a, int b, int d)
        {
            Console.WriteLine("Периметр треугольника = {0}", a + b + d);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3"); // Задание 3
            Console.WriteLine("Введите кол-во значений, от 1 до 3: ");
            double a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Введите параметр: ");
                int b = Convert.ToInt32(Console.ReadLine());
                ShowArea(b);
            }
            else if (a == 2)
            {
                Console.WriteLine("Введите параметры: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                ShowArea(b, c);
            }
            else
            {
                Console.WriteLine("Введите параметры: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                int d = Convert.ToInt32(Console.ReadLine());
                ShowArea(b, c, d);
            }
        }
    }
}
