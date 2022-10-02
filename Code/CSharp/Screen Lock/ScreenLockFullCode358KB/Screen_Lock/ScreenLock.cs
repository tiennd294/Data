using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Screen_Lock
{
    public partial class ScreenLock : Form
    {
        public ScreenLock()
        {
            InitializeComponent();
            txt_passcurrent.PasswordChar = '•';
            txt_passnew.PasswordChar = '•';
            txt_passconfirm.PasswordChar = '•';
            txt_closenewpass.PasswordChar = '•';
            txt_closeconfirmpass.PasswordChar = '•';
            this.BringToFront();
            this.ShowInTaskbar = false;
            this.TopMost = true;
            lv_login.View = View.Details;
            lv_login.GridLines = true;
            lv_login.Columns.Add("No", 38, HorizontalAlignment.Center);
            lv_login.Columns.Add("Status", 85, HorizontalAlignment.Center);
            lv_login.Columns.Add("Date Time", 115, HorizontalAlignment.Center);
            lv_login.Columns.Add("Content", 190, HorizontalAlignment.Center);
            lv_logchange.View = View.Details;
            lv_logchange.GridLines = true;
            lv_logchange.Columns.Add("No", 38, HorizontalAlignment.Center);
            lv_logchange.Columns.Add("Status", 65, HorizontalAlignment.Center);
            lv_logchange.Columns.Add("Date Time", 115, HorizontalAlignment.Center);
            lv_logchange.Columns.Add("Content", 208, HorizontalAlignment.Center);
            My_Class.get_data(); My_Class.Lockf = "";
            My_Class.SetValue("ClTask", My_Class.Base64Encoding("False"));
            My_Class.ClTask = My_Class.Base64Decoding(My_Class.GetValue("ClTask"));
        }

        Confirm cf = new Confirm();
        DateTime dtwt;
        DateTime dtn;
        TimeSpan ts;
        bool _form = false;

        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
            // Legacy flag, should not be used.
            // ES_USER_PRESENT = 0x00000004
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
        private void prevent_screensaver(bool sw = true)
        {
            if (sw)
            {
                SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS);
            }
            else
            {
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                return cp;//Hide được Apps => Background Process.a 
            }
        }

        private void ScreenLock_Load(object sender, EventArgs e)
        {
            EndTask();
            if (My_Class.Autostart == "True")
            {
                My_Class.autostartup();
                cb_autostart.Checked = true;
            };
            if (My_Class.Autolock == "True")
            {
                cb_autolock.Checked = true;
                if (My_Class.Lockf.IndexOf("My_Screen") < 0)
                {
                    My_Class.Lockf = "My_Screen";
                    My_Screen ms = new My_Screen();
                    ms.Show();
                }
            };
            cbb_locktime.SelectedItem = My_Class.Time_lock;
            cbb_unlocktime.SelectedItem = My_Class.Time_unlock;
            load_ad();
            load_log();
            load_log("Log"); _form = true;
        }

        private void EndTask()
        {
            if (My_Class.EndTask == "True")
            {
                My_Class.SetValue("AutoLock", My_Class.Base64Encoding("True"));
                My_Class.Autolock = My_Class.Base64Decoding(My_Class.GetValue("AutoLock"));
                if (My_Class.Autolock == "True")
                {
                    if (My_Class.Lockf.IndexOf("My_Screen") < 0)
                    {
                        My_Class.Lockf = "My_Screen"; //MessageBox.Show("OK nhes");
                        cb_autolock.Checked = true;
                        My_Screen ms = new My_Screen();
                        ms.Show();
                    }
                };
            }
        }

        private void ScreenLock_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                trayicon.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                trayicon.Visible = false;
            }
        }

        private void trayicon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //show_main();
            My_Screen ms = new My_Screen();
            ms.Show();
        }

        private void ScreenLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (My_Class.Closeapp) e.Cancel = !true; else e.Cancel = true;
            trayicon.Visible = true;
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cf.Show();
        }

        private void cb_autostart_CheckedChanged(object sender, EventArgs e)
        {
            My_Class.SetValue("AutoStart", My_Class.Base64Encoding(cb_autostart.Checked.ToString()));
            My_Class.get_data();
            My_Class.autostartup();
        }

        private void cb_autolock_CheckedChanged(object sender, EventArgs e)
        {
            My_Class.SetValue("AutoLock", My_Class.Base64Encoding(cb_autolock.Checked.ToString()));
            My_Class.get_data();
        }

        private void cb_dontsleep_CheckedChanged(object sender, EventArgs e)
        {
            prevent_screensaver(cb_dontsleep.Checked);
        }

        private void btn_lock_Click(object sender, EventArgs e)
        {
            this.Hide(); trayicon.Visible = true;
            My_Screen ms = new My_Screen();
            ms.Show();
            //if (!File.Exists(@"D:\Windows\data.xml")) MessageBox.Show("OK nhes");
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My_Screen ms = new My_Screen();
            ms.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //allowVisible = true;
            show_main();
        }

        private void txt_passcurrent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_passnew.Focus();
            }
        }

        private void txt_passnew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_passconfirm.Focus();
            }
        }

        private void txt_passconfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_passcurrent.Focus();
                save_mypass();
            }
        }

        private void txt_closenewpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_closeconfirmpass.Focus();
            }
        }

        private void txt_closeconfirmpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_closenewpass.Focus();
                save_passclose();
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            set_frmlogo(false); txt_modifilogo.Focus();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            set_frmlogo();
        }

        private void btn_savelogo_Click(object sender, EventArgs e)
        {
            save_logo();
            set_frmlogo();
        }

        private void txt_modifilogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                save_logo();
                set_frmlogo();
            }
        }

        public void set_frmlogo(bool _status = true)
        {
            txt_modifilogo.Text = My_Class.Mylogo;
            lbl_logo.Text = My_Class.Mylogo;
            btn_modifylogo.Visible = _status;
            btn_cancellogo.Visible = !_status;
            btn_savelogo.Visible = !_status;
            lbl_logo.Visible = _status;
            txt_modifilogo.Visible = !_status;
        }

        public void show_main(bool ftmmain = true)
        {
            if (ftmmain)
            {
                //trayicon.Visible = false;
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else { this.Hide(); /*trayicon.Visible = true;*/ }
            if (My_Class.Autolock == "True")
            {
                cb_autolock.Checked = true;
                My_Screen ms = new My_Screen();
                ms.Show();
            };
            load_ad();
            load_log();
            load_log("Log");
        }

        public void save_mypass()
        {
            if (txt_passcurrent.Text == My_Class.Mypass + "sdv" || My_Class.Myuser == "ad")
            {
                if (txt_passnew.Text == txt_passconfirm.Text && txt_passconfirm.Text != "")
                {
                    if (My_Class.Myuser == "ad")
                    {
                        My_Class.add_data("MyPass", DateTime.Now.ToString(), "Successfuly","Log");
                    }
                    else My_Class.add_data("MyPass", DateTime.Now.ToString(), txt_passnew.Text, "Log"); 
                        
                    My_Class.SetValue("MyPass", My_Class.Base64Encoding(txt_passconfirm.Text));
                    My_Class.get_data();
                    MessageBox.Show("Change Password Successfuly!");
                }
                else MessageBox.Show("Confirm Password False!");
            }
            else
            {
                My_Class.add_data("MyPass", DateTime.Now.ToString(), txt_passnew.Text, "Log");
                MessageBox.Show("Chưa code xong đâu nhé!");
            }
            load_log("Log");    
            txt_passcurrent.Text = "";
            txt_passnew.Text = "";
            txt_passconfirm.Text = "";
        }

        public void save_passclose()
        {
            if (My_Class.Myuser == "ad")
            {
                if (txt_closenewpass.Text == txt_closeconfirmpass.Text && txt_closeconfirmpass.Text != "")
                {
                    My_Class.SetValue("PassClose", My_Class.Base64Encoding(txt_closeconfirmpass.Text));
                    My_Class.get_data();
                    My_Class.add_data("PassClose", DateTime.Now.ToString(), "Successfuly", "Log");
                    MessageBox.Show("Change Password Close Successfuly!");
                }
                else MessageBox.Show("Confirm Password False!");
            }
            else
            {
                My_Class.add_data("PassClose", DateTime.Now.ToString(), txt_closenewpass.Text, "Log");
                MessageBox.Show("Chưa code xong đâu nhé!");
            }
            load_log("Log");    
            txt_closenewpass.Text = "";
            txt_closeconfirmpass.Text = "";
        }

        public void save_logo()
        {
            if (My_Class.Myuser == "ad")
            {
                My_Class.SetValue("MyLogo", My_Class.Base64Encoding(txt_modifilogo.Text));
                My_Class.get_data();
                My_Class.add_data("Logo", DateTime.Now.ToString(), "Lg: " + txt_modifilogo.Text, "Log");
                MessageBox.Show("Change Logo Successfuly!");
            }
            else
            {
                My_Class.add_data("Logo", DateTime.Now.ToString(), txt_modifilogo.Text, "Log");
                MessageBox.Show("Chưa code xong đâu nhé!");
            }
            load_log("Log");    
        }

        public void load_ad()
        {
            lbl_logo.Text = My_Class.Mylogo;
            txt_path_data.Text = My_Class.PaData;
            txt_path_screen.Text = My_Class.PaScreen;
            txt_path_customer.Text = My_Class.PaCustomer;
            if (My_Class.Myuser == "ad")
            {
                btn_close.Visible = true;
                grb_passclose.Visible = true;
                grb_logo.Visible = true;
                grb_changpass.Visible = true;
                grb_path.Visible = true;
            }
            else
            {
                grb_passclose.Visible = !true;
                grb_logo.Visible = !true;
                grb_changpass.Visible = !true;
                btn_close.Visible = !true;
                grb_path.Visible = !true;
            }
        }

        public void load_log(string _table = "History")
        {
            DataTable data = My_Class.loaddata(_table);
            DataView dv = data.DefaultView;
            if (data.Rows.Count > 0)
            {
                dv.Sort = "Date Time DESC";
                DataTable dtb = dv.ToTable();
                //dtb.DefaultView.Sort = "Id DESC"; 
                if (_table == "History") lv_login.Items.Clear();
                if (_table == "Log") lv_logchange.Items.Clear();

                foreach (DataRow row in dtb.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dtb.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    };
                    if (_table == "History") lv_login.Items.Add(item);
                    if (_table == "Log") lv_logchange.Items.Add(item);
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            My_Class.Myuser = "";
            load_ad();
        }

        public static string _path_cus = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "//Customer.exe";
        private void time_wait_Tick(object sender, EventArgs e)
        {
            try
            {
                
                if (_form)
                {
                    _form = false;
                    this.Hide();
                }

                //if (!My_Class.Check_SubKey("Screen") || My_Class.Autostart == "True" && (!My_Class.Check_Key("Screen", @"Software\Microsoft\Windows\CurrentVersion\Run") || (My_Class.GetValue("Screen", @"Software\Microsoft\Windows\CurrentVersion\Run") == "")))
                //{
                //    My_Class.add_data("Killer apps", DateTime.Now.ToString(), "Killer Registry!", "Log");
                //    if (My_Class.Lockf.IndexOf("My_Screen") < 0)
                //    {
                //        My_Class.SetValue("Time_wait", My_Class.Base64Encoding("15"));
                //        My_Class.SetValue("EndTask", My_Class.Base64Encoding("True"));
                //        My_Class.get_data();
                //        My_Screen ms = new My_Screen();
                //        ms.Show();
                //    }
                //};
                My_Class.get_data();
                EndTask();

                if (!CheckApps("Customer") && My_Class.ClTask == "False")
                {
                    My_Class.add_data("Killer apps", DateTime.Now.ToString(), "Killer Customer!", "Log");

                    if (My_Class.PaCustomer != "")
                    {
                        if (File.Exists(My_Class.PaCustomer))
                        {
                            Process.Start(My_Class.PaCustomer);
                        }
                    }
                    else
                    {
                        if (File.Exists(_path_cus))
                        {
                            Process.Start(_path_cus);
                        }
                    }
                }

                if (My_Class.Time_lock != "Never")
                {
                    if (My_Class.Time_lock.Length > 0)
                    {
                        My_Class.Time_lock_value = My_Class.Base64Decoding(My_Class.GetValue("Time_lock_value"));
                        //lbl_timelock.Text = My_Class.Time_lock_value;
                        dtwt = DateTime.Parse(My_Class.Time_lock_value);
                        if (My_Class.Time_lock.IndexOf(" minute") > 0)
                        {
                            dtn = DateTime.Now.AddMinutes(int.Parse(My_Class.Time_lock.Replace(" minute", "").Replace("s", "")));
                        }
                        if (My_Class.Time_lock.IndexOf(" hour") > 0)
                        {
                            dtn = DateTime.Now.AddHours(int.Parse(My_Class.Time_lock.Replace(" hour", "").Replace("s", "")));
                        }
                        ts = dtwt.Subtract(DateTime.Now);
                        lbl_timelock.Text = ts.ToString().Substring(0, 8);
                        if (dtwt.ToString() == DateTime.Now.ToString())
                        {
                            My_Class.SetValue("Time_lock_value", My_Class.Base64Encoding(dtn.ToString()));
                            My_Class.Time_lock_value = My_Class.Base64Decoding(My_Class.GetValue("Time_lock_value"));
                            lbl_timelock.Text = My_Class.Lockf;
                            if (My_Class.Lockf.IndexOf("My_Screen") < 0)
                            {
                                My_Screen ms = new My_Screen();
                                ms.Show();
                            }
                        }
                    }
                }

                if (My_Class.Time_unlock != "Never")
                {
                    if (My_Class.Time_unlock.Length > 0)
                    {
                        My_Class.Time_unlock_value = My_Class.Base64Decoding(My_Class.GetValue("Time_unlock_value"));
                        dtwt = DateTime.Parse(My_Class.Time_unlock_value);
                        if (My_Class.Time_unlock.IndexOf(" minute") > 0)
                        {
                            dtn = DateTime.Now.AddMinutes(int.Parse(My_Class.Time_unlock.Replace(" minute", "").Replace("s", "")));
                        }
                        if (My_Class.Time_unlock.IndexOf(" hour") > 0)
                        {
                            dtn = DateTime.Now.AddHours(int.Parse(My_Class.Time_unlock.Replace(" hour", "").Replace("s", "")));
                        }
                        ts = dtwt.Subtract(DateTime.Now);
                        lbl_timeunlock.Text = ts.ToString().Substring(0, 8);
                        if (dtwt.ToString() == DateTime.Now.ToString())
                        {
                            My_Class.SetValue("Time_unlock_value", My_Class.Base64Encoding(dtn.ToString()));
                            My_Class.Time_unlock_value = My_Class.Base64Decoding(My_Class.GetValue("Time_unlock_value"));
                            if (My_Class.Lockf.IndexOf("My_Screen") >= 0)
                            {
                                My_Class.Lockf = "";
                            }
                        }
                    }
                }
            }
            catch { }
        }

        private bool CheckApps(string app = "")
        {
            bool startapps = false;
            var process = Process.GetProcesses();
            foreach (var x in process)
            {
                if (x.ProcessName.ToString() == app)
                {
                    startapps = true;
                }
            }
            return startapps;
        }

        private void cbb_locktime_SelectedIndexChanged(object sender, EventArgs e)
        {
            My_Class.SetValue("Time_lock", My_Class.Base64Encoding(cbb_locktime.SelectedItem.ToString()));
            My_Class.Time_lock = My_Class.Base64Decoding(My_Class.GetValue("Time_lock"));
            if (My_Class.Time_lock == "Never")
            {
                My_Class.SetValue("Time_lock_value", ""); lbl_timelock.Text = "";
            }
            else
            {
                if (My_Class.Time_lock.IndexOf(" minute") > 0)
                {
                    dtn = DateTime.Now.AddMinutes(int.Parse(My_Class.Time_lock.Replace(" minute", "").Replace("s", "")));
                }
                if (My_Class.Time_lock.IndexOf(" hour") > 0)
                {
                    dtn = DateTime.Now.AddHours(int.Parse(My_Class.Time_lock.Replace(" hour", "").Replace("s", "")));
                }
                My_Class.SetValue("Time_lock_value", My_Class.Base64Encoding(dtn.ToString()));
                My_Class.Time_lock_value = My_Class.Base64Decoding(My_Class.GetValue("Time_lock_value"));
            }
        }

        private void cbb_unlocktime_SelectedIndexChanged(object sender, EventArgs e)
        {
            My_Class.SetValue("Time_unlock", My_Class.Base64Encoding(cbb_unlocktime.SelectedItem.ToString()));
            My_Class.Time_unlock = My_Class.Base64Decoding(My_Class.GetValue("Time_unlock"));
            if (My_Class.Time_unlock == "Never")
            {
                My_Class.SetValue("Time_unlock_value", ""); lbl_timeunlock.Text = "";
            }
            else
            {
                if (My_Class.Time_unlock.IndexOf(" minute") > 0)
                {
                    dtn = DateTime.Now.AddMinutes(int.Parse(My_Class.Time_unlock.Replace(" minute", "").Replace("s", "")));
                }
                if (My_Class.Time_unlock.IndexOf(" hour") > 0)
                {
                    dtn = DateTime.Now.AddHours(int.Parse(My_Class.Time_unlock.Replace(" hour", "").Replace("s", "")));
                }
                My_Class.SetValue("Time_unlock_value", My_Class.Base64Encoding(dtn.ToString()));
                My_Class.Time_unlock_value = My_Class.Base64Decoding(My_Class.GetValue("Time_unlock_value"));
            }
        }

        private void btn_path_data_Click(object sender, EventArgs e)
        {
            OpenFileDialog odata = new OpenFileDialog();
            odata.ValidateNames = false;
            odata.CheckFileExists = false;
            odata.CheckPathExists = true;
            odata.FileName = "Folder Selection.";
            if (odata.ShowDialog() == DialogResult.OK)
            {
                txt_path_data.Text = Path.GetDirectoryName(odata.FileName);
            }
        }

        private void btn_save_data_Click(object sender, EventArgs e)
        {
            My_Class.SetValue("PaData", My_Class.Base64Encoding(txt_path_data.Text));
            My_Class.PaData = My_Class.Base64Decoding(My_Class.GetValue("PaData"));
            MessageBox.Show("Save Successfuly!");
        }

        private void btn_path_screen_Click(object sender, EventArgs e)
        {
            OpenFileDialog oscreen = new OpenFileDialog();
            oscreen.DefaultExt = "EXE file (*.exe)|*.exe";
            oscreen.Filter = "EXE file (*.exe)|*.exe";
            if (oscreen.ShowDialog() == DialogResult.OK)
            {
                txt_path_screen.Text = oscreen.FileName;
            }
        }

        private void btn_save_screen_Click(object sender, EventArgs e)
        {
            My_Class.SetValue("PaScreen", My_Class.Base64Encoding(txt_path_screen.Text));
            My_Class.PaScreen = My_Class.Base64Decoding(My_Class.GetValue("PaScreen"));
            MessageBox.Show("Save Successfuly!");
        }

        private void btn_path_customer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ocustomer = new OpenFileDialog();
            ocustomer.DefaultExt = "EXE file (*.exe)|*.exe";
            ocustomer.Filter = "EXE file (*.exe)|*.exe";
            if (ocustomer.ShowDialog() == DialogResult.OK)
            {
                txt_path_customer.Text = ocustomer.FileName;
            }
        }

        private void btn_save_customer_Click(object sender, EventArgs e)
        {
            My_Class.SetValue("PaCustomer", My_Class.Base64Encoding(txt_path_customer.Text));
            My_Class.PaCustomer = My_Class.Base64Decoding(My_Class.GetValue("PaCustomer"));
            MessageBox.Show("Save Successfuly!");
        }

        

        

    }
}
