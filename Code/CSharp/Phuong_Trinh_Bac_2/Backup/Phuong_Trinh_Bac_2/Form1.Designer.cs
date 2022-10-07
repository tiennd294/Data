namespace Phuong_Trinh_Bac_2
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
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.txtNhapB = new System.Windows.Forms.TextBox();
            this.txtNhapC = new System.Windows.Forms.TextBox();
            this.txtXuatX1 = new System.Windows.Forms.TextBox();
            this.txtXuatX2 = new System.Windows.Forms.TextBox();
            this.btmThucHien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNhapA
            // 
            this.txtNhapA.Location = new System.Drawing.Point(41, 21);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(100, 20);
            this.txtNhapA.TabIndex = 0;
            // 
            // txtNhapB
            // 
            this.txtNhapB.Location = new System.Drawing.Point(41, 64);
            this.txtNhapB.Name = "txtNhapB";
            this.txtNhapB.Size = new System.Drawing.Size(100, 20);
            this.txtNhapB.TabIndex = 1;
            // 
            // txtNhapC
            // 
            this.txtNhapC.Location = new System.Drawing.Point(41, 110);
            this.txtNhapC.Name = "txtNhapC";
            this.txtNhapC.Size = new System.Drawing.Size(100, 20);
            this.txtNhapC.TabIndex = 2;
            this.txtNhapC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtXuatX1
            // 
            this.txtXuatX1.Location = new System.Drawing.Point(257, 21);
            this.txtXuatX1.Name = "txtXuatX1";
            this.txtXuatX1.Size = new System.Drawing.Size(100, 20);
            this.txtXuatX1.TabIndex = 3;
            // 
            // txtXuatX2
            // 
            this.txtXuatX2.Location = new System.Drawing.Point(257, 64);
            this.txtXuatX2.Name = "txtXuatX2";
            this.txtXuatX2.Size = new System.Drawing.Size(100, 20);
            this.txtXuatX2.TabIndex = 4;
            // 
            // btmThucHien
            // 
            this.btmThucHien.Location = new System.Drawing.Point(58, 177);
            this.btmThucHien.Name = "btmThucHien";
            this.btmThucHien.Size = new System.Drawing.Size(75, 23);
            this.btmThucHien.TabIndex = 5;
            this.btmThucHien.Text = "Tinh";
            this.btmThucHien.UseVisualStyleBackColor = true;
            this.btmThucHien.Click += new System.EventHandler(this.btmThucHien_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 239);
            this.Controls.Add(this.btmThucHien);
            this.Controls.Add(this.txtXuatX2);
            this.Controls.Add(this.txtXuatX1);
            this.Controls.Add(this.txtNhapC);
            this.Controls.Add(this.txtNhapB);
            this.Controls.Add(this.txtNhapA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhapA;
        private System.Windows.Forms.TextBox txtNhapB;
        private System.Windows.Forms.TextBox txtNhapC;
        private System.Windows.Forms.TextBox txtXuatX1;
        private System.Windows.Forms.TextBox txtXuatX2;
        private System.Windows.Forms.Button btmThucHien;
    }
}

