namespace BMP2XML
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
            this.dlgFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgFileSave = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadBMPFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWriteToXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadFromXML = new System.Windows.Forms.ToolStripMenuItem();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.lstImages = new System.Windows.Forms.ListBox();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgFileOpen
            // 
            this.dlgFileOpen.DefaultExt = "bmp";
            this.dlgFileOpen.Filter = "Bitmap files|*.bmp|XML files|*.xml|All files|*.*";
            this.dlgFileOpen.Multiselect = true;
            // 
            // dlgFileSave
            // 
            this.dlgFileSave.DefaultExt = "xml";
            this.dlgFileSave.Filter = "Bitmap files|*.bmp|XML files|*.xml|All files|*.*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(212, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoadBMPFiles,
            this.mnuWriteToXML,
            this.mnuLoadFromXML,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuLoadBMPFiles
            // 
            this.mnuLoadBMPFiles.Name = "mnuLoadBMPFiles";
            this.mnuLoadBMPFiles.Size = new System.Drawing.Size(197, 22);
            this.mnuLoadBMPFiles.Text = "Load &BMP Files";
            this.mnuLoadBMPFiles.Click += new System.EventHandler(this.mnuLoadBMPFiles_Click);
            // 
            // mnuWriteToXML
            // 
            this.mnuWriteToXML.Name = "mnuWriteToXML";
            this.mnuWriteToXML.Size = new System.Drawing.Size(197, 22);
            this.mnuWriteToXML.Text = "&Write Images to XML";
            this.mnuWriteToXML.Click += new System.EventHandler(this.mnuWriteToXML_Click);
            // 
            // mnuLoadFromXML
            // 
            this.mnuLoadFromXML.Name = "mnuLoadFromXML";
            this.mnuLoadFromXML.Size = new System.Drawing.Size(197, 22);
            this.mnuLoadFromXML.Text = "&Load Images from XML";
            this.mnuLoadFromXML.Click += new System.EventHandler(this.mnuLoadFromXML_Click);
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(111, 40);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(89, 95);
            this.imgBox.TabIndex = 2;
            this.imgBox.TabStop = false;
            // 
            // lstImages
            // 
            this.lstImages.FormattingEnabled = true;
            this.lstImages.Location = new System.Drawing.Point(12, 40);
            this.lstImages.Name = "lstImages";
            this.lstImages.Size = new System.Drawing.Size(93, 95);
            this.lstImages.TabIndex = 3;
            this.lstImages.SelectedIndexChanged += new System.EventHandler(this.lstImages_SelectedIndexChanged);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(197, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of Images";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 141);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 166);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstImages);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "BMP2XML Test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgFileOpen;
        private System.Windows.Forms.SaveFileDialog dlgFileSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadBMPFiles;
        private System.Windows.Forms.ToolStripMenuItem mnuWriteToXML;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadFromXML;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.ListBox lstImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
    }
}

