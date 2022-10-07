using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a= Convert.ToDouble(textBox1.Text.ToString()) * Convert.ToDouble(textBox2.Text.ToString());
            textBox3.Text =a.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            textBox1.Focus();
        }

        
    }
}
