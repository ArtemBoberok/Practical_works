using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel1 = Microsoft.Office.Interop.Excel;

namespace Pw21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        int n = 0;  // Строки
        int m = 1;  // Столбцы

        // Заполнение таблицы студентами
        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            n = 0;        
            dataGridViewGroup.TopLeftHeaderCell.Value = "ФИО";  // Ячейка левого верхнего угла таблицы
            dataGridViewGroup.RowHeadersWidth = 150;        	// Ширина столбца заголовков строк

            string Group = comboBoxGroup.SelectedItem.ToString();
            int i = 0;
            try
            {
                StreamReader sr = new StreamReader(Group + ".txt");
                while (!sr.EndOfStream)
                {
                    sr.ReadLine();
                    n++;
                }
                sr.Close();
                dataGridViewGroup.RowCount = n + 1;    // Строки

                sr = new StreamReader(Group + ".txt");
                while (!sr.EndOfStream)
                {
                    dataGridViewGroup.Rows[i].HeaderCell.Value = sr.ReadLine();
                    i++;
                }
                sr.Close();
                dataGridViewGroup.Rows[i].HeaderCell.Value = "Средний балл:";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения \n" + ex.ToString());
            }          
        }

        // Заполнение 
        private void comboBoxObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewGroup.ColumnCount = m;
            dataGridViewGroup.Columns[m-1].HeaderCell.Value = comboBoxObjects.SelectedItem.ToString();
            m += 1;
        }

        private void buttonVed_Click(object sender, EventArgs e)
        {
            buttonVed.Enabled = false;
            for (int i = 0; i < n; i++)         //Цикл по строкам таблицы
            {
                for (int j = 0; j < m-1; j++)   //Цикл по столбцам таблицы
                {
                    dataGridViewGroup.Rows[i].Cells[j].Value = rand.Next(2, 6);
                }
            }

            for (int i = 0; i < n; i++)             //Все строки
                for (int j = 0; j < m - 1; j++)     //Все столбцы
                {
                    dataGridViewGroup[j, i].ToolTipText = "Ячейка";       //Текст всплывающей подсказки
                    dataGridViewGroup[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridViewGroup[j, i].Style.SelectionBackColor = Color.Green;   //Фон выделенной ячейки
                    dataGridViewGroup[j, i].Style.SelectionForeColor = Color.White;   //Текст выделенной ячейки
                    if (dataGridViewGroup[j, i].Value.ToString() == "2")              //Проверка значения в ячейке
                    {
                        dataGridViewGroup[j, i].Style.BackColor = Color.Red;          //Цвет фон для 5
                        dataGridViewGroup[j, i].Style.ForeColor = Color.Yellow;       //Цвет текста для 5
                    }
                }
        }

        private void buttonBall_Click(object sender, EventArgs e)
        {
            buttonBall.Enabled = false;
            double[] ball = new double[dataGridViewGroup.ColumnCount];
            for (int i = 0; i < dataGridViewGroup.ColumnCount; i++)
            {
                double result = 0;
                for (int j = 0; j < dataGridViewGroup.RowCount - 1; j++)
                {
                    result+= Convert.ToDouble(dataGridViewGroup[i, j].Value);
                }
                ball[i] = result / (dataGridViewGroup.RowCount - 1);
                dataGridViewGroup[i, dataGridViewGroup.RowCount - 1].Value = Math.Round(ball[i], 2);
            }
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            buttonChart.Enabled = false;
            chartBall.Series[0].Points.Clear();
            for(int i =0; i < m -1; i++)
            {
                chartBall.Series[0].Points.AddXY(dataGridViewGroup.Columns[i].HeaderCell.Value, dataGridViewGroup[i, dataGridViewGroup.RowCount - 1].Value);
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            var application = new Excel1.Application();
            application.SheetsInNewWorkbook = 1;
            Excel1.Workbook workbook = application.Workbooks.Add(Type.Missing);

            Excel1.Worksheet worksheet = application.Worksheets.Item[1];
            worksheet.Name = "Оценки";
            worksheet.Cells[1, 1] = dataGridViewGroup.Columns[0].HeaderCell.Value;
            worksheet.Cells[1, 2] = dataGridViewGroup.Columns[1].HeaderCell.Value;

            int n = 5;// Fio.Length;
            for (int i = 2; i < n + 2; i++)
            {
                worksheet.Cells[i, 1] = dataGridViewGroup[0, i - 2].Value;
                worksheet.Cells[i, 2] = dataGridViewGroup[1, i - 2].Value;
            }
            application.Visible = true;
        }
    }
}
