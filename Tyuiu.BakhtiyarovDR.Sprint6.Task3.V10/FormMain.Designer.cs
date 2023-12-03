
namespace Tyuiu.BakhtiyarovDR.Sprint6.Task3.V10
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
            this.groupBoxTask_BDR = new System.Windows.Forms.GroupBox();
            this.dataGridViewInputMatrix_BDR = new System.Windows.Forms.DataGridView();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_BDR = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOutputMatrix_BDR = new System.Windows.Forms.DataGridView();
            this.buttonStartCode_BDR = new System.Windows.Forms.Button();
            this.buttonSpravka_BDR = new System.Windows.Forms.Button();
            this.groupBoxTask_BDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputMatrix_BDR)).BeginInit();
            this.groupBoxOutputData_BDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputMatrix_BDR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_BDR
            // 
            this.groupBoxTask_BDR.Controls.Add(this.dataGridViewInputMatrix_BDR);
            this.groupBoxTask_BDR.Controls.Add(this.textBoxUslovie);
            this.groupBoxTask_BDR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_BDR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_BDR.Name = "groupBoxTask_BDR";
            this.groupBoxTask_BDR.Size = new System.Drawing.Size(449, 391);
            this.groupBoxTask_BDR.TabIndex = 2;
            this.groupBoxTask_BDR.TabStop = false;
            this.groupBoxTask_BDR.Text = "Условие";
            // 
            // dataGridViewInputMatrix_BDR
            // 
            this.dataGridViewInputMatrix_BDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInputMatrix_BDR.ColumnHeadersVisible = false;
            this.dataGridViewInputMatrix_BDR.Location = new System.Drawing.Point(6, 57);
            this.dataGridViewInputMatrix_BDR.Name = "dataGridViewInputMatrix_BDR";
            this.dataGridViewInputMatrix_BDR.ReadOnly = true;
            this.dataGridViewInputMatrix_BDR.RowHeadersVisible = false;
            this.dataGridViewInputMatrix_BDR.Size = new System.Drawing.Size(254, 209);
            this.dataGridViewInputMatrix_BDR.TabIndex = 1;
            // 
            // textBoxUslovie
            // 
            this.textBoxUslovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie.Location = new System.Drawing.Point(6, 21);
            this.textBoxUslovie.Multiline = true;
            this.textBoxUslovie.Name = "textBoxUslovie";
            this.textBoxUslovie.ReadOnly = true;
            this.textBoxUslovie.Size = new System.Drawing.Size(437, 63);
            this.textBoxUslovie.TabIndex = 0;
            this.textBoxUslovie.TabStop = false;
            this.textBoxUslovie.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в пятой строке на 0.";
            // 
            // groupBoxOutputData_BDR
            // 
            this.groupBoxOutputData_BDR.Controls.Add(this.label1);
            this.groupBoxOutputData_BDR.Controls.Add(this.dataGridViewOutputMatrix_BDR);
            this.groupBoxOutputData_BDR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_BDR.Location = new System.Drawing.Point(467, 13);
            this.groupBoxOutputData_BDR.Name = "groupBoxOutputData_BDR";
            this.groupBoxOutputData_BDR.Size = new System.Drawing.Size(480, 390);
            this.groupBoxOutputData_BDR.TabIndex = 7;
            this.groupBoxOutputData_BDR.TabStop = false;
            this.groupBoxOutputData_BDR.Text = "Вывод данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Результат:";
            // 
            // dataGridViewOutputMatrix_BDR
            // 
            this.dataGridViewOutputMatrix_BDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutputMatrix_BDR.ColumnHeadersVisible = false;
            this.dataGridViewOutputMatrix_BDR.Location = new System.Drawing.Point(6, 56);
            this.dataGridViewOutputMatrix_BDR.Name = "dataGridViewOutputMatrix_BDR";
            this.dataGridViewOutputMatrix_BDR.ReadOnly = true;
            this.dataGridViewOutputMatrix_BDR.RowHeadersVisible = false;
            this.dataGridViewOutputMatrix_BDR.Size = new System.Drawing.Size(254, 209);
            this.dataGridViewOutputMatrix_BDR.TabIndex = 1;
            // 
            // buttonStartCode_BDR
            // 
            this.buttonStartCode_BDR.BackColor = System.Drawing.Color.Green;
            this.buttonStartCode_BDR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonStartCode_BDR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartCode_BDR.Location = new System.Drawing.Point(803, 409);
            this.buttonStartCode_BDR.Name = "buttonStartCode_BDR";
            this.buttonStartCode_BDR.Size = new System.Drawing.Size(101, 38);
            this.buttonStartCode_BDR.TabIndex = 8;
            this.buttonStartCode_BDR.Text = "Выполнить";
            this.buttonStartCode_BDR.UseVisualStyleBackColor = false;
            this.buttonStartCode_BDR.Click += new System.EventHandler(this.buttonStartCode_BDR_Click);
            // 
            // buttonSpravka_BDR
            // 
            this.buttonSpravka_BDR.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonSpravka_BDR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSpravka_BDR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpravka_BDR.Location = new System.Drawing.Point(760, 409);
            this.buttonSpravka_BDR.Name = "buttonSpravka_BDR";
            this.buttonSpravka_BDR.Size = new System.Drawing.Size(37, 38);
            this.buttonSpravka_BDR.TabIndex = 9;
            this.buttonSpravka_BDR.Text = "?";
            this.buttonSpravka_BDR.UseVisualStyleBackColor = false;
            this.buttonSpravka_BDR.Click += new System.EventHandler(this.buttonSpravka_BDR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.buttonSpravka_BDR);
            this.Controls.Add(this.buttonStartCode_BDR);
            this.Controls.Add(this.groupBoxOutputData_BDR);
            this.Controls.Add(this.groupBoxTask_BDR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 10 | Бахтияров Д.Р. ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_BDR.ResumeLayout(false);
            this.groupBoxTask_BDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputMatrix_BDR)).EndInit();
            this.groupBoxOutputData_BDR.ResumeLayout(false);
            this.groupBoxOutputData_BDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputMatrix_BDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_BDR;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.DataGridView dataGridViewInputMatrix_BDR;
        private System.Windows.Forms.GroupBox groupBoxOutputData_BDR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOutputMatrix_BDR;
        private System.Windows.Forms.Button buttonStartCode_BDR;
        private System.Windows.Forms.Button buttonSpravka_BDR;
    }
}

