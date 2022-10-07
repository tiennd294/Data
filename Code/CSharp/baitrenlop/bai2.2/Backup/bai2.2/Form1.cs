using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            double a = pi * Convert.ToDouble(textBox1.Text.ToString()) * Convert.ToDouble(textBox1.Text.ToString());
            double a1 = 2 * pi * Convert.ToDouble(textBox1.Text.ToString());
            textBox2.Text = a.ToString();
            textBox3.Text = a1.ToString();
        }
    }
}
