﻿namespace DemoUserControl
{
    partial class Form1
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
            this.userControl12 = new DemoUserControl.UserControl1();
            this.userControl11 = new DemoUserControl.UserControl1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl12.Location = new System.Drawing.Point(50, 21);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(150, 150);
            this.userControl12.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl11.Location = new System.Drawing.Point(80, 73);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(150, 150);
            this.userControl11.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControl12);
            this.panel1.Location = new System.Drawing.Point(298, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private UserControl1 userControl12;
        private System.Windows.Forms.Panel panel1;

    }
}

