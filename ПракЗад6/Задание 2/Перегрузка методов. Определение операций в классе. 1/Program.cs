using System;

namespace Перегрузка_методов._Определение_операций_в_классе._1
{
    class Zakaz
    {
        private string fam, comfort;
        private int size;
        public Zakaz (string fm, int sz, string cmf)
        {
            fam = fm; size = sz; comfort = cmf;
        }
        public Zakaz(string fm, int sz)
        {
            fam = fm; size = sz; comfort = "Стандарт";
        }
        public Zakaz(string fm)
        {
            fam = fm; size = 3; comfort = "Стандарт";
        }
        public Zakaz()
        {
            fam = "Неизвестный"; size = 6; comfort = "Хостел";
        }
        public void Show()
        {
            Console.WriteLine("{0} забронировал {1} местный номер класса {2}", fam, size, comfort);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2"); // Задание 2
            Zakaz z1 = new Zakaz("Иванов", 1, "Люкс");
            z1.Show();
            Zakaz z2 = new Zakaz("Петров", 2);
            z2.Show();
            Zakaz z3 = new Zakaz("Сидоров");
            z3.Show();
            Zakaz z4 = new Zakaz();
            z4.Show();

            //while (q == "q")
            //{
            //    Console.WriteLine("Для выхода введите q");
            //    string q = Convert.ToString(Console.ReadLine());
            //}

            Console.ReadKey();
        }
    }
}
