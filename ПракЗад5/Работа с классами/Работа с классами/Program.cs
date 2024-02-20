using System;

namespace Работа_с_классами
{
    class Student
    {
        private string fam, name;
        private int kyrs, year;

        public void SetFam(string fa) { fam = fa; }
        public string GetFam() { return fam; }

        public void SetName(string na) { name = na; }
        public string GetName() { return name; }

        public void SetKyrs(int ky) { kyrs = ky; }
        public int GetKyrs() { return kyrs; }

        public void SetYear(int ye) { year = ye; }
        public int GetYear() { return year; }

        public void SnowInfo()
        {
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nКурс: {2}\nВозраст: {3}\n", fam, name, kyrs, year);
        }
    }
    class Computer
    {
        private string mod;
        private int par;

        public void SetMod(string mo) { mod = mo; }
        public string GetMod() { return mod; }

        public void SetPar(int pr) { par = pr; }
        public int GetPar() { return par; }

        public void Info()
        {
            Console.WriteLine("Модель: {0}\nОбьем ОЗУ: {1}\n", mod, par);
        }
    }
    class Tovar
    {
        private string naz, nal;
        private int cen, col;

        public void SetNaz(string nz) { naz = nz; }
        public string GetNaz() { return naz; }

        public void SetCen(int ce) { cen = ce; }
        public int GetCen() { return cen; }

        public void SetCol(int co) { col = co; }
        public int GetCol() { return col; }

        public void SetNal(string na) { nal = na; }
        public string GetNal() { return nal; }

        public void Kupi()
        {
            Console.WriteLine("Товар: {0}\nЦена: {1}\nНаличие: {2}\nКол-во: {3}\n", naz, cen, nal, col);
        }
    }
    class Pogoda
    {
        private string gor, osa;
        private int tem, sco;

        public void SetGor(string nz) { gor = nz; }
        public string GetGor() { return gor; }

        public void SetTem(int ce) { tem = ce; }
        public int GetTem() { return tem; }

        public void SetSco(int co) { sco = co; }
        public int GetSco() { return sco; }

        public void SetOsa(string na) { osa = na; }
        public string GetOsa() { return osa; }

        public void Kupi()
        {
            Console.WriteLine("Город: {0}\nТемпература: {1}\nОсадки: {2}\nСкорость ветра: {3}\n", gor, tem, osa, sco);
        }
    }
    class Transport
    {
        private string tip, cve;
        private int sco, mas;

        public void SetTip(string fa) { tip = fa; }
        public string GetTip() { return tip; }

        public void SetCve(string na) { cve = na; }
        public string GetCve() { return cve; }

        public void SetSco(int ky) { sco = ky; }
        public int GetSco() { return sco; }

        public void SetMas(int ye) { mas = ye; }
        public int GetMas() { return mas; }

        public void SnowInfo()
        {
            Console.WriteLine("Тип: {0}\nЦвет: {1}\nСкорость: {2}\nМасса: {3}\n", tip, cve, sco, mas);
        }
    }
    class Animal
    {
        private string vid, nam, gol;

        public void Setvid(string fa) { vid = fa; }
        public string Getvid() { return vid; }

        public void Setnam(string na) { nam = na; }
        public string Getnam() { return nam; }

        public void Setgol(string na) { gol = na; }
        public string Getgol() { return gol; }

        public void Golos()
        {
            Console.WriteLine("Вид: {0}\nИмя: {1}\nГолос: {2}\n", vid, nam, gol);
        }
    }
    class Figura
    {
        private string naz;
        private int osn, vis, plo;

        public void Setnaz(string fa) { naz = fa; }
        public string Getnaz() { return naz; }

        public void Setosn(int ky) { osn = ky; }
        public int Getosn() { return osn; }

        public void Setvis(int ye) { vis = ye; }
        public int Getvis() { return vis; }

        public void ShowArea()
        {
            Console.WriteLine("Фигура: {0}\nОснование: {1}\nВысота: {2}\nПлощадь: {3:f2}\n", naz, osn, vis, osn / vis);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Класс 1");
            // Класс Student. Метод ShowInfo выводит фамилию, имя, курс, возраст.
            Student st = new Student();
            st.SetFam("Бобриков"); st.SetName("Артем"); st.SetKyrs(3); st.SetYear(19);
            st.SnowInfo();
            Console.WriteLine("Класс 2");
            // Класс Computer. Метод Info выводит модель (IBM, Asus, Sony) и параметры компьютера (объем ОЗУ и жесткого диска).
            Computer co = new Computer();
            co.SetMod("Sony"); co.SetPar(50);
            co.Info();
            Console.WriteLine("Класс 3");
            // Класс Tovar. Метод Kupi выводит название (тетрадь, книга, ручка), цену, наличие на складе (есть, нет), количество.
            Tovar to = new Tovar();
            to.SetNaz("Книга"); to.SetCen(100); to.SetNal("Есть"); to.SetCol(10);
            to.Kupi();
            Console.WriteLine("Класс 4");
            // Класс Pogoda. Метод Show выводит город (Минск, Брест, Гомель), температуру, осадки (ясно, пасмурно, гроза), направление и скорость ветра.
            Pogoda po = new Pogoda();
            po.SetGor("Брест"); po.SetTem(20); po.SetOsa("Ясно"); po.SetSco(7);
            po.Kupi();
            Console.WriteLine("Класс 5");
            // Kласс Transport. Метод ShowInfo выводит параметры транспортного средства: тип (автомобиль, мотоцикл, велосипед), цвет, скорость, масса.
            Transport tr = new Transport();
            tr.SetTip("Автомобиль"); tr.SetCve("Красный"); tr.SetSco(110); tr.SetMas(55);
            tr.SnowInfo();
            Console.WriteLine("Класс 6");
            // Класс Animal. Метод Golos выводит вид (кошка, собака, попугай), имя(Мурка, Шарик, Кеша), голос(мяу, гав, ррр).
            Animal an = new Animal();
            an.Setvid("Кошка"); an.Setnam("Рыжик"); an.Setgol("Мяу");
            an.Golos();
            Console.WriteLine("Класс 7");
            // Класс Figura. Метод ShowArea выводит название (квадрат, прямоугольник) и параметры фигуры (основание, высоту), вычисляет и выводит площадь.
            //Figura fi = new Figura();
            //fi.Setvid("Кошка"); fi.Setnam("Рыжик"); fi.Setgol("Мяу");
            //fi.ShowArea();
        }
    }
}
