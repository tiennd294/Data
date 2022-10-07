using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace thu2222
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tg = "You have registered with \n";
                tg += "Ten: " + textBox1.Text;
                tg += "\n Pass: " + textBox2.Text;
                tg += "\n gioi tinh: ";
                if (radioButton1.Checked)
                    tg += "Nam";
                else
                    tg += "Nu";
                tg += "\n Quoc gia: " + comboBox1.SelectedItem.ToString();
                tg += "\n Hot Boy: ";
                if (checkBox1.Checked)
                    tg += checkBox1.Text + " ";
                if (checkBox2.Checked)
                    tg += checkBox2.Text + " ";
                if (checkBox3.Checked)
                    tg += checkBox3.Text + " ";
                MessageBox.Show(tg);
            }
            catch { }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.Opacity = (float.Parse(trackBar1.Value.ToString())) / 100;
        }
    }
}
