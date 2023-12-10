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
using Tyuiu.BakhtiyarovDR.Sprint6.Task7.V5.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint6.Task7.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_BDR.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_BDR.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_BDR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_BDR_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BDR.ShowDialog();
            openFilePath = openFileDialogTask_BDR.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_BDR.ColumnCount = columns;
            dataGridViewInPut_BDR.RowCount = rows;
            dataGridViewOutPut_BDR.ColumnCount = columns;
            dataGridViewOutPut_BDR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_BDR.Columns[i].Width = 25;
                dataGridViewOutPut_BDR.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_BDR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_BDR.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_BDR.ColumnCount = 50;
            dataGridViewOutPut_BDR.ColumnCount = 50;

            dataGridViewOutPut_BDR.RowCount = 50;
            dataGridViewInPut_BDR.RowCount = 50;

            panelInPut_BDR.Width = this.Width / 2;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_BDR.Columns[i].Width = 25;
                dataGridViewOutPut_BDR.Columns[i].Width = 25;
            }
        }

        private void buttonDone_BDR_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_BDR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_BDR.Enabled = true;
        }
        private void buttonSaveFile_BDR_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_BDR.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_BDR.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_BDR.ShowDialog();

            string path = saveFileDialogMatrix_BDR.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_BDR.RowCount;
            int columns = dataGridViewOutPut_BDR.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_BDR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_BDR.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_BDR_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BDR.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_BDR_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BDR.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_BDR_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BDR.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_BDR_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BDR.ToolTipTitle = "Справка";
        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }
    }
}
