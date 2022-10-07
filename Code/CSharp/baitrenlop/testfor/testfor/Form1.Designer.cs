namespace testfor
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(12, 12);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(137, 30);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhap 1 Phan tu mang";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(167, 12);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(85, 30);
            this.txtNhap.TabIndex = 1;
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(258, 12);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(45, 47);
            this.btnTang.TabIndex = 2;
            this.btnTang.Text = "Sap Tang";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Location = new System.Drawing.Point(258, 65);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(45, 47);
            this.btnGiam.TabIndex = 4;
            this.btnGiam.Text = "Sap Giam";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(15, 125);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(84, 29);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In Mang";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(118, 125);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 29);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(219, 125);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(84, 29);
            this.btnDung.TabIndex = 7;
            this.btnDung.Text = "Dung";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.Location = new System.Drawing.Point(15, 48);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(237, 71);
            this.lblKQ.TabIndex = 8;
            this.lblKQ.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 169);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.btnNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.RichTextBox lblKQ;

    }
}

