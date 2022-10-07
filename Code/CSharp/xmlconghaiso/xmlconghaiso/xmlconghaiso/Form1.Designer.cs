namespace xmlconghaiso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_so1 = new System.Windows.Forms.TextBox();
            this.txt_so2 = new System.Windows.Forms.TextBox();
            this.lb_ketqua = new System.Windows.Forms.Label();
            this.bt_cong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cộng Hai Số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết Quả";
            // 
            // txt_so1
            // 
            this.txt_so1.Location = new System.Drawing.Point(47, 59);
            this.txt_so1.Name = "txt_so1";
            this.txt_so1.Size = new System.Drawing.Size(63, 20);
            this.txt_so1.TabIndex = 4;
            // 
            // txt_so2
            // 
            this.txt_so2.Location = new System.Drawing.Point(154, 60);
            this.txt_so2.Name = "txt_so2";
            this.txt_so2.Size = new System.Drawing.Size(78, 20);
            this.txt_so2.TabIndex = 5;
            // 
            // lb_ketqua
            // 
            this.lb_ketqua.AutoSize = true;
            this.lb_ketqua.Location = new System.Drawing.Point(151, 107);
            this.lb_ketqua.Name = "lb_ketqua";
            this.lb_ketqua.Size = new System.Drawing.Size(0, 13);
            this.lb_ketqua.TabIndex = 6;
            // 
            // bt_cong
            // 
            this.bt_cong.Location = new System.Drawing.Point(84, 136);
            this.bt_cong.Name = "bt_cong";
            this.bt_cong.Size = new System.Drawing.Size(75, 23);
            this.bt_cong.TabIndex = 7;
            this.bt_cong.Text = "Cộng";
            this.bt_cong.UseVisualStyleBackColor = true;
            this.bt_cong.Click += new System.EventHandler(this.bt_cong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 184);
            this.Controls.Add(this.bt_cong);
            this.Controls.Add(this.lb_ketqua);
            this.Controls.Add(this.txt_so2);
            this.Controls.Add(this.txt_so1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "XML Cong Hai So";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_so1;
        private System.Windows.Forms.TextBox txt_so2;
        private System.Windows.Forms.Label lb_ketqua;
        private System.Windows.Forms.Button bt_cong;
    }
}

