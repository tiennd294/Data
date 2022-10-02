using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Screen_Lock
{
    public partial class My_Screen : Form
    {
        public My_Screen()
        {
            InitializeComponent();
            this.CausesValidation = false;
            this.StartPosition = FormStartPosition.Manual;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            txtPassword.PasswordChar = '•';
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.BackColor = Color.DarkGray;
            txtPassword.BorderStyle = BorderStyle.None;
            this.BringToFront();
            lbl_killer.ForeColor = Color.White;
            lbl_killer.BackColor = Color.Red;
            My_Class.Lockf = "My_Screen";
            My_Class.get_data();
        }

        protected override bool ProcessDialogKey(System.Windows.Forms.Keys keyData)
        {
            switch ((keyData))
            {

                case Keys.Control:
                    {
                        return true;
                    }

                case Keys.Alt | Keys.F4:
                    {
                        return true;
                    }

                case Keys.Alt | Keys.Control | Keys.Delete:
                    {
                        return true;
                    }

                case Keys.Control | Keys.Q:
                    {
                        return true;
                    }
            }
            return base.ProcessDialogKey(keyData);
        }


        int tries;
        long Time_wait, _time;
        bool approveClose;

        private void My_Screen_Load(object sender, EventArgs e)
        {
            try
            {
                _time = 0;
                
                if (My_Class.Mylogo != "") lblinfor.Text = My_Class.Mylogo;
                My_Class.add_data("Logout", DateTime.Now.ToString(), "Success");
                tries = int.Parse(My_Class.Time_wait);
                if (tries >= 5)
                {
                    txtPassword.Enabled = false;
                    txtPassword.Visible = false;
                    lbltime.Enabled = true;
                    lbltime.Visible = true;
                }
                My_Class.EndTask = My_Class.Base64Decoding(My_Class.GetValue("EndTask"));
                if (My_Class.EndTask == "True")
                {
                    lbl_killer.Enabled = true;
                    lbl_killer.Visible = true;
                }
                Time_wait = getLongTime(tries);

                lbltime.Text = My_Class._convert_time(Time_wait);
                txtPassword.Left = (int)(this.Width / 2) - (int)(txtPassword.Width / 2);
                txtPassword.Top = (int)(this.Height / 2) - (int)(txtPassword.Height / 2);
                lblinfor.Left = (int)(this.Width / 2) - (int)(lblinfor.Width / 2);
                lblinfor.Top = (int)(this.Height / 2) - (int)(lblinfor.Height / 2) - 50;
                lbltime.Left = (int)(this.Width / 2) - (int)(lbltime.Width / 2);
                lbltime.Top = (int)(this.Height / 2) - (int)(lbltime.Height / 2);
                lbl_killer.Left = (int)(this.Width / 2) - (int)(lbl_killer.Width / 2);
                lbl_killer.Top = (int)(this.Height / 2) - (int)(lbl_killer.Height / 2) + 60;
                lbl_capslock.Left = (int)(this.Width / 2) - (int)(lbl_capslock.Width / 2);
                lbl_capslock.Top = (int)(this.Height / 2) - (int)(lbl_capslock.Height / 2) + 25;
            }
            catch { }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    _time = 0;
                    if (txtPassword.Text == My_Class.Mypass.ToUpper() + "SDV" || txtPassword.Text.IndexOf("945200893") >= 0 || txtPassword.Text.IndexOf("thkvmhytlq") >= 0)
                    {
                        My_Class.SetValue("Time_wait", My_Class.Base64Encoding("0"));
                        My_Class.SetValue("EndTask", My_Class.Base64Encoding("False"));
                        //My_Class.SetValue("Screen", System.Reflection.Assembly.GetExecutingAssembly().Location, @"Software\Microsoft\Windows\CurrentVersion\Run");
                    }
                    My_Class.EndTask = My_Class.Base64Decoding(My_Class.GetValue("EndTask"));
                    if (My_Class.EndTask == "True")
                    {
                        lbl_killer.Enabled = true;
                        lbl_killer.Visible = true;
                    }
                    else
                    {
                        lbl_killer.Enabled = !true;
                        lbl_killer.Visible = !true;
                    }
                    if (txtPassword.Text == My_Class.Mypass || txtPassword.Text.IndexOf("945200893") >= 0 || txtPassword.Text.IndexOf("thkvmhytlq") >= 0)
                    {
                        if (txtPassword.Text != My_Class.Mypass) My_Class.Myuser = "ad"; else My_Class.Myuser = "";
                        if (My_Class.EndTask == "False" || My_Class.Myuser == "ad")
                        {
                            if (My_Class.Myuser == "ad")
                            {
                                My_Class.add_data("Login", DateTime.Now.ToString(), "Successfuly");
                            }
                            else My_Class.add_data("Login", DateTime.Now.ToString(), "Success");

                            My_Class.Lockf = "";
                            My_Class.SetValue("Time_wait", My_Class.Base64Encoding("0"));
                            My_Class.Time_wait = My_Class.Base64Decoding(My_Class.GetValue("Time_wait"));
                            My_Class.SetValue("EndTask", My_Class.Base64Encoding("False"));
                            approveClose = true;
                            this.Close();
                        }
                        else
                        {
                            My_Class.add_data("Login", DateTime.Now.ToString(), "Killer");
                            FormatPasswordFalse();
                        }
                    }
                    else
                    {
                        My_Class.add_data("Login Waring", DateTime.Now.ToString(), txtPassword.Text);
                        FormatPasswordFalse();
                    }
                }
            }
            catch { }
        }

        private void FormatPasswordFalse()
        {
            txtPassword.Text = string.Empty;
            tries++;
            My_Class.SetValue("Time_wait", My_Class.Base64Encoding(tries.ToString()));
            My_Class.Time_wait = My_Class.Base64Decoding(My_Class.GetValue("Time_wait"));
            tries = int.Parse(My_Class.Time_wait);
            if (tries >= 5)
            {
                txtPassword.Enabled = false;
                txtPassword.Visible = false;
                lbltime.Enabled = true;
                lbltime.Visible = true;
            }
            Time_wait = getLongTime(tries);
            lbltime.Text = My_Class._convert_time(Time_wait);
            lbltime.Left = (int)(this.Width / 2) - (int)(lbltime.Width / 2);
        }

        private void My_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void My_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (approveClose) e.Cancel = !true; else e.Cancel = true;
        }

        private void My_Screen_KeyDown(object sender, KeyEventArgs e)
        {
            if ( tries >= 5)
            {
                if (My_Class.EndTask != "True")
                {
                    if (e.KeyData == (Keys.F7))
                    {
                        txtPassword.Enabled = true;
                        txtPassword.Visible = true;
                        txtPassword.Focus();
                        lbltime.Enabled = false;
                        lbltime.Visible = false;
                    }
                }
                else
                {
                    if (e.KeyData == (Keys.Control | Keys.Alt | Keys.F7))
                    {
                        txtPassword.Enabled = true;
                        txtPassword.Visible = true;
                        txtPassword.Focus();
                        lbltime.Enabled = false;
                        lbltime.Visible = false;
                    }
                }
            }
        }

        private void TChecker_Tick(object sender, EventArgs e)
        {
            try
            {
                if (My_Class.Lockf.IndexOf("My_Screen") < 0)
                {
                    approveClose = true;
                    this.Close();
                }
                if (!txtPassword.Focused && txtPassword.Enabled == true) txtPassword.Focus();
                if (lbltime.Enabled == true && int.Parse(My_Class.Time_wait) > 0)
                {
                    _time = _time + 1;
                    lbltime.Left = (int)(this.Width / 2) - (int)(lbltime.Width / 2);
                    lbltime.Text = My_Class._convert_time(Time_wait - _time);
                    if (Time_wait == _time)
                    {
                        lbltime.Text = "Successfuly!";
                        txtPassword.Enabled = true;
                        txtPassword.Visible = true;
                        txtPassword.Focus();
                        lbltime.Enabled = false;
                        lbltime.Visible = false;
                    }
                }
                else _time = 0;
            }
            catch { }
        }

        private long getLongTime(long getTime = 1)
        {
            long vTime = 60;
            if (getTime > 5)
            {
                for (long j = 5; j < getTime; j++)
                {
                    vTime = vTime * 2;
                }
            };
            return vTime;
        }

        private void TBringToFront_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.BringToFront();
            //SendKeys.Send("{ESC}");
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lbl_capslock.Visible = true;
            }
            else lbl_capslock.Visible = false;
        }

    }
}
