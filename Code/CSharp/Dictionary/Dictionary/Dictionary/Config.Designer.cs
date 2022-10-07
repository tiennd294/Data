namespace Dictionary
{
    partial class Config
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
            this.listbox_sound = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Repairdatabase = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.Colorsp = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.Colortxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phát Âm";
            // 
            // listbox_sound
            // 
            this.listbox_sound.FormattingEnabled = true;
            this.listbox_sound.Location = new System.Drawing.Point(88, 27);
            this.listbox_sound.Name = "listbox_sound";
            this.listbox_sound.Size = new System.Drawing.Size(120, 95);
            this.listbox_sound.TabIndex = 1;
            this.listbox_sound.SelectedIndexChanged += new System.EventHandler(this.listbox_sound_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Repairdatabase
            // 
            this.Repairdatabase.Location = new System.Drawing.Point(29, 211);
            this.Repairdatabase.Name = "Repairdatabase";
            this.Repairdatabase.Size = new System.Drawing.Size(136, 23);
            this.Repairdatabase.TabIndex = 3;
            this.Repairdatabase.Text = "Repair Database";
            this.Repairdatabase.UseVisualStyleBackColor = true;
            this.Repairdatabase.Click += new System.EventHandler(this.Repairdatabase_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Red;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Màu chữ đặc biệt \r\n(vd noun, verb..v...)\r\n";
            // 
            // Colorsp
            // 
            this.Colorsp.Location = new System.Drawing.Point(355, 27);
            this.Colorsp.Name = "Colorsp";
            this.Colorsp.Size = new System.Drawing.Size(24, 23);
            this.Colorsp.TabIndex = 7;
            this.Colorsp.UseVisualStyleBackColor = true;
            this.Colorsp.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 182);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(393, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Màu chữ ";
            // 
            // Colortxt
            // 
            this.Colortxt.BackColor = System.Drawing.SystemColors.Desktop;
            this.Colortxt.Location = new System.Drawing.Point(355, 55);
            this.Colortxt.Name = "Colortxt";
            this.Colortxt.Size = new System.Drawing.Size(25, 23);
            this.Colortxt.TabIndex = 10;
            this.Colortxt.UseVisualStyleBackColor = false;
            this.Colortxt.Click += new System.EventHandler(this.Colortxt_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 252);
            this.Controls.Add(this.Colortxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Colorsp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Repairdatabase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listbox_sound);
            this.Controls.Add(this.label1);
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listbox_sound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Repairdatabase;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Colorsp;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button Colortxt;
    }
}