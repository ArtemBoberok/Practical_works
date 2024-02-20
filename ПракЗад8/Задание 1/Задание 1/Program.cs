using System;

namespace Задание_1
{
    class Computer
    {
        private string mod; private int ram;

        public string Mod
        {
            get { return mod; }
            set { mod = (value != "") ? value : "Неизвестный"; }
        }

        public int Ram
        {
            get { return ram; }
            set { ram = (value < 500) ? 640 : value; }
        }

        public Computer(string mod, int ram)
        {
            this.Mod = mod; this.Ram = ram;
        }

        public void Start()
        {
            Console.WriteLine("Модель: {0}\nОбьем ОЗУ: {1}\n", Mod, Ram);
        }

        public void End()
        {
            Console.WriteLine("Компьютер {0} выключается\n", Mod);
        }
    }
    class Notebook : Computer
    {
        private int time;

        public int Time
        {
            get { return time; }
            set { time = (value < 10) ? 15 : value; }
        }

        public Notebook(string mod, int ram, int time) : base(mod, ram)
        {
            this.Time = time;
        }

        public void End()
        {
            Console.WriteLine("Компьютер {0} выключается, заряд {1} минут\n", Mod, Time);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook no = new Notebook("Asus", 1024, 120);
            no.Start(); no.End();
            Computer co = new Computer("Dell", 4096, 30);
            co.Start(); co.End();
            Console.ReadKey();
        }
    }
}
