using System;
using System.Windows.Forms;

namespace Чек
{
    public partial class Form1 : Form
    {
        public double p, d, a, ds, v, t, f, b = 0, j = 0, q = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelData.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKorzina_Click(object sender, EventArgs e)
        { 
            p = Convert.ToDouble(textBoxPrise.Text);        //Цена
            d = Convert.ToDouble(textBoxSkidka.Text);      //Скидка %
            a = Convert.ToDouble(numericUpDownCol.Text);  //Кол-во
            ds = p * (d / 100.0);   //Величина скидки
            f = p - ds;            //Цена со скидкой
            v = 0.13 * f;         //НДС
            t = (f + v) * a;     //Итоговая цена товара

            b += p;       //Цена всех товаров
            q += ds;     //Сумма скидки
            j += t;     //Вся сумма

            //Вывод расчетов
            textBoxInf.Text += "Товар: " + textBoxName.Text + Environment.NewLine;
            textBoxInf.Text += "Цена: " + p.ToString("0.00") + Environment.NewLine;
            textBoxInf.Text += "Скидка: " + ds.ToString("0.00") + Environment.NewLine;
            textBoxInf.Text += "Цена со скидкой: " + f.ToString("0.00") + Environment.NewLine;
            textBoxInf.Text += "НДС (13%): " + v.ToString("0.00") + Environment.NewLine;
            textBoxInf.Text += "Итого: " + t.ToString("0.00") + Environment.NewLine + Environment.NewLine;
        }

        private void buttonKorzinaDel_Click(object sender, EventArgs e)
        {
            textBoxInf.Clear(); textBoxSum.Clear(); textBoxSkid.Clear(); textBoxKassa.Clear();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxPrise_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l >= '0' && l <= '9')
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBoxSkidka_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l >= '0' && l <= '9')
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void groupBoxItog_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxItog.Visible = true;
            buttonChekc.Enabled = false;

            //Чек
            textBoxSum.Text += b.ToString("0.00") + Environment.NewLine;
            textBoxSkid.Text += q.ToString("0.00") + Environment.NewLine;
            textBoxKassa.Text += j.ToString("0.00") + Environment.NewLine;

            timer.Stop();
        }
    }
}
