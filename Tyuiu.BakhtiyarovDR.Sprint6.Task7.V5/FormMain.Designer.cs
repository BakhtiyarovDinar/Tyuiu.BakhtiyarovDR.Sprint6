﻿
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
            this.SuspendLayout();
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose_BDR;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_BDR;
        private System.Windows.Forms.Label labelInfo_BDR;
    }
}

