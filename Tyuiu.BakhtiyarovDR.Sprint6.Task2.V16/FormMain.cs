using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BakhtiyarovDR.Sprint6.Task2.V16.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint6.Task2.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_BDR_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_BDR.Text);
                int stopStep = Convert.ToInt32(textBoxStop_BDR.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_BDR.Titles.Add("График функции F(x) = Cos(x) / x - 0,4 + Sin(x) * 8x + 2");
                this.chartFunction_BDR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_BDR.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_BDR.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_BDR.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_BDR_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_BDR.BackColor = Color.Blue;
        }

        private void buttonDone_BDR_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_BDR.BackColor = Color.Red;
        }

        private void buttonDone_BDR_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_BDR.BackColor = Color.Green;
        }

        private void buttonInfo_BDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-3 Бахтияров Динар Русланович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
