using System;

namespace Задание_1
{
    class Student
    {
        private string fam, name;
        private int kyrs, year;

        public string Fam
        {
            get { 
                return (fam != "") ? fam : "Неизвестный"; 
            }
            set { fam = value.ToUpper(); }
        }

        public string Name
        {
            get { 
                return (name != "") ? name : "Неизвестный"; 
            }
            set { name = value.ToUpper(); }
        }

        public int Kyrs
        {
            get => kyrs; set { kyrs = (value < 1 || value > 4) ? 0 : value; }
        }

        public int Year
        {
            get => year; set { year = (value < 14 || value > 36) ? 0 : value; }
        }

        public Student(string fam, string name, int kyrs, int year)
        {
            this.Fam = fam; this.Kyrs = kyrs; this.Year = year; this.Name = name;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nКурс: {2}\nВозраст: {3}\n", Fam, Name, kyrs, year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Студенты:");
            Student st1 = new Student("Иванов", "Артем", 3, 17);
            st1.ShowInfo();
            Student st2 = new Student("", "", -7, 40);
            st2.ShowInfo();
            Console.ReadKey();
        }
    }
}
