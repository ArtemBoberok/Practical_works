using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pw15
{
    public partial class Form1 : Form
    {
        private int m, s, ms;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled)
            {
                timer2.Stop();
                buttonStartStop.Text = "Старт";
            }
            else
            {
                timer2.Start();
                buttonStartStop.Text = "Стоп";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ms++;
            s = ms / 10;
            m = s / 60;
            labelTimer.Text = m + ":" + s % 60 + "." + ms % 10;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled)
            {
                timer2.Stop();
            }
            else
            {
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = 0; s = 0; ms = 0;
            labelTimer.Text = "0:0.0";
        }  
    }
}
