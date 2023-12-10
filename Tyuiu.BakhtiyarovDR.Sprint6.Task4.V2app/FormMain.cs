using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BakhtiyarovDR.Sprint6.Task4.V2.Lib;
using System.IO;

namespace Tyuiu.BakhtiyarovDR.Sprint6.Task4.V2.App
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void button_Done_BDR_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBox_start_BDR.Text);
                int stop = Convert.ToInt32(textBox_stop_BDR.Text);

                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(start, stop);

                // график функции

                this.chart_grafic_BDR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart_grafic_BDR.ChartAreas[0].AxisY.Title = "Ось Y";

                textBox_Result.Text = "";

                chart_grafic_BDR.Series[0].Points.Clear();
                for (int i = 0; i < len - 1; i++)
                {
                    this.chart_grafic_BDR.Series[0].Points.AddXY(start, valueArray[i]);
                    textBox_Result.AppendText(valueArray[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Spravka_BDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУБ-23-3 Бахтияров Динар Русланович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Save_BDR_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBox_Result.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
