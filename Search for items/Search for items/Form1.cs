using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_for_items
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        int itemCount = 5;
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (PictureBox pictureBox in panel1.Controls)
            {
                pictureBox.BackColor = Color.Transparent;
                labelInf.Text = "Вам необходимо найти предметы: \nБанан Ананас Мяч Лупа Яблоко" + "\nВсего осталось " + itemCount.ToString() + " предмета/ов";
            }
        }

        private int ms = 0, m, s;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).Visible = false;
            itemCount--;
            if (itemCount <= 0)
            {
                timer.Stop();
                MessageBox.Show("Вы нашли все предметы", "Поздравляем!");          
            }
            else labelInf.Text = "Вам необходимо найти предметы: \nБанан Ананас Мяч Лупа Яблоко" + "\nВсего осталось " + itemCount.ToString() + " предмета/ов";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ms++;
            s = ms / 10;
            m = s / 60;
            labelTime.Text = m + ":" + s % 60 + "." + ms % 10;
        }
    }
}
