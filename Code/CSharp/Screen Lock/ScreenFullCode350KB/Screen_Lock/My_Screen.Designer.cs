namespace Screen_Lock
{
    partial class My_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(My_Screen));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblinfor = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.TChecker = new System.Windows.Forms.Timer(this.components);
            this.TBringToFront = new System.Windows.Forms.Timer(this.components);
            this.lbl_killer = new System.Windows.Forms.Label();
            this.lbl_capslock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(40, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 35);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblinfor
            // 
            this.lblinfor.AutoSize = true;
            this.lblinfor.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfor.ForeColor = System.Drawing.Color.Black;
            this.lblinfor.Location = new System.Drawing.Point(23, 31);
            this.lblinfor.Name = "lblinfor";
            this.lblinfor.Size = new System.Drawing.Size(238, 30);
            this.lblinfor.TabIndex = 1;
            this.lblinfor.Text = "Team 3D5S Inspection";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Black;
            this.lbltime.Location = new System.Drawing.Point(101, 118);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(62, 30);
            this.lbltime.TabIndex = 2;
            this.lbltime.Text = "Time";
            this.lbltime.Visible = false;
            // 
            // TChecker
            // 
            this.TChecker.Enabled = true;
            this.TChecker.Interval = 1000;
            this.TChecker.Tick += new System.EventHandler(this.TChecker_Tick);
            // 
            // TBringToFront
            // 
            this.TBringToFront.Enabled = true;
            this.TBringToFront.Interval = 1;
            this.TBringToFront.Tick += new System.EventHandler(this.TBringToFront_Tick);
            // 
            // lbl_killer
            // 
            this.lbl_killer.AutoSize = true;
            this.lbl_killer.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_killer.ForeColor = System.Drawing.Color.Black;
            this.lbl_killer.Location = new System.Drawing.Point(63, 158);
            this.lbl_killer.Name = "lbl_killer";
            this.lbl_killer.Size = new System.Drawing.Size(151, 30);
            this.lbl_killer.TabIndex = 3;
            this.lbl_killer.Text = "Can\'t Kill App";
            this.lbl_killer.Visible = false;
            // 
            // lbl_capslock
            // 
            this.lbl_capslock.AutoSize = true;
            this.lbl_capslock.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_capslock.ForeColor = System.Drawing.Color.Black;
            this.lbl_capslock.Location = new System.Drawing.Point(64, 199);
            this.lbl_capslock.Name = "lbl_capslock";
            this.lbl_capslock.Size = new System.Drawing.Size(140, 23);
            this.lbl_capslock.TabIndex = 4;
            this.lbl_capslock.Text = "Caps Lock is On";
            this.lbl_capslock.Visible = false;
            // 
            // My_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 253);
            this.Controls.Add(this.lbl_capslock);
            this.Controls.Add(this.lbl_killer);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblinfor);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "My_Screen";
            this.Opacity = 0.7D;
            this.Text = "My_Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.My_Screen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.My_Screen_FormClosed);
            this.Load += new System.EventHandler(this.My_Screen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.My_Screen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblinfor;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer TChecker;
        private System.Windows.Forms.Timer TBringToFront;
        private System.Windows.Forms.Label lbl_killer;
        private System.Windows.Forms.Label lbl_capslock;
        

    }
}