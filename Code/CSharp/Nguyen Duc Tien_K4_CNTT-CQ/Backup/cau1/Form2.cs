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
                
                long money = 0;
                if (checkBox1.Checked)
                {
                    
                    long a = long.Parse(textBox1.Text.ToString()) * long.Parse(textBox5.Text.ToString());
                    textBox9.Text = a.ToString()+" dong";
                    money += a;
                }
                if (checkBox2.Checked)
                {
                    long b = long.Parse(textBox2.Text.ToString()) * long.Parse(textBox6.Text.ToString());
                    textBox10.Text = b.ToString() + " dong";
                    money += b;
                }
                if (checkBox3.Checked)
                {
                    long c = long.Parse(textBox3.Text.ToString()) * long.Parse(textBox7.Text.ToString());
                    textBox11.Text = c.ToString() + " dong";
                    money += c;
                }
                if (checkBox4.Checked)
                {
                    long d = long.Parse(textBox4.Text.ToString()) * long.Parse(textBox8.Text.ToString());
                    textBox12.Text = d.ToString() + " dong";
                    money += d;
                }
                
                textBox13.Text=money.ToString()+" dong";
            }
            catch 
            {
                
                    MessageBox.Show("Chua nhap so luong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                textBox1.Enabled = false;
                textBox5.Enabled = false;
                textBox9.Enabled = false;
                this.textBox9.BackColor = System.Drawing.SystemColors.Control;
                this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                textBox1.Enabled = true;
                textBox5.Enabled = true;
                textBox9.Enabled = true;
                this.textBox9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                this.textBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            }
            if (checkBox1.Checked)
                if (checkBox2.Checked)
                    if (checkBox3.Checked)
                        if (checkBox4.Checked)
                        {
                            this.radioButton1.Checked = true;
                            
                        }
            if (!checkBox1.Checked)
                this.radioButton2.Checked = true;
            if (!checkBox4.Checked)
                if (!checkBox2.Checked)
                    if (!checkBox3.Checked)
                        if (!checkBox1.Checked)
                            this.textBox13.BackColor = System.Drawing.SystemColors.Control;
                        else
                            this.textBox13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                textBox2.Enabled = false;
                textBox6.Enabled = false;
                textBox10.Enabled = false;
                this.textBox10.BackColor = System.Drawing.SystemColors.Control;
                this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                textBox2.Enabled = true;
                textBox6.Enabled = true;
                textBox10.Enabled = true;
                this.textBox10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                this.textBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            }
            if (checkBox1.Checked)
                if (checkBox2.Checked)
                    if (checkBox3.Checked)
                        if (checkBox4.Checked)
                            this.radioButton1.Checked = true;
            if (!checkBox2.Checked)
                this.radioButton2.Checked = true;
            if (!checkBox4.Checked)
                if (!checkBox1.Checked)
                    if (!checkBox3.Checked)
                        if (!checkBox2.Checked)
                            this.textBox13.BackColor = System.Drawing.SystemColors.Control;
                        else
                            this.textBox13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox3.Checked)
            {
                textBox3.Enabled = false;
                textBox7.Enabled = false;
                textBox11.Enabled = false;
                this.textBox11.BackColor = System.Drawing.SystemColors.Control;
                this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                textBox3.Enabled = true;
                textBox7.Enabled = true;
                textBox11.Enabled = true;
                this.textBox11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                this.textBox7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            }
            if (checkBox1.Checked)
                if (checkBox2.Checked)
                    if (checkBox3.Checked)
                        if (checkBox4.Checked)
                            this.radioButton1.Checked = true;
            if(!checkBox3.Checked)
                this.radioButton2.Checked = true;
            if (!checkBox4.Checked)
                if (!checkBox2.Checked)
                    if (!checkBox1.Checked)
                        if (!checkBox3.Checked)
                            this.textBox13.BackColor = System.Drawing.SystemColors.Control;
                        else
                            this.textBox13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox4.Checked)
            {
                textBox4.Enabled = false;
                textBox8.Enabled = false;
                textBox12.Enabled = false;
                this.textBox12.BackColor = System.Drawing.SystemColors.Control;
                this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                textBox4.Enabled = true;
                textBox8.Enabled = true;
                textBox12.Enabled = true;
                this.textBox12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                this.textBox8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            }
            if (checkBox1.Checked)
                if (checkBox2.Checked)
                    if (checkBox3.Checked)
                        if (checkBox4.Checked)
                            this.radioButton1.Checked = true;
            if (!checkBox4.Checked)
                this.radioButton2.Checked = true;
            if (!checkBox1.Checked)
                if (!checkBox2.Checked)
                    if (!checkBox3.Checked)
                        if (!checkBox4.Checked)
                            this.textBox13.BackColor = System.Drawing.SystemColors.Control;
                        else
                            this.textBox13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            textBox5.Text = "22000";
            textBox6.Text = "20000";
            textBox7.Text = "4200";
            textBox8.Text = "7100";
            this.textBox1.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Text = "22000";
            textBox6.Text = "20000";
            textBox7.Text = "4200";
            textBox8.Text = "7100";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Text = "23000";
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
            textBox13.Text = "";
            this.checkBox1.Checked = true;
            this.checkBox2.Checked = true;
            this.checkBox3.Checked = true;
            this.checkBox4.Checked = true;
            this.textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhap sai!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhap sai!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhap sai!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhap sai!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
        //    {
        //           e.Handled = true;
        //           MessageBox.Show("Chỉ nhận số nguyên dương ! ");
        //    }

    }
}
