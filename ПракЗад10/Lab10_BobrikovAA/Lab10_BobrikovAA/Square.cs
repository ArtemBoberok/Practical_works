using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_BobrikovAA
{
    class Square
    {
        public string NameSqr = "???";
        public double CentSqr;
        public double SideSqr;
        public void Data(string NameSqr, double CentSqr, double SideSqr)
        {
            if (NameSqr != "") this.NameSqr = NameSqr;
            if (CentSqr > 0) this.CentSqr = CentSqr;
            else MessageBox.Show("Центр квадрата должен быть задан положительным числом!", "Ошибка");
            if (SideSqr > 0) this.SideSqr = SideSqr;
            else MessageBox.Show("Сторона квадрата должна быть задана положительным числом!", "Ошибка");
        }
        public void Information()
        {

        }
    }
}
