using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hoten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox4.Text);
            double b= double.Parse(textBox5.Text);
            double c = double.Parse(textBox6.Text);
            double d=(a+b+c)/3;
            string str = Convert.ToString(textBox1.Text);
            string str1=Convert.ToString(textBox2.Text);
            string str2=Convert.ToString(textBox3.Text);
            string str3 = "jjjjjjj"+str + Environment.NewLine + str1 + Environment.NewLine + str2;
            textBox7.Text = str3 + Environment.NewLine+d.ToString();
            
              
        }
    }
}
