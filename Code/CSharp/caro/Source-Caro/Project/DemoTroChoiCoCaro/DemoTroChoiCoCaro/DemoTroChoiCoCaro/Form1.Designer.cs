namespace DemoTroChoiCoCaro
{
    partial class frmCoCaro
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsComToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlayervsPlayer = new System.Windows.Forms.Button();
            this.btnPlayervsCom = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChoiMoi = new System.Windows.Forms.Button();
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.tmChuChay = new System.Windows.Forms.Timer(this.components);
            this.pnlChuChay = new System.Windows.Forms.Panel();
            this.lblChuoiChu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnlChuChay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ediotToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerVsPlayerToolStripMenuItem,
            this.playerVsComToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // playerVsPlayerToolStripMenuItem
            // 
            this.playerVsPlayerToolStripMenuItem.Name = "playerVsPlayerToolStripMenuItem";
            this.playerVsPlayerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.playerVsPlayerToolStripMenuItem.Text = "Player vs Player";
            this.playerVsPlayerToolStripMenuItem.Click += new System.EventHandler(this.PvsP);
            // 
            // playerVsComToolStripMenuItem
            // 
            this.playerVsComToolStripMenuItem.Name = "playerVsComToolStripMenuItem";
            this.playerVsComToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.playerVsComToolStripMenuItem.Text = "Player vs Com";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // ediotToolStripMenuItem
            // 
            this.ediotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.ediotToolStripMenuItem.Name = "ediotToolStripMenuItem";
            this.ediotToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.ediotToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // btnPlayervsPlayer
            // 
            this.btnPlayervsPlayer.Location = new System.Drawing.Point(24, 425);
            this.btnPlayervsPlayer.Name = "btnPlayervsPlayer";
            this.btnPlayervsPlayer.Size = new System.Drawing.Size(189, 36);
            this.btnPlayervsPlayer.TabIndex = 3;
            this.btnPlayervsPlayer.Text = "Player vs Player";
            this.btnPlayervsPlayer.UseVisualStyleBackColor = true;
            // 
            // btnPlayervsCom
            // 
            this.btnPlayervsCom.Location = new System.Drawing.Point(24, 467);
            this.btnPlayervsCom.Name = "btnPlayervsCom";
            this.btnPlayervsCom.Size = new System.Drawing.Size(189, 31);
            this.btnPlayervsCom.TabIndex = 3;
            this.btnPlayervsCom.Text = "Player vs Com";
            this.btnPlayervsCom.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(24, 513);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnChoiMoi
            // 
            this.btnChoiMoi.Location = new System.Drawing.Point(127, 513);
            this.btnChoiMoi.Name = "btnChoiMoi";
            this.btnChoiMoi.Size = new System.Drawing.Size(86, 33);
            this.btnChoiMoi.TabIndex = 3;
            this.btnChoiMoi.Text = "Chơi mới";
            this.btnChoiMoi.UseVisualStyleBackColor = true;
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlBanCo.Location = new System.Drawing.Point(222, 46);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(501, 501);
            this.pnlBanCo.TabIndex = 4;
            this.pnlBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBanCo_Paint);
            this.pnlBanCo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBanCo_MouseClick);
            // 
            // tmChuChay
            // 
            this.tmChuChay.Interval = 25;
            this.tmChuChay.Tick += new System.EventHandler(this.tmChuChay_Tick);
            // 
            // pnlChuChay
            // 
            this.pnlChuChay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChuChay.Controls.Add(this.lblChuoiChu);
            this.pnlChuChay.Location = new System.Drawing.Point(24, 239);
            this.pnlChuChay.Name = "pnlChuChay";
            this.pnlChuChay.Size = new System.Drawing.Size(189, 180);
            this.pnlChuChay.TabIndex = 5;
            // 
            // lblChuoiChu
            // 
            this.lblChuoiChu.AutoSize = true;
            this.lblChuoiChu.Location = new System.Drawing.Point(3, 167);
            this.lblChuoiChu.Name = "lblChuoiChu";
            this.lblChuoiChu.Size = new System.Drawing.Size(0, 13);
            this.lblChuoiChu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DemoTroChoiCoCaro.Properties.Resources.ccr_gioithieu;
            this.pictureBox1.Location = new System.Drawing.Point(24, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmCoCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlChuChay);
            this.Controls.Add(this.pnlBanCo);
            this.Controls.Add(this.btnChoiMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPlayervsCom);
            this.Controls.Add(this.btnPlayervsPlayer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCoCaro";
            this.Text = "Cờ Caro";
            this.Load += new System.EventHandler(this.frmCoCaro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlChuChay.ResumeLayout(false);
            this.pnlChuChay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsComToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Button btnPlayervsPlayer;
        private System.Windows.Forms.Button btnPlayervsCom;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChoiMoi;
        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.Timer tmChuChay;
        private System.Windows.Forms.Panel pnlChuChay;
        private System.Windows.Forms.Label lblChuoiChu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

