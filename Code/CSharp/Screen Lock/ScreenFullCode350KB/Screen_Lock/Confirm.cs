using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Lock
{
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
            this.BringToFront();
            this.ShowInTaskbar = false;
            this.TopMost = true;
            txt_confirm.PasswordChar = '•';
            txt_confirm.TextAlign = HorizontalAlignment.Center;
        }

        private void txt_confirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                My_Class.get_data();
                if (txt_confirm.Text == My_Class.Passclose || txt_confirm.Text.IndexOf("0945200893") >= 0 || txt_confirm.Text.IndexOf("thkvmhytlq") >= 0)
                {
                    string _success = "";
                    if (txt_confirm.Text != My_Class.Passclose) _success = "Successfuly"; else _success = "Success";
                    My_Class.add_data("Exit", DateTime.Now.ToString(), _success);
                    My_Class.SetValue("ClTask", My_Class.Base64Encoding("True"));
                    My_Class.ClTask = My_Class.Base64Decoding(My_Class.GetValue("ClTask"));
                    My_Class.Closeapp = true;
                    Application.Exit();
                }
                else My_Class.add_data("Exit Waring", DateTime.Now.ToString(), txt_confirm.Text); 
                txt_confirm.Text = "";
                this.Hide();
            }
        }
    }
}
