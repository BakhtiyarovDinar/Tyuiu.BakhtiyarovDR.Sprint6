
namespace Tyuiu.BakhtiyarovDR.Sprint6.Task2.V16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_BDR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BDR = new System.Windows.Forms.TextBox();
            this.groupBoxDataInPut_BDR = new System.Windows.Forms.GroupBox();
            this.textBoxStart_BDR = new System.Windows.Forms.TextBox();
            this.textBoxStop_BDR = new System.Windows.Forms.TextBox();
            this.labelStartStep_BDR = new System.Windows.Forms.Label();
            this.labelStopStep_BDR = new System.Windows.Forms.Label();
            this.buttonInfo_BDR = new System.Windows.Forms.Button();
            this.buttonDone_BDR = new System.Windows.Forms.Button();
            this.groupBoxDataOutPut_BDR = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_BDR = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_BDR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_BDR = new System.Windows.Forms.Label();
            this.groupBoxCondition_BDR.SuspendLayout();
            this.groupBoxDataInPut_BDR.SuspendLayout();
            this.groupBoxDataOutPut_BDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_BDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BDR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_BDR
            // 
            this.groupBoxCondition_BDR.Controls.Add(this.textBoxTask_BDR);
            this.groupBoxCondition_BDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_BDR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_BDR.Name = "groupBoxCondition_BDR";
            this.groupBoxCondition_BDR.Size = new System.Drawing.Size(568, 316);
            this.groupBoxCondition_BDR.TabIndex = 0;
            this.groupBoxCondition_BDR.TabStop = false;
            this.groupBoxCondition_BDR.Text = "Условие";
            // 
            // textBoxTask_BDR
            // 
            this.textBoxTask_BDR.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_BDR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_BDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_BDR.Location = new System.Drawing.Point(7, 23);
            this.textBoxTask_BDR.Multiline = true;
            this.textBoxTask_BDR.Name = "textBoxTask_BDR";
            this.textBoxTask_BDR.ReadOnly = true;
            this.textBoxTask_BDR.Size = new System.Drawing.Size(501, 287);
            this.textBoxTask_BDR.TabIndex = 0;
            this.textBoxTask_BDR.Text = "Протабулировать функцию F(x) = Cos(x) / x - 0,4 + Sin(x) * 8x + 2 на заданном диа" +
    "пазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxDataInPut_BDR
            // 
            this.groupBoxDataInPut_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxDataInPut_BDR.Controls.Add(this.labelStopStep_BDR);
            this.groupBoxDataInPut_BDR.Controls.Add(this.labelStartStep_BDR);
            this.groupBoxDataInPut_BDR.Controls.Add(this.textBoxStop_BDR);
            this.groupBoxDataInPut_BDR.Controls.Add(this.textBoxStart_BDR);
            this.groupBoxDataInPut_BDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDataInPut_BDR.Location = new System.Drawing.Point(12, 335);
            this.groupBoxDataInPut_BDR.Name = "groupBoxDataInPut_BDR";
            this.groupBoxDataInPut_BDR.Size = new System.Drawing.Size(308, 100);
            this.groupBoxDataInPut_BDR.TabIndex = 1;
            this.groupBoxDataInPut_BDR.TabStop = false;
            this.groupBoxDataInPut_BDR.Text = "Ввод данных ";
            // 
            // textBoxStart_BDR
            // 
            this.textBoxStart_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxStart_BDR.Location = new System.Drawing.Point(7, 58);
            this.textBoxStart_BDR.Name = "textBoxStart_BDR";
            this.textBoxStart_BDR.Size = new System.Drawing.Size(145, 23);
            this.textBoxStart_BDR.TabIndex = 0;
            // 
            // textBoxStop_BDR
            // 
            this.textBoxStop_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxStop_BDR.Location = new System.Drawing.Point(158, 58);
            this.textBoxStop_BDR.Name = "textBoxStop_BDR";
            this.textBoxStop_BDR.Size = new System.Drawing.Size(143, 23);
            this.textBoxStop_BDR.TabIndex = 1;
            // 
            // labelStartStep_BDR
            // 
            this.labelStartStep_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStartStep_BDR.AutoSize = true;
            this.labelStartStep_BDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartStep_BDR.Location = new System.Drawing.Point(7, 39);
            this.labelStartStep_BDR.Name = "labelStartStep_BDR";
            this.labelStartStep_BDR.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_BDR.TabIndex = 2;
            this.labelStartStep_BDR.Text = "Старт шага:";
            // 
            // labelStopStep_BDR
            // 
            this.labelStopStep_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStopStep_BDR.AutoSize = true;
            this.labelStopStep_BDR.Location = new System.Drawing.Point(158, 39);
            this.labelStopStep_BDR.Name = "labelStopStep_BDR";
            this.labelStopStep_BDR.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_BDR.TabIndex = 3;
            this.labelStopStep_BDR.Text = "Конец шага:";
            // 
            // buttonInfo_BDR
            // 
            this.buttonInfo_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInfo_BDR.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonInfo_BDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_BDR.Location = new System.Drawing.Point(335, 355);
            this.buttonInfo_BDR.Name = "buttonInfo_BDR";
            this.buttonInfo_BDR.Size = new System.Drawing.Size(91, 80);
            this.buttonInfo_BDR.TabIndex = 2;
            this.buttonInfo_BDR.Text = "Справка";
            this.buttonInfo_BDR.UseVisualStyleBackColor = false;
            this.buttonInfo_BDR.Click += new System.EventHandler(this.buttonInfo_BDR_Click);
            // 
            // buttonDone_BDR
            // 
            this.buttonDone_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDone_BDR.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_BDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_BDR.Location = new System.Drawing.Point(432, 355);
            this.buttonDone_BDR.Name = "buttonDone_BDR";
            this.buttonDone_BDR.Size = new System.Drawing.Size(148, 80);
            this.buttonDone_BDR.TabIndex = 3;
            this.buttonDone_BDR.Text = "Выполнить";
            this.buttonDone_BDR.UseVisualStyleBackColor = false;
            this.buttonDone_BDR.Click += new System.EventHandler(this.buttonDone_BDR_Click);
            this.buttonDone_BDR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_BDR_MouseDown);
            this.buttonDone_BDR.MouseEnter += new System.EventHandler(this.buttonDone_BDR_MouseEnter);
            this.buttonDone_BDR.MouseLeave += new System.EventHandler(this.buttonDone_BDR_MouseLeave);
            // 
            // groupBoxDataOutPut_BDR
            // 
            this.groupBoxDataOutPut_BDR.Controls.Add(this.labelResult_BDR);
            this.groupBoxDataOutPut_BDR.Controls.Add(this.chartFunction_BDR);
            this.groupBoxDataOutPut_BDR.Controls.Add(this.dataGridViewFunction_BDR);
            this.groupBoxDataOutPut_BDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDataOutPut_BDR.Location = new System.Drawing.Point(586, 12);
            this.groupBoxDataOutPut_BDR.Name = "groupBoxDataOutPut_BDR";
            this.groupBoxDataOutPut_BDR.Size = new System.Drawing.Size(652, 423);
            this.groupBoxDataOutPut_BDR.TabIndex = 4;
            this.groupBoxDataOutPut_BDR.TabStop = false;
            this.groupBoxDataOutPut_BDR.Text = "Вывод данных ";
            // 
            // dataGridViewFunction_BDR
            // 
            this.dataGridViewFunction_BDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_BDR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dataGridViewFunction_BDR.Location = new System.Drawing.Point(7, 48);
            this.dataGridViewFunction_BDR.Name = "dataGridViewFunction_BDR";
            this.dataGridViewFunction_BDR.RowHeadersVisible = false;
            this.dataGridViewFunction_BDR.Size = new System.Drawing.Size(153, 369);
            this.dataGridViewFunction_BDR.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // F
            // 
            this.F.HeaderText = "F(X)";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            this.F.Width = 50;
            // 
            // chartFunction_BDR
            // 
            chartArea9.Name = "ChartArea1";
            this.chartFunction_BDR.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartFunction_BDR.Legends.Add(legend9);
            this.chartFunction_BDR.Location = new System.Drawing.Point(166, 48);
            this.chartFunction_BDR.Name = "chartFunction_BDR";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.IsVisibleInLegend = false;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartFunction_BDR.Series.Add(series9);
            this.chartFunction_BDR.Size = new System.Drawing.Size(480, 369);
            this.chartFunction_BDR.TabIndex = 1;
            this.chartFunction_BDR.Text = "chart1";
            // 
            // labelResult_BDR
            // 
            this.labelResult_BDR.AutoSize = true;
            this.labelResult_BDR.Location = new System.Drawing.Point(7, 29);
            this.labelResult_BDR.Name = "labelResult_BDR";
            this.labelResult_BDR.Size = new System.Drawing.Size(80, 17);
            this.labelResult_BDR.TabIndex = 2;
            this.labelResult_BDR.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 450);
            this.Controls.Add(this.groupBoxDataOutPut_BDR);
            this.Controls.Add(this.buttonDone_BDR);
            this.Controls.Add(this.buttonInfo_BDR);
            this.Controls.Add(this.groupBoxDataInPut_BDR);
            this.Controls.Add(this.groupBoxCondition_BDR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 16 | Бахтияров Д.Р.";
            this.groupBoxCondition_BDR.ResumeLayout(false);
            this.groupBoxCondition_BDR.PerformLayout();
            this.groupBoxDataInPut_BDR.ResumeLayout(false);
            this.groupBoxDataInPut_BDR.PerformLayout();
            this.groupBoxDataOutPut_BDR.ResumeLayout(false);
            this.groupBoxDataOutPut_BDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_BDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_BDR;
        private System.Windows.Forms.GroupBox groupBoxDataInPut_BDR;
        private System.Windows.Forms.Label labelStopStep_BDR;
        private System.Windows.Forms.Label labelStartStep_BDR;
        private System.Windows.Forms.TextBox textBoxStop_BDR;
        private System.Windows.Forms.TextBox textBoxStart_BDR;
        private System.Windows.Forms.Button buttonInfo_BDR;
        private System.Windows.Forms.Button buttonDone_BDR;
        private System.Windows.Forms.GroupBox groupBoxDataOutPut_BDR;
        private System.Windows.Forms.DataGridView dataGridViewFunction_BDR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.Label labelResult_BDR;
        private System.Windows.Forms.TextBox textBoxTask_BDR;
    }
}

