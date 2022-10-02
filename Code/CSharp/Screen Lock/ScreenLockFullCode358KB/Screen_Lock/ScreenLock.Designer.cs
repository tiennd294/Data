namespace Screen_Lock
{
    partial class ScreenLock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenLock));
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tabScreen = new System.Windows.Forms.TabPage();
            this.grb_log = new System.Windows.Forms.GroupBox();
            this.lv_login = new System.Windows.Forms.ListView();
            this.grb_home = new System.Windows.Forms.GroupBox();
            this.cb_dontsleep = new System.Windows.Forms.CheckBox();
            this.btn_lock = new System.Windows.Forms.Button();
            this.cb_autolock = new System.Windows.Forms.CheckBox();
            this.cb_autostart = new System.Windows.Forms.CheckBox();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.grb_logo = new System.Windows.Forms.GroupBox();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.btn_savelogo = new System.Windows.Forms.Button();
            this.btn_cancellogo = new System.Windows.Forms.Button();
            this.btn_modifylogo = new System.Windows.Forms.Button();
            this.txt_modifilogo = new System.Windows.Forms.TextBox();
            this.grb_passclose = new System.Windows.Forms.GroupBox();
            this.txt_closeconfirmpass = new System.Windows.Forms.TextBox();
            this.txt_closenewpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grb_passchange = new System.Windows.Forms.GroupBox();
            this.txt_passconfirm = new System.Windows.Forms.TextBox();
            this.txt_passnew = new System.Windows.Forms.TextBox();
            this.txt_passcurrent = new System.Windows.Forms.TextBox();
            this.lbl_confirmpass = new System.Windows.Forms.Label();
            this.lbl_newpass = new System.Windows.Forms.Label();
            this.lbl_currentpass = new System.Windows.Forms.Label();
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.grb_changpass = new System.Windows.Forms.GroupBox();
            this.lv_logchange = new System.Windows.Forms.ListView();
            this.grb_time = new System.Windows.Forms.GroupBox();
            this.lbl_timeunlock = new System.Windows.Forms.Label();
            this.lbl_timelock = new System.Windows.Forms.Label();
            this.lbl_unlock = new System.Windows.Forms.Label();
            this.cbb_unlocktime = new System.Windows.Forms.ComboBox();
            this.lbl_lock = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.cbb_locktime = new System.Windows.Forms.ComboBox();
            this.tabPath = new System.Windows.Forms.TabPage();
            this.grb_path = new System.Windows.Forms.GroupBox();
            this.txt_path_screen = new System.Windows.Forms.TextBox();
            this.txt_path_customer = new System.Windows.Forms.TextBox();
            this.btn_path_customer = new System.Windows.Forms.Button();
            this.btn_path_screen = new System.Windows.Forms.Button();
            this.btn_path_data = new System.Windows.Forms.Button();
            this.txt_path_data = new System.Windows.Forms.TextBox();
            this.btn_save_data = new System.Windows.Forms.Button();
            this.btn_save_screen = new System.Windows.Forms.Button();
            this.btn_save_customer = new System.Windows.Forms.Button();
            this.trayicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ct_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.time_wait = new System.Windows.Forms.Timer(this.components);
            this.tab_main.SuspendLayout();
            this.tabScreen.SuspendLayout();
            this.grb_log.SuspendLayout();
            this.grb_home.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.grb_logo.SuspendLayout();
            this.grb_passclose.SuspendLayout();
            this.grb_passchange.SuspendLayout();
            this.tabTimer.SuspendLayout();
            this.grb_changpass.SuspendLayout();
            this.grb_time.SuspendLayout();
            this.tabPath.SuspendLayout();
            this.grb_path.SuspendLayout();
            this.ct_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.tabScreen);
            this.tab_main.Controls.Add(this.tabSetting);
            this.tab_main.Controls.Add(this.tabTimer);
            this.tab_main.Controls.Add(this.tabPath);
            this.tab_main.Location = new System.Drawing.Point(0, -1);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(470, 327);
            this.tab_main.TabIndex = 1;
            // 
            // tabScreen
            // 
            this.tabScreen.Controls.Add(this.grb_log);
            this.tabScreen.Controls.Add(this.grb_home);
            this.tabScreen.Location = new System.Drawing.Point(4, 22);
            this.tabScreen.Name = "tabScreen";
            this.tabScreen.Padding = new System.Windows.Forms.Padding(3);
            this.tabScreen.Size = new System.Drawing.Size(462, 301);
            this.tabScreen.TabIndex = 0;
            this.tabScreen.Text = "Screen";
            this.tabScreen.UseVisualStyleBackColor = true;
            // 
            // grb_log
            // 
            this.grb_log.Controls.Add(this.lv_login);
            this.grb_log.Location = new System.Drawing.Point(8, 67);
            this.grb_log.Name = "grb_log";
            this.grb_log.Size = new System.Drawing.Size(444, 226);
            this.grb_log.TabIndex = 6;
            this.grb_log.TabStop = false;
            this.grb_log.Text = "Login";
            // 
            // lv_login
            // 
            this.lv_login.Location = new System.Drawing.Point(6, 18);
            this.lv_login.Name = "lv_login";
            this.lv_login.Size = new System.Drawing.Size(432, 200);
            this.lv_login.TabIndex = 0;
            this.lv_login.UseCompatibleStateImageBehavior = false;
            // 
            // grb_home
            // 
            this.grb_home.Controls.Add(this.cb_dontsleep);
            this.grb_home.Controls.Add(this.btn_lock);
            this.grb_home.Controls.Add(this.cb_autolock);
            this.grb_home.Controls.Add(this.cb_autostart);
            this.grb_home.Location = new System.Drawing.Point(8, 6);
            this.grb_home.Name = "grb_home";
            this.grb_home.Size = new System.Drawing.Size(444, 55);
            this.grb_home.TabIndex = 3;
            this.grb_home.TabStop = false;
            this.grb_home.Text = "Home";
            // 
            // cb_dontsleep
            // 
            this.cb_dontsleep.AutoSize = true;
            this.cb_dontsleep.Checked = true;
            this.cb_dontsleep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_dontsleep.Location = new System.Drawing.Point(362, 23);
            this.cb_dontsleep.Name = "cb_dontsleep";
            this.cb_dontsleep.Size = new System.Drawing.Size(81, 17);
            this.cb_dontsleep.TabIndex = 8;
            this.cb_dontsleep.Text = "Don\'t Sleep";
            this.cb_dontsleep.UseVisualStyleBackColor = true;
            this.cb_dontsleep.CheckedChanged += new System.EventHandler(this.cb_dontsleep_CheckedChanged);
            // 
            // btn_lock
            // 
            this.btn_lock.Location = new System.Drawing.Point(25, 18);
            this.btn_lock.Name = "btn_lock";
            this.btn_lock.Size = new System.Drawing.Size(49, 24);
            this.btn_lock.TabIndex = 7;
            this.btn_lock.Text = "Lock";
            this.btn_lock.UseVisualStyleBackColor = true;
            this.btn_lock.Click += new System.EventHandler(this.btn_lock_Click);
            // 
            // cb_autolock
            // 
            this.cb_autolock.AutoSize = true;
            this.cb_autolock.Location = new System.Drawing.Point(235, 22);
            this.cb_autolock.Name = "cb_autolock";
            this.cb_autolock.Size = new System.Drawing.Size(125, 17);
            this.cb_autolock.TabIndex = 5;
            this.cb_autolock.Text = "Auto Lock At Startup";
            this.cb_autolock.UseVisualStyleBackColor = true;
            this.cb_autolock.CheckedChanged += new System.EventHandler(this.cb_autolock_CheckedChanged);
            // 
            // cb_autostart
            // 
            this.cb_autostart.AutoSize = true;
            this.cb_autostart.Location = new System.Drawing.Point(89, 22);
            this.cb_autostart.Name = "cb_autostart";
            this.cb_autostart.Size = new System.Drawing.Size(145, 17);
            this.cb_autostart.TabIndex = 4;
            this.cb_autostart.Text = "Auto Start With Windows";
            this.cb_autostart.UseVisualStyleBackColor = true;
            this.cb_autostart.CheckedChanged += new System.EventHandler(this.cb_autostart_CheckedChanged);
            // 
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.grb_logo);
            this.tabSetting.Controls.Add(this.grb_passclose);
            this.tabSetting.Controls.Add(this.grb_passchange);
            this.tabSetting.Location = new System.Drawing.Point(4, 22);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetting.Size = new System.Drawing.Size(462, 301);
            this.tabSetting.TabIndex = 1;
            this.tabSetting.Text = "Setting";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // grb_logo
            // 
            this.grb_logo.Controls.Add(this.lbl_logo);
            this.grb_logo.Controls.Add(this.btn_savelogo);
            this.grb_logo.Controls.Add(this.btn_cancellogo);
            this.grb_logo.Controls.Add(this.btn_modifylogo);
            this.grb_logo.Controls.Add(this.txt_modifilogo);
            this.grb_logo.Location = new System.Drawing.Point(8, 236);
            this.grb_logo.Name = "grb_logo";
            this.grb_logo.Size = new System.Drawing.Size(444, 58);
            this.grb_logo.TabIndex = 7;
            this.grb_logo.TabStop = false;
            this.grb_logo.Text = "Logo";
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.Location = new System.Drawing.Point(162, 20);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(212, 25);
            this.lbl_logo.TabIndex = 7;
            this.lbl_logo.Text = "Team 3D5S Inspection";
            // 
            // btn_savelogo
            // 
            this.btn_savelogo.Location = new System.Drawing.Point(84, 19);
            this.btn_savelogo.Name = "btn_savelogo";
            this.btn_savelogo.Size = new System.Drawing.Size(42, 27);
            this.btn_savelogo.TabIndex = 6;
            this.btn_savelogo.Text = "Save";
            this.btn_savelogo.UseVisualStyleBackColor = true;
            this.btn_savelogo.Visible = false;
            this.btn_savelogo.Click += new System.EventHandler(this.btn_savelogo_Click);
            // 
            // btn_cancellogo
            // 
            this.btn_cancellogo.Location = new System.Drawing.Point(29, 19);
            this.btn_cancellogo.Name = "btn_cancellogo";
            this.btn_cancellogo.Size = new System.Drawing.Size(49, 27);
            this.btn_cancellogo.TabIndex = 5;
            this.btn_cancellogo.Text = "Cancel";
            this.btn_cancellogo.UseVisualStyleBackColor = true;
            this.btn_cancellogo.Visible = false;
            this.btn_cancellogo.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_modifylogo
            // 
            this.btn_modifylogo.Location = new System.Drawing.Point(28, 19);
            this.btn_modifylogo.Name = "btn_modifylogo";
            this.btn_modifylogo.Size = new System.Drawing.Size(97, 27);
            this.btn_modifylogo.TabIndex = 4;
            this.btn_modifylogo.Text = "Modify";
            this.btn_modifylogo.UseVisualStyleBackColor = true;
            this.btn_modifylogo.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // txt_modifilogo
            // 
            this.txt_modifilogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modifilogo.Location = new System.Drawing.Point(161, 19);
            this.txt_modifilogo.Name = "txt_modifilogo";
            this.txt_modifilogo.Size = new System.Drawing.Size(217, 27);
            this.txt_modifilogo.TabIndex = 3;
            this.txt_modifilogo.Visible = false;
            this.txt_modifilogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_modifilogo_KeyPress);
            // 
            // grb_passclose
            // 
            this.grb_passclose.Controls.Add(this.txt_closeconfirmpass);
            this.grb_passclose.Controls.Add(this.txt_closenewpass);
            this.grb_passclose.Controls.Add(this.label2);
            this.grb_passclose.Controls.Add(this.label3);
            this.grb_passclose.Location = new System.Drawing.Point(8, 136);
            this.grb_passclose.Name = "grb_passclose";
            this.grb_passclose.Size = new System.Drawing.Size(444, 94);
            this.grb_passclose.TabIndex = 5;
            this.grb_passclose.TabStop = false;
            this.grb_passclose.Text = "Password Close";
            // 
            // txt_closeconfirmpass
            // 
            this.txt_closeconfirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_closeconfirmpass.Location = new System.Drawing.Point(158, 52);
            this.txt_closeconfirmpass.Name = "txt_closeconfirmpass";
            this.txt_closeconfirmpass.Size = new System.Drawing.Size(217, 27);
            this.txt_closeconfirmpass.TabIndex = 4;
            this.txt_closeconfirmpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_closeconfirmpass_KeyPress);
            // 
            // txt_closenewpass
            // 
            this.txt_closenewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_closenewpass.Location = new System.Drawing.Point(158, 19);
            this.txt_closenewpass.Name = "txt_closenewpass";
            this.txt_closenewpass.Size = new System.Drawing.Size(217, 27);
            this.txt_closenewpass.TabIndex = 3;
            this.txt_closenewpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_closenewpass_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Password";
            // 
            // grb_passchange
            // 
            this.grb_passchange.Controls.Add(this.txt_passconfirm);
            this.grb_passchange.Controls.Add(this.txt_passnew);
            this.grb_passchange.Controls.Add(this.txt_passcurrent);
            this.grb_passchange.Controls.Add(this.lbl_confirmpass);
            this.grb_passchange.Controls.Add(this.lbl_newpass);
            this.grb_passchange.Controls.Add(this.lbl_currentpass);
            this.grb_passchange.Location = new System.Drawing.Point(8, 6);
            this.grb_passchange.Name = "grb_passchange";
            this.grb_passchange.Size = new System.Drawing.Size(444, 124);
            this.grb_passchange.TabIndex = 4;
            this.grb_passchange.TabStop = false;
            this.grb_passchange.Text = "Change Password";
            // 
            // txt_passconfirm
            // 
            this.txt_passconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passconfirm.Location = new System.Drawing.Point(158, 85);
            this.txt_passconfirm.Name = "txt_passconfirm";
            this.txt_passconfirm.Size = new System.Drawing.Size(217, 27);
            this.txt_passconfirm.TabIndex = 5;
            this.txt_passconfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_passconfirm_KeyPress);
            // 
            // txt_passnew
            // 
            this.txt_passnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passnew.Location = new System.Drawing.Point(158, 52);
            this.txt_passnew.Name = "txt_passnew";
            this.txt_passnew.Size = new System.Drawing.Size(217, 27);
            this.txt_passnew.TabIndex = 4;
            this.txt_passnew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_passnew_KeyPress);
            // 
            // txt_passcurrent
            // 
            this.txt_passcurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passcurrent.Location = new System.Drawing.Point(158, 19);
            this.txt_passcurrent.Name = "txt_passcurrent";
            this.txt_passcurrent.Size = new System.Drawing.Size(217, 27);
            this.txt_passcurrent.TabIndex = 3;
            this.txt_passcurrent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_passcurrent_KeyPress);
            // 
            // lbl_confirmpass
            // 
            this.lbl_confirmpass.AutoSize = true;
            this.lbl_confirmpass.Location = new System.Drawing.Point(36, 93);
            this.lbl_confirmpass.Name = "lbl_confirmpass";
            this.lbl_confirmpass.Size = new System.Drawing.Size(91, 13);
            this.lbl_confirmpass.TabIndex = 2;
            this.lbl_confirmpass.Text = "Confirm Password";
            // 
            // lbl_newpass
            // 
            this.lbl_newpass.AutoSize = true;
            this.lbl_newpass.Location = new System.Drawing.Point(36, 60);
            this.lbl_newpass.Name = "lbl_newpass";
            this.lbl_newpass.Size = new System.Drawing.Size(78, 13);
            this.lbl_newpass.TabIndex = 1;
            this.lbl_newpass.Text = "New Password";
            // 
            // lbl_currentpass
            // 
            this.lbl_currentpass.AutoSize = true;
            this.lbl_currentpass.Location = new System.Drawing.Point(36, 27);
            this.lbl_currentpass.Name = "lbl_currentpass";
            this.lbl_currentpass.Size = new System.Drawing.Size(90, 13);
            this.lbl_currentpass.TabIndex = 0;
            this.lbl_currentpass.Text = "Current Password";
            // 
            // tabTimer
            // 
            this.tabTimer.Controls.Add(this.grb_changpass);
            this.tabTimer.Controls.Add(this.grb_time);
            this.tabTimer.Location = new System.Drawing.Point(4, 22);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Size = new System.Drawing.Size(462, 301);
            this.tabTimer.TabIndex = 2;
            this.tabTimer.Text = "Timer";
            this.tabTimer.UseVisualStyleBackColor = true;
            // 
            // grb_changpass
            // 
            this.grb_changpass.Controls.Add(this.lv_logchange);
            this.grb_changpass.Location = new System.Drawing.Point(9, 67);
            this.grb_changpass.Name = "grb_changpass";
            this.grb_changpass.Size = new System.Drawing.Size(443, 226);
            this.grb_changpass.TabIndex = 7;
            this.grb_changpass.TabStop = false;
            this.grb_changpass.Text = "Log Change";
            // 
            // lv_logchange
            // 
            this.lv_logchange.Location = new System.Drawing.Point(6, 18);
            this.lv_logchange.Name = "lv_logchange";
            this.lv_logchange.Size = new System.Drawing.Size(431, 200);
            this.lv_logchange.TabIndex = 0;
            this.lv_logchange.UseCompatibleStateImageBehavior = false;
            // 
            // grb_time
            // 
            this.grb_time.Controls.Add(this.lbl_timeunlock);
            this.grb_time.Controls.Add(this.lbl_timelock);
            this.grb_time.Controls.Add(this.lbl_unlock);
            this.grb_time.Controls.Add(this.cbb_unlocktime);
            this.grb_time.Controls.Add(this.lbl_lock);
            this.grb_time.Controls.Add(this.btn_close);
            this.grb_time.Controls.Add(this.cbb_locktime);
            this.grb_time.Location = new System.Drawing.Point(8, 6);
            this.grb_time.Name = "grb_time";
            this.grb_time.Size = new System.Drawing.Size(444, 58);
            this.grb_time.TabIndex = 5;
            this.grb_time.TabStop = false;
            this.grb_time.Text = "Timer Lock";
            // 
            // lbl_timeunlock
            // 
            this.lbl_timeunlock.AutoSize = true;
            this.lbl_timeunlock.Location = new System.Drawing.Point(392, 26);
            this.lbl_timeunlock.Name = "lbl_timeunlock";
            this.lbl_timeunlock.Size = new System.Drawing.Size(30, 13);
            this.lbl_timeunlock.TabIndex = 13;
            this.lbl_timeunlock.Text = "Time";
            // 
            // lbl_timelock
            // 
            this.lbl_timelock.AutoSize = true;
            this.lbl_timelock.Location = new System.Drawing.Point(196, 26);
            this.lbl_timelock.Name = "lbl_timelock";
            this.lbl_timelock.Size = new System.Drawing.Size(30, 13);
            this.lbl_timelock.TabIndex = 12;
            this.lbl_timelock.Text = "Time";
            // 
            // lbl_unlock
            // 
            this.lbl_unlock.AutoSize = true;
            this.lbl_unlock.Location = new System.Drawing.Point(251, 26);
            this.lbl_unlock.Name = "lbl_unlock";
            this.lbl_unlock.Size = new System.Drawing.Size(67, 13);
            this.lbl_unlock.TabIndex = 11;
            this.lbl_unlock.Text = "Unlock Time";
            // 
            // cbb_unlocktime
            // 
            this.cbb_unlocktime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_unlocktime.FormattingEnabled = true;
            this.cbb_unlocktime.Items.AddRange(new object[] {
            "1 minute",
            "2 minutes",
            "3 minutes",
            "5 minutes",
            "10 minutes",
            "15 minutes",
            "20 minutes",
            "25 minutes",
            "30 minutes",
            "45 minutes",
            "1 hour",
            "2 hours",
            "3 hours",
            "4 hours",
            "5 hours",
            "Never"});
            this.cbb_unlocktime.Location = new System.Drawing.Point(319, 22);
            this.cbb_unlocktime.Name = "cbb_unlocktime";
            this.cbb_unlocktime.Size = new System.Drawing.Size(72, 21);
            this.cbb_unlocktime.TabIndex = 10;
            this.cbb_unlocktime.SelectedIndexChanged += new System.EventHandler(this.cbb_unlocktime_SelectedIndexChanged);
            // 
            // lbl_lock
            // 
            this.lbl_lock.AutoSize = true;
            this.lbl_lock.Location = new System.Drawing.Point(64, 26);
            this.lbl_lock.Name = "lbl_lock";
            this.lbl_lock.Size = new System.Drawing.Size(57, 13);
            this.lbl_lock.TabIndex = 9;
            this.lbl_lock.Text = "Lock Time";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(7, 21);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(49, 24);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // cbb_locktime
            // 
            this.cbb_locktime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_locktime.FormattingEnabled = true;
            this.cbb_locktime.Items.AddRange(new object[] {
            "1 minute",
            "2 minutes",
            "3 minutes",
            "5 minutes",
            "10 minutes",
            "15 minutes",
            "20 minutes",
            "25 minutes",
            "30 minutes",
            "45 minutes",
            "1 hour",
            "2 hours",
            "3 hours",
            "4 hours",
            "5 hours",
            "Never"});
            this.cbb_locktime.Location = new System.Drawing.Point(123, 22);
            this.cbb_locktime.Name = "cbb_locktime";
            this.cbb_locktime.Size = new System.Drawing.Size(72, 21);
            this.cbb_locktime.TabIndex = 1;
            this.cbb_locktime.SelectedIndexChanged += new System.EventHandler(this.cbb_locktime_SelectedIndexChanged);
            // 
            // tabPath
            // 
            this.tabPath.Controls.Add(this.grb_path);
            this.tabPath.Location = new System.Drawing.Point(4, 22);
            this.tabPath.Name = "tabPath";
            this.tabPath.Size = new System.Drawing.Size(462, 301);
            this.tabPath.TabIndex = 3;
            this.tabPath.Text = "Path";
            this.tabPath.UseVisualStyleBackColor = true;
            // 
            // grb_path
            // 
            this.grb_path.Controls.Add(this.txt_path_screen);
            this.grb_path.Controls.Add(this.txt_path_customer);
            this.grb_path.Controls.Add(this.btn_path_customer);
            this.grb_path.Controls.Add(this.btn_path_screen);
            this.grb_path.Controls.Add(this.btn_path_data);
            this.grb_path.Controls.Add(this.txt_path_data);
            this.grb_path.Controls.Add(this.btn_save_data);
            this.grb_path.Controls.Add(this.btn_save_screen);
            this.grb_path.Controls.Add(this.btn_save_customer);
            this.grb_path.Location = new System.Drawing.Point(8, 6);
            this.grb_path.Name = "grb_path";
            this.grb_path.Size = new System.Drawing.Size(444, 286);
            this.grb_path.TabIndex = 8;
            this.grb_path.TabStop = false;
            this.grb_path.Text = "Path";
            // 
            // txt_path_screen
            // 
            this.txt_path_screen.Location = new System.Drawing.Point(109, 52);
            this.txt_path_screen.Name = "txt_path_screen";
            this.txt_path_screen.Size = new System.Drawing.Size(276, 20);
            this.txt_path_screen.TabIndex = 8;
            // 
            // txt_path_customer
            // 
            this.txt_path_customer.Location = new System.Drawing.Point(109, 81);
            this.txt_path_customer.Name = "txt_path_customer";
            this.txt_path_customer.Size = new System.Drawing.Size(276, 20);
            this.txt_path_customer.TabIndex = 7;
            // 
            // btn_path_customer
            // 
            this.btn_path_customer.Location = new System.Drawing.Point(397, 80);
            this.btn_path_customer.Name = "btn_path_customer";
            this.btn_path_customer.Size = new System.Drawing.Size(30, 23);
            this.btn_path_customer.TabIndex = 6;
            this.btn_path_customer.Text = "...";
            this.btn_path_customer.UseVisualStyleBackColor = true;
            this.btn_path_customer.Click += new System.EventHandler(this.btn_path_customer_Click);
            // 
            // btn_path_screen
            // 
            this.btn_path_screen.Location = new System.Drawing.Point(397, 51);
            this.btn_path_screen.Name = "btn_path_screen";
            this.btn_path_screen.Size = new System.Drawing.Size(30, 23);
            this.btn_path_screen.TabIndex = 5;
            this.btn_path_screen.Text = "...";
            this.btn_path_screen.UseVisualStyleBackColor = true;
            this.btn_path_screen.Click += new System.EventHandler(this.btn_path_screen_Click);
            // 
            // btn_path_data
            // 
            this.btn_path_data.Location = new System.Drawing.Point(397, 22);
            this.btn_path_data.Name = "btn_path_data";
            this.btn_path_data.Size = new System.Drawing.Size(30, 23);
            this.btn_path_data.TabIndex = 4;
            this.btn_path_data.Text = "...";
            this.btn_path_data.UseVisualStyleBackColor = true;
            this.btn_path_data.Click += new System.EventHandler(this.btn_path_data_Click);
            // 
            // txt_path_data
            // 
            this.txt_path_data.Location = new System.Drawing.Point(109, 23);
            this.txt_path_data.Name = "txt_path_data";
            this.txt_path_data.Size = new System.Drawing.Size(276, 20);
            this.txt_path_data.TabIndex = 3;
            // 
            // btn_save_data
            // 
            this.btn_save_data.Location = new System.Drawing.Point(16, 22);
            this.btn_save_data.Name = "btn_save_data";
            this.btn_save_data.Size = new System.Drawing.Size(87, 23);
            this.btn_save_data.TabIndex = 2;
            this.btn_save_data.Text = "Save Data";
            this.btn_save_data.UseVisualStyleBackColor = true;
            this.btn_save_data.Click += new System.EventHandler(this.btn_save_data_Click);
            // 
            // btn_save_screen
            // 
            this.btn_save_screen.Location = new System.Drawing.Point(16, 51);
            this.btn_save_screen.Name = "btn_save_screen";
            this.btn_save_screen.Size = new System.Drawing.Size(87, 23);
            this.btn_save_screen.TabIndex = 1;
            this.btn_save_screen.Text = "Save Screen";
            this.btn_save_screen.UseVisualStyleBackColor = true;
            this.btn_save_screen.Click += new System.EventHandler(this.btn_save_screen_Click);
            // 
            // btn_save_customer
            // 
            this.btn_save_customer.Location = new System.Drawing.Point(16, 80);
            this.btn_save_customer.Name = "btn_save_customer";
            this.btn_save_customer.Size = new System.Drawing.Size(87, 23);
            this.btn_save_customer.TabIndex = 0;
            this.btn_save_customer.Text = "Save Customer";
            this.btn_save_customer.UseVisualStyleBackColor = true;
            this.btn_save_customer.Click += new System.EventHandler(this.btn_save_customer_Click);
            // 
            // trayicon
            // 
            this.trayicon.ContextMenuStrip = this.ct_Menu;
            this.trayicon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayicon.Icon")));
            this.trayicon.Text = "Screen Lock";
            this.trayicon.Visible = true;
            this.trayicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayicon_MouseDoubleClick);
            // 
            // ct_Menu
            // 
            this.ct_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockToolStripMenuItem,
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ct_Menu.Name = "ct_Menu";
            this.ct_Menu.Size = new System.Drawing.Size(104, 70);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lockToolStripMenuItem.Image")));
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.lockToolStripMenuItem.Text = "Lock";
            this.lockToolStripMenuItem.Click += new System.EventHandler(this.lockToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showToolStripMenuItem.Image")));
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // time_wait
            // 
            this.time_wait.Enabled = true;
            this.time_wait.Interval = 1;
            this.time_wait.Tick += new System.EventHandler(this.time_wait_Tick);
            // 
            // ScreenLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 325);
            this.Controls.Add(this.tab_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ScreenLock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen Lock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScreenLock_FormClosing);
            this.Load += new System.EventHandler(this.ScreenLock_Load);
            this.Resize += new System.EventHandler(this.ScreenLock_Resize);
            this.tab_main.ResumeLayout(false);
            this.tabScreen.ResumeLayout(false);
            this.grb_log.ResumeLayout(false);
            this.grb_home.ResumeLayout(false);
            this.grb_home.PerformLayout();
            this.tabSetting.ResumeLayout(false);
            this.grb_logo.ResumeLayout(false);
            this.grb_logo.PerformLayout();
            this.grb_passclose.ResumeLayout(false);
            this.grb_passclose.PerformLayout();
            this.grb_passchange.ResumeLayout(false);
            this.grb_passchange.PerformLayout();
            this.tabTimer.ResumeLayout(false);
            this.grb_changpass.ResumeLayout(false);
            this.grb_time.ResumeLayout(false);
            this.grb_time.PerformLayout();
            this.tabPath.ResumeLayout(false);
            this.grb_path.ResumeLayout(false);
            this.grb_path.PerformLayout();
            this.ct_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage tabScreen;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.GroupBox grb_log;
        private System.Windows.Forms.ListView lv_login;
        private System.Windows.Forms.GroupBox grb_home;
        private System.Windows.Forms.CheckBox cb_autolock;
        private System.Windows.Forms.CheckBox cb_autostart;
        private System.Windows.Forms.GroupBox grb_passchange;
        private System.Windows.Forms.TabPage tabTimer;
        private System.Windows.Forms.TextBox txt_passconfirm;
        private System.Windows.Forms.TextBox txt_passnew;
        private System.Windows.Forms.TextBox txt_passcurrent;
        private System.Windows.Forms.Label lbl_confirmpass;
        private System.Windows.Forms.Label lbl_newpass;
        private System.Windows.Forms.Label lbl_currentpass;
        private System.Windows.Forms.GroupBox grb_passclose;
        private System.Windows.Forms.TextBox txt_closeconfirmpass;
        private System.Windows.Forms.TextBox txt_closenewpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grb_logo;
        private System.Windows.Forms.TextBox txt_modifilogo;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Button btn_savelogo;
        private System.Windows.Forms.Button btn_cancellogo;
        private System.Windows.Forms.Button btn_modifylogo;
        private System.Windows.Forms.GroupBox grb_time;
        private System.Windows.Forms.Button btn_lock;
        private System.Windows.Forms.NotifyIcon trayicon;
        private System.Windows.Forms.ContextMenuStrip ct_Menu;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grb_changpass;
        private System.Windows.Forms.ListView lv_logchange;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_unlock;
        private System.Windows.Forms.ComboBox cbb_unlocktime;
        private System.Windows.Forms.Label lbl_lock;
        private System.Windows.Forms.ComboBox cbb_locktime;
        private System.Windows.Forms.Timer time_wait;
        private System.Windows.Forms.CheckBox cb_dontsleep;
        private System.Windows.Forms.Label lbl_timeunlock;
        private System.Windows.Forms.Label lbl_timelock;
        private System.Windows.Forms.TabPage tabPath;
        private System.Windows.Forms.GroupBox grb_path;
        private System.Windows.Forms.Button btn_save_data;
        private System.Windows.Forms.Button btn_save_screen;
        private System.Windows.Forms.Button btn_save_customer;
        private System.Windows.Forms.TextBox txt_path_screen;
        private System.Windows.Forms.TextBox txt_path_customer;
        private System.Windows.Forms.Button btn_path_customer;
        private System.Windows.Forms.Button btn_path_screen;
        private System.Windows.Forms.Button btn_path_data;
        private System.Windows.Forms.TextBox txt_path_data;

    }
}

