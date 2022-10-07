namespace cau1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gioiThieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatChuongTrinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baiThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bai1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bai2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.baiThiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gioiThieuToolStripMenuItem,
            this.thoatChuongTrinhToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.heThongToolStripMenuItem.Text = "He Thong";
            // 
            // gioiThieuToolStripMenuItem
            // 
            this.gioiThieuToolStripMenuItem.Name = "gioiThieuToolStripMenuItem";
            this.gioiThieuToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.gioiThieuToolStripMenuItem.Text = "Gioi Thieu";
            this.gioiThieuToolStripMenuItem.Click += new System.EventHandler(this.gioiThieuToolStripMenuItem_Click);
            // 
            // thoatChuongTrinhToolStripMenuItem
            // 
            this.thoatChuongTrinhToolStripMenuItem.Name = "thoatChuongTrinhToolStripMenuItem";
            this.thoatChuongTrinhToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.thoatChuongTrinhToolStripMenuItem.Text = "Thoat chuong trinh    Alt+F4";
            this.thoatChuongTrinhToolStripMenuItem.Click += new System.EventHandler(this.thoatChuongTrinhToolStripMenuItem_Click);
            // 
            // baiThiToolStripMenuItem
            // 
            this.baiThiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bai1ToolStripMenuItem,
            this.bai2ToolStripMenuItem});
            this.baiThiToolStripMenuItem.Name = "baiThiToolStripMenuItem";
            this.baiThiToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.baiThiToolStripMenuItem.Text = "Bai Thi";
            // 
            // bai1ToolStripMenuItem
            // 
            this.bai1ToolStripMenuItem.Name = "bai1ToolStripMenuItem";
            this.bai1ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.bai1ToolStripMenuItem.Text = "Bai 1";
            this.bai1ToolStripMenuItem.Click += new System.EventHandler(this.bai1ToolStripMenuItem_Click);
            // 
            // bai2ToolStripMenuItem
            // 
            this.bai2ToolStripMenuItem.Name = "bai2ToolStripMenuItem";
            this.bai2ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.bai2ToolStripMenuItem.Text = "Bai 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 474);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Câu 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gioiThieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatChuongTrinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baiThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bai1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bai2ToolStripMenuItem;
    }
}

