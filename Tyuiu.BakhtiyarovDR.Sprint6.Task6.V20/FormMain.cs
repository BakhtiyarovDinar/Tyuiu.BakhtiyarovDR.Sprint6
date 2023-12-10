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
using Tyuiu.BakhtiyarovDR.Sprint6.Task6.V20.Libb;

namespace Tyuiu.BakhtiyarovDR.Sprint6.Task6.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonDone_BDR_Click(object sender, EventArgs e)
        {
            textBoxResult_BDR.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpenFile_BDR_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxLoadFromFile_BDR.Text = File.ReadAllText(openFilePath);
            groupBoxOutput_BDR.Text = groupBoxOutput_BDR.Text + " " + openFileDialogTask.FileName; ;
            buttonDone_BDR.Enabled = true;
        }

        private void buttonInfo_BDR_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
    }
}
