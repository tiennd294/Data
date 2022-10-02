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
using System.Diagnostics;

namespace Customer
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        bool _form = false;
        public static string _path_sc = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "//Screen_Lock.exe";

        private void Customer_Load(object sender, EventArgs e)
        {
            _form = true;
        }

        private bool CheckApps(string app ="")
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

        private void TChecker_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_form)
                {
                    _form = false;
                    this.Hide();
                }
                if (!My_Class.Check_SubKey("Screen"))
                {
                    My_Class.get_data();
                    if (My_Class.Check_SubKey("Screen"))
                    {
                        My_Class.add_data("Killer apps", DateTime.Now.ToString(), "Killer Registry!", "Log");
                        My_Class.SetValue("Time_wait", My_Class.Base64Encoding("15"));
                        My_Class.SetValue("EndTask", My_Class.Base64Encoding("True"));
                    }
                };
                //else
                //{
                //    if (My_Class.Autostart == "True")
                //    {
                //        if (!My_Class.Check_Key("Screen", @"Software\Microsoft\Windows\CurrentVersion\Run"))
                //        {
                //            My_Class.autostartup(); MessageBox.Show("OK");
                //            My_Class.SetValue("Time_wait", My_Class.Base64Encoding("15"));
                //            My_Class.SetValue("EndTask", My_Class.Base64Encoding("True"));
                //        }
                //        else
                //        {
                //            if(My_Class.GetValue("Screen", @"Software\Microsoft\Windows\CurrentVersion\Run") == ""){
                //                My_Class.autostartup();
                //                My_Class.SetValue("Time_wait", My_Class.Base64Encoding("15"));
                //                My_Class.SetValue("EndTask", My_Class.Base64Encoding("True"));
                //            }
                //        }
                //    }
                //}

                My_Class.get_data();
                if (!CheckApps("Screen_Lock") && My_Class.ClTask == "False")
                {
                    My_Class.add_data("Killer apps", DateTime.Now.ToString(), "Killer Screen!", "Log");
                    My_Class.SetValue("Time_wait", My_Class.Base64Encoding("15"));
                    My_Class.SetValue("EndTask", My_Class.Base64Encoding("True"));

                    if (My_Class.PaScreen != "")
                    {
                        if (File.Exists(My_Class.PaScreen))
                        {
                            Process.Start(My_Class.PaScreen);
                        }
                    }
                    else
                    {
                        if (File.Exists(_path_sc))
                        {
                            Process.Start(_path_sc);
                        }
                    }
                }
                if (My_Class.ClTask == "True")
                {
                    this.Close();
                }
            }
            catch (Exception ex) { /*MessageBox.Show(ex.ToString());*/ }
        }
    }
}
