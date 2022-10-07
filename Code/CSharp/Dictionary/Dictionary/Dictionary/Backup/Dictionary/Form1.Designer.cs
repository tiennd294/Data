namespace Dictionary
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.List_english = new System.Windows.Forms.ListBox();
            this.Error = new System.Windows.Forms.Label();
            this.Vietnamese_text = new System.Windows.Forms.RichTextBox();
            this.Search_box = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_back = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Vietnamese = new System.Windows.Forms.RichTextBox();
            this.lb_Phonetic = new System.Windows.Forms.Label();
            this.lb_English = new System.Windows.Forms.Label();
            this.Phonetic = new System.Windows.Forms.TextBox();
            this.txt_English = new System.Windows.Forms.TextBox();
            this.List_editword = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lb_AddEdit = new System.Windows.Forms.Label();
            this.lb_Phienam = new System.Windows.Forms.Label();
            this.txt_Phonetic = new System.Windows.Forms.TextBox();
            this.trackWave = new System.Windows.Forms.TrackBar();
            this.Hide_listbox = new System.Windows.Forms.Button();
            this.Sound = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackWave)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // List_english
            // 
            this.List_english.FormattingEnabled = true;
            this.List_english.Location = new System.Drawing.Point(12, 99);
            this.List_english.Name = "List_english";
            this.List_english.Size = new System.Drawing.Size(233, 342);
            this.List_english.TabIndex = 0;
            this.List_english.SelectedIndexChanged += new System.EventHandler(this.List_english_SelectedIndexChanged);
            this.List_english.KeyDown += new System.Windows.Forms.KeyEventHandler(this.List_english_KeyDown);
            this.List_english.Click += new System.EventHandler(this.List_english_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(55, 183);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 13);
            this.Error.TabIndex = 1;
            // 
            // Vietnamese_text
            // 
            this.Vietnamese_text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Vietnamese_text.Location = new System.Drawing.Point(359, 115);
            this.Vietnamese_text.Name = "Vietnamese_text";
            this.Vietnamese_text.ReadOnly = true;
            this.Vietnamese_text.Size = new System.Drawing.Size(370, 377);
            this.Vietnamese_text.TabIndex = 3;
            this.Vietnamese_text.Text = "";
            // 
            // Search_box
            // 
            this.Search_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.Search_box.FormattingEnabled = true;
            this.Search_box.Location = new System.Drawing.Point(12, 58);
            this.Search_box.MaxDropDownItems = 15;
            this.Search_box.Name = "Search_box";
            this.Search_box.Size = new System.Drawing.Size(221, 21);
            this.Search_box.TabIndex = 4;
            this.Search_box.TextChanged += new System.EventHandler(this.Search_box_TextChanged);
            this.Search_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_box_KeyDown);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(268, 130);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(57, 23);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(268, 177);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(57, 23);
            this.Edit.TabIndex = 8;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(268, 222);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(57, 23);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.Button_Update);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Vietnamese);
            this.panel1.Controls.Add(this.lb_Phonetic);
            this.panel1.Controls.Add(this.lb_English);
            this.panel1.Controls.Add(this.Phonetic);
            this.panel1.Controls.Add(this.txt_English);
            this.panel1.Controls.Add(this.Error);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(331, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 433);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(242, 369);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 17;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.Location = new System.Drawing.Point(323, 369);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(75, 23);
            this.Button_Update.TabIndex = 16;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nghĩa Tiếng Việt";
            // 
            // Vietnamese
            // 
            this.Vietnamese.Location = new System.Drawing.Point(17, 106);
            this.Vietnamese.Name = "Vietnamese";
            this.Vietnamese.Size = new System.Drawing.Size(393, 256);
            this.Vietnamese.TabIndex = 14;
            this.Vietnamese.Text = "";
            // 
            // lb_Phonetic
            // 
            this.lb_Phonetic.AutoSize = true;
            this.lb_Phonetic.Location = new System.Drawing.Point(3, 61);
            this.lb_Phonetic.Name = "lb_Phonetic";
            this.lb_Phonetic.Size = new System.Drawing.Size(52, 13);
            this.lb_Phonetic.TabIndex = 13;
            this.lb_Phonetic.Text = "Phiên Âm";
            // 
            // lb_English
            // 
            this.lb_English.AutoSize = true;
            this.lb_English.Location = new System.Drawing.Point(3, 32);
            this.lb_English.Name = "lb_English";
            this.lb_English.Size = new System.Drawing.Size(72, 13);
            this.lb_English.TabIndex = 12;
            this.lb_English.Text = "Từ Tiếng Anh";
            // 
            // Phonetic
            // 
            this.Phonetic.Font = new System.Drawing.Font("PhTimes", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonetic.Location = new System.Drawing.Point(78, 52);
            this.Phonetic.Name = "Phonetic";
            this.Phonetic.Size = new System.Drawing.Size(114, 22);
            this.Phonetic.TabIndex = 3;
            // 
            // txt_English
            // 
            this.txt_English.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_English.Location = new System.Drawing.Point(78, 20);
            this.txt_English.Name = "txt_English";
            this.txt_English.Size = new System.Drawing.Size(182, 22);
            this.txt_English.TabIndex = 2;
            // 
            // List_editword
            // 
            this.List_editword.FormattingEnabled = true;
            this.List_editword.Location = new System.Drawing.Point(12, 79);
            this.List_editword.Name = "List_editword";
            this.List_editword.Size = new System.Drawing.Size(221, 82);
            this.List_editword.TabIndex = 11;
            this.List_editword.Visible = false;
            this.List_editword.DoubleClick += new System.EventHandler(this.List_editword_DoubleClick);
            this.List_editword.SelectedIndexChanged += new System.EventHandler(this.List_editword_SelectedIndexChanged);
            this.List_editword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.List_editword_KeyDown);
            // 
            // lb_AddEdit
            // 
            this.lb_AddEdit.AutoSize = true;
            this.lb_AddEdit.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddEdit.Location = new System.Drawing.Point(355, 35);
            this.lb_AddEdit.Name = "lb_AddEdit";
            this.lb_AddEdit.Size = new System.Drawing.Size(101, 32);
            this.lb_AddEdit.TabIndex = 12;
            this.lb_AddEdit.Text = "Tra Từ";
            // 
            // lb_Phienam
            // 
            this.lb_Phienam.AutoSize = true;
            this.lb_Phienam.BackColor = System.Drawing.SystemColors.Control;
            this.lb_Phienam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Phienam.Location = new System.Drawing.Point(402, 99);
            this.lb_Phienam.Name = "lb_Phienam";
            this.lb_Phienam.Size = new System.Drawing.Size(52, 13);
            this.lb_Phienam.TabIndex = 13;
            this.lb_Phienam.Text = "Phiên Âm";
            // 
            // txt_Phonetic
            // 
            this.txt_Phonetic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Phonetic.Font = new System.Drawing.Font("PhTimes", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phonetic.Location = new System.Drawing.Point(460, 90);
            this.txt_Phonetic.Name = "txt_Phonetic";
            this.txt_Phonetic.ReadOnly = true;
            this.txt_Phonetic.Size = new System.Drawing.Size(100, 23);
            this.txt_Phonetic.TabIndex = 15;
            // 
            // trackWave
            // 
            this.trackWave.Location = new System.Drawing.Point(582, 70);
            this.trackWave.Name = "trackWave";
            this.trackWave.Size = new System.Drawing.Size(135, 45);
            this.trackWave.TabIndex = 16;
            this.trackWave.Scroll += new System.EventHandler(this.trackWave_Scroll);
            // 
            // Hide_listbox
            // 
            this.Hide_listbox.Image = global::Dictionary.Properties.Resources.Error;
            this.Hide_listbox.Location = new System.Drawing.Point(239, 56);
            this.Hide_listbox.Name = "Hide_listbox";
            this.Hide_listbox.Size = new System.Drawing.Size(23, 23);
            this.Hide_listbox.TabIndex = 17;
            this.Hide_listbox.UseVisualStyleBackColor = true;
            this.Hide_listbox.Visible = false;
            this.Hide_listbox.Click += new System.EventHandler(this.Hide_listbox_Click);
            // 
            // Sound
            // 
            this.Sound.Image = global::Dictionary.Properties.Resources.Sound;
            this.Sound.Location = new System.Drawing.Point(361, 80);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(35, 36);
            this.Sound.TabIndex = 14;
            this.Sound.UseVisualStyleBackColor = true;
            this.Sound.Click += new System.EventHandler(this.Sound_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Dicitonary - PTB";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiddenToolStripMenuItem1,
            this.configToolStripMenuItem,
            this.exitToolStripMenuItem2});
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.menuToolStripMenuItem1.Text = "Menu";
            // 
            // hiddenToolStripMenuItem1
            // 
            this.hiddenToolStripMenuItem1.Name = "hiddenToolStripMenuItem1";
            this.hiddenToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.hiddenToolStripMenuItem1.Text = "Hidden";
            this.hiddenToolStripMenuItem1.Click += new System.EventHandler(this.hiddenToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiddenToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // hiddenToolStripMenuItem
            // 
            this.hiddenToolStripMenuItem.Name = "hiddenToolStripMenuItem";
            this.hiddenToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.hiddenToolStripMenuItem.Text = "Hidden";
            this.hiddenToolStripMenuItem.Click += new System.EventHandler(this.hiddenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 485);
            this.panel2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tác Giả : Phạm Thanh Bình\r\nMSSV : 06110008\r\nLớp : 061102\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ Điển Anh Việt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nạp Dữ Liệu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(227, 99);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 342);
            this.vScrollBar1.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.List_editword);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Hide_listbox);
            this.Controls.Add(this.trackWave);
            this.Controls.Add(this.txt_Phonetic);
            this.Controls.Add(this.Sound);
            this.Controls.Add(this.lb_Phienam);
            this.Controls.Add(this.lb_AddEdit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Search_box);
            this.Controls.Add(this.Vietnamese_text);
            this.Controls.Add(this.List_english);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dictionary - PTB";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackWave)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List_english;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.RichTextBox Vietnamese_text;
        private System.Windows.Forms.ComboBox Search_box;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_English;
        private System.Windows.Forms.ListBox List_editword;
        private System.Windows.Forms.TextBox Phonetic;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lb_Phonetic;
        private System.Windows.Forms.Label lb_English;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Vietnamese;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label lb_AddEdit;
        private System.Windows.Forms.Label lb_Phienam;
        private System.Windows.Forms.Button Sound;
        private System.Windows.Forms.TextBox txt_Phonetic;
        private System.Windows.Forms.TrackBar trackWave;
        private System.Windows.Forms.Button Hide_listbox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiddenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hiddenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;

    }
}

