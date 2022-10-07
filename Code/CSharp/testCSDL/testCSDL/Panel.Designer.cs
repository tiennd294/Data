namespace testCSDL
{
    partial class Panel
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
            this.btnsv = new System.Windows.Forms.Button();
            this.btnmonhoc = new System.Windows.Forms.Button();
            this.btnkhoa = new System.Windows.Forms.Button();
            this.btnketqua = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsv
            // 
            this.btnsv.Location = new System.Drawing.Point(28, 12);
            this.btnsv.Name = "btnsv";
            this.btnsv.Size = new System.Drawing.Size(111, 45);
            this.btnsv.TabIndex = 0;
            this.btnsv.Text = "Danh Sach Sinh Vien";
            this.btnsv.UseVisualStyleBackColor = true;
            this.btnsv.Click += new System.EventHandler(this.btnsv_Click);
            // 
            // btnmonhoc
            // 
            this.btnmonhoc.Location = new System.Drawing.Point(155, 12);
            this.btnmonhoc.Name = "btnmonhoc";
            this.btnmonhoc.Size = new System.Drawing.Size(111, 45);
            this.btnmonhoc.TabIndex = 1;
            this.btnmonhoc.Text = "Mon Hoc";
            this.btnmonhoc.UseVisualStyleBackColor = true;
            // 
            // btnkhoa
            // 
            this.btnkhoa.Location = new System.Drawing.Point(28, 73);
            this.btnkhoa.Name = "btnkhoa";
            this.btnkhoa.Size = new System.Drawing.Size(111, 45);
            this.btnkhoa.TabIndex = 2;
            this.btnkhoa.Text = "Khoa";
            this.btnkhoa.UseVisualStyleBackColor = true;
            // 
            // btnketqua
            // 
            this.btnketqua.Location = new System.Drawing.Point(155, 73);
            this.btnketqua.Name = "btnketqua";
            this.btnketqua.Size = new System.Drawing.Size(111, 45);
            this.btnketqua.TabIndex = 3;
            this.btnketqua.Text = "Ket Qua";
            this.btnketqua.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(90, 138);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(118, 37);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 216);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnketqua);
            this.Controls.Add(this.btnkhoa);
            this.Controls.Add(this.btnmonhoc);
            this.Controls.Add(this.btnsv);
            this.Name = "Panel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsv;
        private System.Windows.Forms.Button btnmonhoc;
        private System.Windows.Forms.Button btnkhoa;
        private System.Windows.Forms.Button btnketqua;
        private System.Windows.Forms.Button btnexit;
    }
}