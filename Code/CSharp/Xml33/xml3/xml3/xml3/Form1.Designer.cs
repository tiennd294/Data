namespace xml3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_kq = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_ketqua = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_so1
            // 
            this.txt_so1.Location = new System.Drawing.Point(42, 12);
            this.txt_so1.Name = "txt_so1";
            this.txt_so1.Size = new System.Drawing.Size(95, 20);
            this.txt_so1.TabIndex = 0;
            // 
            // txt_so2
            // 
            this.txt_so2.Location = new System.Drawing.Point(171, 12);
            this.txt_so2.Name = "txt_so2";
            this.txt_so2.Size = new System.Drawing.Size(100, 20);
            this.txt_so2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "so a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "so b";
            // 
            // bt_kq
            // 
            this.bt_kq.Location = new System.Drawing.Point(12, 177);
            this.bt_kq.Name = "bt_kq";
            this.bt_kq.Size = new System.Drawing.Size(75, 23);
            this.bt_kq.TabIndex = 4;
            this.bt_kq.Text = "Add";
            this.bt_kq.UseVisualStyleBackColor = true;
            this.bt_kq.Click += new System.EventHandler(this.bt_kq_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "tong";
            // 
            // lb_ketqua
            // 
            this.lb_ketqua.AutoSize = true;
            this.lb_ketqua.Location = new System.Drawing.Point(311, 15);
            this.lb_ketqua.Name = "lb_ketqua";
            this.lb_ketqua.Size = new System.Drawing.Size(0, 13);
            this.lb_ketqua.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(349, 127);
            this.dataGridView1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 223);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_ketqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_kq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_so2);
            this.Controls.Add(this.txt_so1);
            this.Name = "Form1";
            this.Text = "CT_TinhTong";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_so1;
        private System.Windows.Forms.TextBox txt_so2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_kq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_ketqua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}

