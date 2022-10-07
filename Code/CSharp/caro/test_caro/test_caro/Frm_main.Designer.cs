namespace test_caro
{
    partial class Frm_main
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
            this.PVSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsComToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grlc = new System.Windows.Forms.GroupBox();
            this.lbllc = new System.Windows.Forms.Label();
            this.btnpvp = new System.Windows.Forms.Button();
            this.btnpvc = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.palbanco = new System.Windows.Forms.Panel();
            this.tmtxtlc = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grlc.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
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
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PVSPToolStripMenuItem,
            this.playerVsComToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // PVSPToolStripMenuItem
            // 
            this.PVSPToolStripMenuItem.Name = "PVSPToolStripMenuItem";
            this.PVSPToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.PVSPToolStripMenuItem.Text = "Player vs Player";
            this.PVSPToolStripMenuItem.Click += new System.EventHandler(this.PVSPToolStripMenuItem_Click);
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
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::test_caro.Properties.Resources.ccr_gioithieu;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 127);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grlc
            // 
            this.grlc.Controls.Add(this.lbllc);
            this.grlc.Location = new System.Drawing.Point(12, 202);
            this.grlc.Name = "grlc";
            this.grlc.Size = new System.Drawing.Size(193, 169);
            this.grlc.TabIndex = 2;
            this.grlc.TabStop = false;
            this.grlc.Text = "Luat choi";
            // 
            // lbllc
            // 
            this.lbllc.AutoSize = true;
            this.lbllc.Location = new System.Drawing.Point(11, 89);
            this.lbllc.Name = "lbllc";
            this.lbllc.Size = new System.Drawing.Size(0, 13);
            this.lbllc.TabIndex = 4;
            // 
            // btnpvp
            // 
            this.btnpvp.Location = new System.Drawing.Point(28, 395);
            this.btnpvp.Name = "btnpvp";
            this.btnpvp.Size = new System.Drawing.Size(162, 35);
            this.btnpvp.TabIndex = 0;
            this.btnpvp.Text = "Player vs Player";
            this.btnpvp.UseVisualStyleBackColor = true;
            this.btnpvp.Click += new System.EventHandler(this.btnpvp_Click);
            // 
            // btnpvc
            // 
            this.btnpvc.Location = new System.Drawing.Point(28, 436);
            this.btnpvc.Name = "btnpvc";
            this.btnpvc.Size = new System.Drawing.Size(162, 33);
            this.btnpvc.TabIndex = 1;
            this.btnpvc.Text = "Player vs Com";
            this.btnpvc.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(28, 475);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 39);
            this.btnnew.TabIndex = 2;
            this.btnnew.Text = "Choi Moi";
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(115, 475);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 39);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Thoat";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // palbanco
            // 
            this.palbanco.BackColor = System.Drawing.Color.Gainsboro;
            this.palbanco.Location = new System.Drawing.Point(224, 36);
            this.palbanco.Name = "palbanco";
            this.palbanco.Size = new System.Drawing.Size(501, 501);
            this.palbanco.TabIndex = 4;
            this.palbanco.Paint += new System.Windows.Forms.PaintEventHandler(this.palbanco_Paint);
            this.palbanco.MouseClick += new System.Windows.Forms.MouseEventHandler(this.palbanco_MouseClick);
            // 
            // tmtxtlc
            // 
            this.tmtxtlc.Interval = 25;
            this.tmtxtlc.Tick += new System.EventHandler(this.tmtxtlc_Tick);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(744, 554);
            this.Controls.Add(this.palbanco);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.grlc);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnpvc);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnpvp);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grlc.ResumeLayout(false);
            this.grlc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PVSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsComToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grlc;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnpvc;
        private System.Windows.Forms.Button btnpvp;
        private System.Windows.Forms.Label lbllc;
        private System.Windows.Forms.Panel palbanco;
        private System.Windows.Forms.Timer tmtxtlc;
    }
}

