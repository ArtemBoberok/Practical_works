using System;
namespace Lab9_BobrikovAA
{
    interface ITransport
    {
        void Gear_Changing();
        void Speed_Up();
        void Speed_Down();
        void Condition();
        void Fuel_Up();
        void Maintenance();
        void Turn();
    }
    interface IBicycle
    {
        void PulseB();
    }
    // Велосипед
    class Bicycle : ITransport, IBicycle
    {
        private int gear; private int speed; private string turn; private int pulse;
        public int Gear
        {
            get { return gear; }
            set
            {
                gear = (value > 5) ? 0 : value;
            }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                speed = (value > 10) ? 10 : value;
                if (speed < 0) { speed = 0; }
            }
        }
        public string Turns
        {
            get { return turn; }
            set
            {
                turn = "Прямо";
                if (value == "Направо" || value == "Налево") { turn = value; }
            }
        }
        public int Pulse
        {
            get { return pulse; }
            set
            {
                pulse = (value > 130) ? 130 : value;
                if (pulse < 60) { pulse = 60; }
            }
        }
        public Bicycle() { }

        public void Gear_Changing()
        {
            Console.WriteLine("На какую передачу сменить?\n(От 1 до 5)");
            this.Gear = Convert.ToInt32(Console.ReadLine());
        }
        public void Speed_Up()
        {
            Console.WriteLine("Ускориться на?\n(От 1 до 10)");
            int a = Convert.ToInt32(Console.ReadLine());
            Speed += a;
        }
        public void Speed_Down()
        {
            Console.WriteLine("Снизить скорость на?\n(От 1 до 10)");
            int a = Convert.ToInt32(Console.ReadLine());
            Speed -= a;
        }
        public void Condition()
        {
            Console.WriteLine("\nТекущая передача: {0}\nТекущая скорость: {1}\nНаправление: {2}\nПульс: {3}\n", Gear, speed, turn, pulse);
        }
        public void Fuel_Up() { }
        public void Maintenance()
        {

        }
        public void Turn()
        {
            Console.WriteLine("В какую сторону повернуть?\n(Налево или Направо)");
            this.Turns = Console.ReadLine();
        }
        public void PulseB()
        {
            Console.WriteLine("Пульс велосепедиста?\n(От 60 до 130)");
            this.Pulse = Convert.ToInt32(Console.ReadLine());
            Pulse += Speed * 10;
        }
    }
    // Легковой автомобиль
    class Car : ITransport
    {
        private int gear; private int speed; private int fuel; private string turn;
        public int Gear
        {
            get { return gear; }
            set
            {
                gear = (value > 6) ? 0 : value;
            }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                speed = (value > 120) ? 120 : value;
                if (speed < 0) { speed = 0; }
            }
        }
        public int Fuel
        {
            get { return fuel; }
            set
            {
                fuel = (value > 60) ? 60 : value;
                if (fuel < 0) { fuel = 0; }
            }
        }
        public string Turns
        {
            get { return turn; }
            set
            {
                turn = "Прямо";
                if (value == "Направо" || value == "Налево") { turn = value; }
            }
        }
        public Car() { }

        public void Gear_Changing()
        {
            Console.WriteLine("На какую передачу сменить?\n(От 1 до 6)");
            this.Gear = Convert.ToInt32(Console.ReadLine());
        }
        public void Speed_Up()
        {
            Console.WriteLine("Ускориться на?\n(От 1 до 120)");
            int a = Convert.ToInt32(Console.ReadLine());
            Speed += a;
        }
        public void Speed_Down()
        {
            Console.WriteLine("Снизить скорость на?\n(От 1 до 120)");
            int a = Convert.ToInt32(Console.ReadLine());
            Speed -= a;
        }
        public void Condition()
        {
            Console.WriteLine("\nТекущая передача: {0}\nТекущая скорость: {1}\nТекущий объём топлива: {2}\nНаправление: {3}\n", gear, speed, fuel, turn);
        }
        public void Fuel_Up()
        {
            Console.WriteLine("Сколько залить топлива?\n(От 0 до 60)");
            this.Fuel = Convert.ToInt32(Console.ReadLine());
        }
        public void Maintenance()
        {

        }
        public void Turn()
        {
            Console.WriteLine("В какую сторону повернуть?\n(Налево или Направо)");
            this.Turns = Console.ReadLine();
        }
    }
    // Грузовой автомобиль
    class Diesel : ITransport
    {
        private int gear; private int speed; private int fuel; private string turn;
        public int Gear
        {
            get { return gear; }
            set
            {
                gear = (value > 7) ? 0 : value;
            }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                speed = (value > 100) ? 100 : value;
                if (speed < 0) { speed = 0; }
            }
        }
        public int Fuel
        {
            get { return fuel; }
            set
            {
                fuel = (value > 70) ? 70 : value;
                if (fuel < 0) { fuel = 0; }
            }
        }
        public string Turns
        {
            get { return turn; }
            set
            {
                turn = "Прямо";
                if (value == "Направо" || value == "Налево") { turn = value; }
            }
        }
        public Diesel() { }

        public void Gear_Changing()
        {
            Console.WriteLine("На какую передачу сменить?\n(От 1 до 7)");
            this.Gear = Convert.ToInt32(Console.ReadLine());
        }
        public void Speed_Up()
        {
            Console.WriteLine("Ускориться на?\n(От 1 до 100)");
            int a = Convert.ToInt32(Console.ReadLine());
            Speed += a;
        }
        public void Speed_Down()
        {
            Console.WriteLine("Снизить скорость на?\n(От 1 до 100)");
            int a = Convert.ToInt32(Console.ReadLine());
            Speed -= a;
        }
        public void Condition()
        {
            Console.WriteLine("\nТекущая передача: {0}\nТекущая скорость: {1}\nТекущий объём топлива: {2}\nНаправление: {3}\n", gear, speed, fuel, turn);
        }
        public void Fuel_Up()
        {
            Console.WriteLine("Сколько залить топлива?\n(От 0 до 70)");
            this.Fuel = Convert.ToInt32(Console.ReadLine());
        }
        public void Maintenance()
        {

        }
        public void Turn()
        {
            Console.WriteLine("В какую сторону повернуть?\n(Налево или Направо)");
            this.Turns = Console.ReadLine();
        }
    }
    // Бульдозер
    class Bulldozer : ITransport
    {
        private int gear; private int speed; private int fuel; private string turn;
        public int Gear
        {
            get { return gear; }
            set
            {
                gear = (value > 4) ? 0 : value;
            }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                speed = (value > 50) ? 50 : value;
                if (speed < 0) { speed = 0; }
            }
        }
        public int Fuel
        {
            get { return fuel; }
            set
            {
                fuel = (value > 80) ? 80 : value;
                if (fuel < 0) { fuel = 0; }
            }
        }
        public string Turns
        {
            get { return turn; }
            set
            {
                turn = "Прямо";
                if (value == "Направо" || value == "Налево") { turn = value; }
            }
        }
        public Bulldozer() { }

        public void Gear_Changing()
        {
            Console.WriteLine("На какую передачу сменить?\n(От 1 до 4)");
            this.Gear = Convert.ToInt32(Console.ReadLine());
        }
        public void Speed_Up()
        {
            Console.WriteLine("Ускориться на?\n(От 1 до 50)");
            int a = Convert.ToInt32(Console.ReadLine());
            Speed += a;
        }
        public void Speed_Down()
        {
            Console.WriteLine("Снизить скорость на?\n(От 1 до 50)");
            int a = Convert.ToInt32(Console.ReadLine());
            Speed -= a;
        }
        public void Condition()
        {
            Console.WriteLine("\nТекущая передача: {0}\nТекущая скорость: {1}\nТекущий объём топлива: {2}\nНаправление: {3}\n", gear, speed, fuel, turn);
        }
        public void Fuel_Up()
        {
            Console.WriteLine("Сколько залить топлива?\n(От 0 до 80)");
            this.Fuel = Convert.ToInt32(Console.ReadLine());
        }
        public void Maintenance()
        {

        }
        public void Turn()
        {
            Console.WriteLine("В какую сторону повернуть?\n(Налево или Направо)");
            this.Turns = Console.ReadLine();
        }
    }
    // Торговое судно
    class Ship : ITransport
    {
        private int gear; private int speed; private int fuel; private string turn;
        public int Gear
        {
            get { return gear; }
            set
            {
                gear = (value > 10) ? 0 : value;
            }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                speed = (value > 200) ? 200 : value;
                if (speed < 0) { speed = 0; }
            }
        }
        public int Fuel
        {
            get { return fuel; }
            set
            {
                fuel = (value > 100) ? 100 : value;
                if (fuel < 0) { fuel = 0; }
            }
        }
        public string Turns
        {
            get { return turn; }
            set
            {
                turn = "Прямо";
                if (value == "Направо" || value == "Налево") { turn = value; }
            }
        }
        public Ship() { }

        public void Gear_Changing()
        {
            Console.WriteLine("На какую передачу сменить?\n(От 1 до 10)");
            this.Gear = Convert.ToInt32(Console.ReadLine());
        }
        public void Speed_Up()
        {
            Console.WriteLine("Ускориться на?\n(От 1 до 200)");
            int a = Convert.ToInt32(Console.ReadLine());
            Speed += a;
        }
        public void Speed_Down()
        {
            Console.WriteLine("Снизить скорость на?\n(От 1 до 200)");
            int a = Convert.ToInt32(Console.ReadLine());
            Speed -= a;
        }
        public void Condition()
        {
            Console.WriteLine("\nТекущая передача: {0}\nТекущая скорость: {1}\nТекущий объём топлива: {2}\nНаправление: {3}\n", gear, speed, fuel, turn);
        }
        public void Fuel_Up()
        {
            Console.WriteLine("Сколько залить топлива?\n(От 0 до 100)");
            this.Fuel = Convert.ToInt32(Console.ReadLine());
        }
        public void Maintenance()
        {

        }
        public void Turn()
        {
            Console.WriteLine("В какую сторону повернуть?\n(Налево или Направо)");
            this.Turns = Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Велосипед
            Console.WriteLine("\tВелосипед");
            Bicycle bi = new Bicycle();
            ITransport Tbi = bi;
            IBicycle Tbic = bi;
            Tbi.Gear_Changing();
            Tbi.Speed_Up();
            Tbi.Speed_Down();
            Tbi.Maintenance();
            Tbi.Turn();
            Tbic.PulseB();
            Tbi.Condition();
            // Легковой автомобиль
            Console.WriteLine("\tЛегковой автомобиль");
            Car ca = new Car();
            ITransport Tca = ca;
            Tca.Gear_Changing();
            Tca.Speed_Up();
            Tca.Speed_Down();
            Tca.Fuel_Up();
            Tca.Maintenance();
            Tca.Turn();
            Tca.Condition();
            // Грузовой автомобиль
            Console.WriteLine("\tГрузовой автомобиль");
            Diesel di = new Diesel();
            ITransport Tdi = di;
            Tdi.Gear_Changing();
            Tdi.Speed_Up();
            Tdi.Speed_Down();
            Tdi.Maintenance();
            Tdi.Turn();
            Tdi.Condition();
            // Бульдозер
            Console.WriteLine("\tБульдозер");
            Bulldozer bu = new Bulldozer();
            ITransport Tbu = bu;
            Tbu.Gear_Changing();
            Tbu.Speed_Up();
            Tbu.Speed_Down();
            Tbu.Maintenance();
            Tbu.Turn();
            Tbu.Condition();
            // Торговое судно
            Console.WriteLine("\tТорговое судно");
            Ship sh = new Ship();
            ITransport Tsh = sh;
            Tsh.Gear_Changing();
            Tsh.Speed_Up();
            Tsh.Speed_Down();
            Tsh.Maintenance();
            Tsh.Turn();
            Tsh.Condition();
            Console.ReadKey();
        }
    }
}