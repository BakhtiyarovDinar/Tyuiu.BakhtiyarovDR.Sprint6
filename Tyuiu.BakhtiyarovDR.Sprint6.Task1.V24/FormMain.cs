using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BakhtiyarovDR.Sprint6.Task1.V24.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint6.Task1.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBox2.Text);
                int stopStep = Convert.ToInt32(textBox2.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBox4.Text = "";
                textBox4.AppendText("+---------+---------+" + Environment.NewLine);
                textBox4.AppendText("|    X    |   f(x)  |" + Environment.NewLine);
                textBox4.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |  {1, 5:f2}  |", startStep, valueArray[i]);
                    textBox4.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBox4.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУБ-23-3 Бахтияров Динар Русланович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}       

