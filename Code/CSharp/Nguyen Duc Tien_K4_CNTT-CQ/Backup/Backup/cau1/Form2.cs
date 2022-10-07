using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cau1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    double a = double.Parse(textBox1.Text.ToString()) * double.Parse(textBox5.Text.ToString());
                    textBox9.Text = a.ToString();
                }
                if (checkBox1.Checked)
                {
                    double b = double.Parse(textBox2.Text.ToString()) * double.Parse(textBox6.Text.ToString());
                    textBox10.Text = b.ToString();
                }
                if (checkBox1.Checked)
                {
                    double c = double.Parse(textBox3.Text.ToString()) * double.Parse(textBox7.Text.ToString());
                    textBox11.Text = c.ToString();
                }
                if (checkBox1.Checked)
                {
                    double d = double.Parse(textBox4.Text.ToString()) * double.Parse(textBox8.Text.ToString());
                    textBox12.Text = d.ToString();
                }
                double money = double.Parse(textBox9.Text.ToString()) + double.Parse(textBox10.Text.ToString()) + double.Parse(textBox11.Text.ToString()) + double.Parse(textBox12.Text.ToString());
                textBox13.Text=money.ToString();
            }
            catch { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                textBox1.Enabled = false;
                textBox5.Enabled = false;
                textBox9.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
                textBox5.Enabled = true;
                textBox9.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                textBox2.Enabled = false;
                textBox6.Enabled = false;
                textBox10.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
                textBox6.Enabled = true;
                textBox10.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox3.Checked)
            {
                textBox3.Enabled = false;
                textBox7.Enabled = false;
                textBox11.Enabled = false;
            }
            else
            {
                textBox3.Enabled = true;
                textBox7.Enabled = true;
                textBox11.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox4.Checked)
            {
                textBox4.Enabled = false;
                textBox8.Enabled = false;
                textBox12.Enabled = false;
            }
            else
            {
                textBox4.Enabled = true;
                textBox8.Enabled = true;
                textBox12.Enabled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox5.Text = "22000";
            textBox6.Text = "203000";
            textBox7.Text = "4200";
            textBox8.Text = "7100";

                        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Text = "22000";
            textBox6.Text = "203000";
            textBox7.Text = "4200";
            textBox8.Text = "7100";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Text = "22000";
            textBox6.Text = "21000";
            textBox7.Text = "4500";
            textBox8.Text = "7500";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox9.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox10.Text = "";


            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
