namespace cong
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
            this.txt_so1 = new System.Windows.Forms.TextBox();
            this.txt_so2 = new System.Windows.Forms.TextBox();
            this.bt_cong = new System.Windows.Forms.Button();
            this.lb_kq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_so1
            // 
            this.txt_so1.Location = new System.Drawing.Point(69, 59);
            this.txt_so1.Name = "txt_so1";
            this.txt_so1.Size = new System.Drawing.Size(100, 20);
            this.txt_so1.TabIndex = 0;
            // 
            // txt_so2
            // 
            this.txt_so2.Location = new System.Drawing.Point(69, 119);
            this.txt_so2.Name = "txt_so2";
            this.txt_so2.Size = new System.Drawing.Size(100, 20);
            this.txt_so2.TabIndex = 1;
            // 
            // bt_cong
            // 
            this.bt_cong.Location = new System.Drawing.Point(69, 158);
            this.bt_cong.Name = "bt_cong";
            this.bt_cong.Size = new System.Drawing.Size(75, 23);
            this.bt_cong.TabIndex = 2;
            this.bt_cong.Text = "cong";
            this.bt_cong.UseVisualStyleBackColor = true;
            this.bt_cong.Click += new System.EventHandler(this.bt_cong_Click);
            // 
            // lb_kq
            // 
            this.lb_kq.AutoSize = true;
            this.lb_kq.Location = new System.Drawing.Point(184, 95);
            this.lb_kq.Name = "lb_kq";
            this.lb_kq.Size = new System.Drawing.Size(25, 13);
            this.lb_kq.TabIndex = 3;
            this.lb_kq.Text = "[kq]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.lb_kq);
            this.Controls.Add(this.bt_cong);
            this.Controls.Add(this.txt_so2);
            this.Controls.Add(this.txt_so1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_so1;
        private System.Windows.Forms.TextBox txt_so2;
        private System.Windows.Forms.Button bt_cong;
        private System.Windows.Forms.Label lb_kq;
    }
}

