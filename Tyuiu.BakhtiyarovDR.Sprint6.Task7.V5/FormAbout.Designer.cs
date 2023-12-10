
namespace Tyuiu.BakhtiyarovDR.Sprint6.Task7.V5
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_BDR = new System.Windows.Forms.Panel();
            this.buttonOpenFile_BDR = new System.Windows.Forms.Button();
            this.buttonDone_BDR = new System.Windows.Forms.Button();
            this.buttonSaveFile_BDR = new System.Windows.Forms.Button();
            this.buttonHelp_BDR = new System.Windows.Forms.Button();
            this.panelCondition_BDR = new System.Windows.Forms.Panel();
            this.groupBoxCondition_BDR = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_BDR = new System.Windows.Forms.TextBox();
            this.panelInPut_BDR = new System.Windows.Forms.Panel();
            this.splitterInPut_BDR = new System.Windows.Forms.Splitter();
            this.groupBoxInPut_BDR = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_BDR = new System.Windows.Forms.DataGridView();
            this.panelOutPut_BDR = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_BDR = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_BDR = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_BDR = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_BDR = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_BDR = new System.Windows.Forms.SaveFileDialog();
            this.splitterOutPut_BDR = new System.Windows.Forms.Splitter();
            this.panelButtons_BDR.SuspendLayout();
            this.panelCondition_BDR.SuspendLayout();
            this.groupBoxCondition_BDR.SuspendLayout();
            this.panelInPut_BDR.SuspendLayout();
            this.groupBoxInPut_BDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_BDR)).BeginInit();
            this.panelOutPut_BDR.SuspendLayout();
            this.groupBoxOutPut_BDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_BDR)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_BDR
            // 
            this.panelButtons_BDR.Controls.Add(this.buttonHelp_BDR);
            this.panelButtons_BDR.Controls.Add(this.buttonSaveFile_BDR);
            this.panelButtons_BDR.Controls.Add(this.buttonDone_BDR);
            this.panelButtons_BDR.Controls.Add(this.buttonOpenFile_BDR);
            this.panelButtons_BDR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_BDR.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_BDR.Name = "panelButtons_BDR";
            this.panelButtons_BDR.Size = new System.Drawing.Size(1175, 88);
            this.panelButtons_BDR.TabIndex = 0;
            // 
            // buttonOpenFile_BDR
            // 
            this.buttonOpenFile_BDR.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_BDR.Image")));
            this.buttonOpenFile_BDR.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFile_BDR.Name = "buttonOpenFile_BDR";
            this.buttonOpenFile_BDR.Size = new System.Drawing.Size(90, 72);
            this.buttonOpenFile_BDR.TabIndex = 0;
            this.toolTipButton_BDR.SetToolTip(this.buttonOpenFile_BDR, "Выберите нужный файл для обработки\r\n");
            this.buttonOpenFile_BDR.UseVisualStyleBackColor = true;
            this.buttonOpenFile_BDR.Click += new System.EventHandler(this.buttonOpenFile_BDR_Click);
            this.buttonOpenFile_BDR.MouseEnter += new System.EventHandler(this.buttonOpenFile_BDR_MouseEnter);
            // 
            // buttonDone_BDR
            // 
            this.buttonDone_BDR.Enabled = false;
            this.buttonDone_BDR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_BDR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_BDR.Image")));
            this.buttonDone_BDR.Location = new System.Drawing.Point(109, 13);
            this.buttonDone_BDR.Name = "buttonDone_BDR";
            this.buttonDone_BDR.Size = new System.Drawing.Size(90, 72);
            this.buttonDone_BDR.TabIndex = 0;
            this.toolTipButton_BDR.SetToolTip(this.buttonDone_BDR, "Меняет во второй строке четные числа на 555\r\n");
            this.buttonDone_BDR.UseVisualStyleBackColor = true;
            this.buttonDone_BDR.Click += new System.EventHandler(this.buttonDone_BDR_Click);
            this.buttonDone_BDR.MouseEnter += new System.EventHandler(this.buttonDone_BDR_MouseEnter);
            // 
            // buttonSaveFile_BDR
            // 
            this.buttonSaveFile_BDR.Enabled = false;
            this.buttonSaveFile_BDR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_BDR.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_BDR.Image")));
            this.buttonSaveFile_BDR.Location = new System.Drawing.Point(205, 13);
            this.buttonSaveFile_BDR.Name = "buttonSaveFile_BDR";
            this.buttonSaveFile_BDR.Size = new System.Drawing.Size(90, 72);
            this.buttonSaveFile_BDR.TabIndex = 0;
            this.toolTipButton_BDR.SetToolTip(this.buttonSaveFile_BDR, "Сохранит результат в файле OutPutFileTask7.csv\r\n\r\n");
            this.buttonSaveFile_BDR.UseVisualStyleBackColor = true;
            this.buttonSaveFile_BDR.Click += new System.EventHandler(this.buttonSaveFile_BDR_Click);
            this.buttonSaveFile_BDR.MouseEnter += new System.EventHandler(this.buttonSaveFile_BDR_MouseEnter);
            // 
            // buttonHelp_BDR
            // 
            this.buttonHelp_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_BDR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_BDR.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_BDR.Image")));
            this.buttonHelp_BDR.Location = new System.Drawing.Point(1082, 13);
            this.buttonHelp_BDR.Name = "buttonHelp_BDR";
            this.buttonHelp_BDR.Size = new System.Drawing.Size(90, 72);
            this.buttonHelp_BDR.TabIndex = 0;
            this.toolTipButton_BDR.SetToolTip(this.buttonHelp_BDR, "Сведение о программе\r\n");
            this.buttonHelp_BDR.UseVisualStyleBackColor = true;
            this.buttonHelp_BDR.Click += new System.EventHandler(this.buttonHelp_BDR_Click);
            this.buttonHelp_BDR.MouseEnter += new System.EventHandler(this.buttonHelp_BDR_MouseEnter);
            // 
            // panelCondition_BDR
            // 
            this.panelCondition_BDR.Controls.Add(this.groupBoxCondition_BDR);
            this.panelCondition_BDR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_BDR.Location = new System.Drawing.Point(0, 88);
            this.panelCondition_BDR.Name = "panelCondition_BDR";
            this.panelCondition_BDR.Size = new System.Drawing.Size(1175, 92);
            this.panelCondition_BDR.TabIndex = 1;
            // 
            // groupBoxCondition_BDR
            // 
            this.groupBoxCondition_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCondition_BDR.Controls.Add(this.textBoxCondition_BDR);
            this.groupBoxCondition_BDR.Location = new System.Drawing.Point(13, 7);
            this.groupBoxCondition_BDR.Name = "groupBoxCondition_BDR";
            this.groupBoxCondition_BDR.Size = new System.Drawing.Size(1150, 82);
            this.groupBoxCondition_BDR.TabIndex = 0;
            this.groupBoxCondition_BDR.TabStop = false;
            this.groupBoxCondition_BDR.Text = "Условие:";
            // 
            // textBoxCondition_BDR
            // 
            this.textBoxCondition_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCondition_BDR.Location = new System.Drawing.Point(7, 22);
            this.textBoxCondition_BDR.Multiline = true;
            this.textBoxCondition_BDR.Name = "textBoxCondition_BDR";
            this.textBoxCondition_BDR.ReadOnly = true;
            this.textBoxCondition_BDR.Size = new System.Drawing.Size(1137, 60);
            this.textBoxCondition_BDR.TabIndex = 0;
            this.textBoxCondition_BDR.Text = resources.GetString("textBoxCondition_BDR.Text");
            // 
            // panelInPut_BDR
            // 
            this.panelInPut_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInPut_BDR.Controls.Add(this.groupBoxInPut_BDR);
            this.panelInPut_BDR.Controls.Add(this.splitterInPut_BDR);
            this.panelInPut_BDR.Location = new System.Drawing.Point(0, 187);
            this.panelInPut_BDR.Name = "panelInPut_BDR";
            this.panelInPut_BDR.Size = new System.Drawing.Size(580, 350);
            this.panelInPut_BDR.TabIndex = 2;
            // 
            // splitterInPut_BDR
            // 
            this.splitterInPut_BDR.Location = new System.Drawing.Point(0, 0);
            this.splitterInPut_BDR.Name = "splitterInPut_BDR";
            this.splitterInPut_BDR.Size = new System.Drawing.Size(3, 350);
            this.splitterInPut_BDR.TabIndex = 0;
            this.splitterInPut_BDR.TabStop = false;
            // 
            // groupBoxInPut_BDR
            // 
            this.groupBoxInPut_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInPut_BDR.Controls.Add(this.dataGridViewInPut_BDR);
            this.groupBoxInPut_BDR.Location = new System.Drawing.Point(20, 7);
            this.groupBoxInPut_BDR.Name = "groupBoxInPut_BDR";
            this.groupBoxInPut_BDR.Size = new System.Drawing.Size(557, 340);
            this.groupBoxInPut_BDR.TabIndex = 1;
            this.groupBoxInPut_BDR.TabStop = false;
            this.groupBoxInPut_BDR.Text = "Ввод:";
            // 
            // dataGridViewInPut_BDR
            // 
            this.dataGridViewInPut_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInPut_BDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_BDR.ColumnHeadersVisible = false;
            this.dataGridViewInPut_BDR.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewInPut_BDR.Name = "dataGridViewInPut_BDR";
            this.dataGridViewInPut_BDR.ReadOnly = true;
            this.dataGridViewInPut_BDR.RowHeadersVisible = false;
            this.dataGridViewInPut_BDR.RowHeadersWidth = 51;
            this.dataGridViewInPut_BDR.RowTemplate.Height = 24;
            this.dataGridViewInPut_BDR.Size = new System.Drawing.Size(550, 318);
            this.dataGridViewInPut_BDR.TabIndex = 0;
            // 
            // panelOutPut_BDR
            // 
            this.panelOutPut_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOutPut_BDR.Controls.Add(this.splitterOutPut_BDR);
            this.panelOutPut_BDR.Controls.Add(this.groupBoxOutPut_BDR);
            this.panelOutPut_BDR.Location = new System.Drawing.Point(583, 184);
            this.panelOutPut_BDR.Name = "panelOutPut_BDR";
            this.panelOutPut_BDR.Size = new System.Drawing.Size(592, 364);
            this.panelOutPut_BDR.TabIndex = 3;
            // 
            // groupBoxOutPut_BDR
            // 
            this.groupBoxOutPut_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutPut_BDR.Controls.Add(this.dataGridViewOutPut_BDR);
            this.groupBoxOutPut_BDR.Location = new System.Drawing.Point(4, 7);
            this.groupBoxOutPut_BDR.Name = "groupBoxOutPut_BDR";
            this.groupBoxOutPut_BDR.Size = new System.Drawing.Size(588, 354);
            this.groupBoxOutPut_BDR.TabIndex = 0;
            this.groupBoxOutPut_BDR.TabStop = false;
            this.groupBoxOutPut_BDR.Text = "Вывод:";
            // 
            // dataGridViewOutPut_BDR
            // 
            this.dataGridViewOutPut_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOutPut_BDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_BDR.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_BDR.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewOutPut_BDR.Name = "dataGridViewOutPut_BDR";
            this.dataGridViewOutPut_BDR.ReadOnly = true;
            this.dataGridViewOutPut_BDR.RowHeadersVisible = false;
            this.dataGridViewOutPut_BDR.RowHeadersWidth = 51;
            this.dataGridViewOutPut_BDR.RowTemplate.Height = 24;
            this.dataGridViewOutPut_BDR.Size = new System.Drawing.Size(581, 321);
            this.dataGridViewOutPut_BDR.TabIndex = 0;
            // 
            // openFileDialogTask_BDR
            // 
            this.openFileDialogTask_BDR.FileName = "openFileDialogTask_BDR";
            // 
            // toolTipButton_BDR
            // 
            this.toolTipButton_BDR.IsBalloon = true;
            this.toolTipButton_BDR.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_BDR.ToolTipTitle = "Подсказка";
            // 
            // splitterOutPut_BDR
            // 
            this.splitterOutPut_BDR.Location = new System.Drawing.Point(0, 0);
            this.splitterOutPut_BDR.Name = "splitterOutPut_BDR";
            this.splitterOutPut_BDR.Size = new System.Drawing.Size(3, 364);
            this.splitterOutPut_BDR.TabIndex = 1;
            this.splitterOutPut_BDR.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 539);
            this.Controls.Add(this.panelOutPut_BDR);
            this.Controls.Add(this.panelInPut_BDR);
            this.Controls.Add(this.panelCondition_BDR);
            this.Controls.Add(this.panelButtons_BDR);
            this.MinimumSize = new System.Drawing.Size(1193, 586);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 5 | Бахтияров Д. Р.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons_BDR.ResumeLayout(false);
            this.panelCondition_BDR.ResumeLayout(false);
            this.groupBoxCondition_BDR.ResumeLayout(false);
            this.groupBoxCondition_BDR.PerformLayout();
            this.panelInPut_BDR.ResumeLayout(false);
            this.groupBoxInPut_BDR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_BDR)).EndInit();
            this.panelOutPut_BDR.ResumeLayout(false);
            this.groupBoxOutPut_BDR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_BDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_BDR;
        private System.Windows.Forms.Button buttonOpenFile_BDR;
        private System.Windows.Forms.Button buttonHelp_BDR;
        private System.Windows.Forms.Button buttonSaveFile_BDR;
        private System.Windows.Forms.Button buttonDone_BDR;
        private System.Windows.Forms.Panel panelCondition_BDR;
        private System.Windows.Forms.GroupBox groupBoxCondition_BDR;
        private System.Windows.Forms.TextBox textBoxCondition_BDR;
        private System.Windows.Forms.Panel panelInPut_BDR;
        private System.Windows.Forms.GroupBox groupBoxInPut_BDR;
        private System.Windows.Forms.DataGridView dataGridViewInPut_BDR;
        private System.Windows.Forms.Splitter splitterInPut_BDR;
        private System.Windows.Forms.Panel panelOutPut_BDR;
        private System.Windows.Forms.GroupBox groupBoxOutPut_BDR;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_BDR;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_BDR;
        private System.Windows.Forms.ToolTip toolTipButton_BDR;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_BDR;
        private System.Windows.Forms.Splitter splitterOutPut_BDR;
    }
}