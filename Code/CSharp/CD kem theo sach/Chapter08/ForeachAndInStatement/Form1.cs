using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ForeachAndInStatement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arrDay = 
            {"Sun","Mon","Tue","Wed","Thu","Fri","Sat"};            
            foreach (string s in arrDay)
            {
                Console.WriteLine("{0}", s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
            }
        }
        void Reset()
        {
            txtEmail.Text = "";
            txtUser.Text = "";
            txtPwd.Text = "";
            txtTel.Text = "";
            cbCountry.Text = "";
        }
    }
}