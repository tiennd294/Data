using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cong.conghaiso;


namespace cong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_cong_Click(object sender, EventArgs e)
        {
            
            Service1 cong=new Service1();
            int so= cong.add(Convert.ToInt32(txt_so1.Text.ToString()), Convert.ToInt32(txt_so2.Text.ToString()));
            lb_kq.Text = so.ToString();// day la cach cac ngan hang chuyen tien wa lai cho nhau khi k/h rut tien tai cac may atm do
            //a oi e van k hieu? 
        }
    }
}
