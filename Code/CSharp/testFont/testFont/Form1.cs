using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testFont
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hoten = this.txtHoTen.Text.Trim();
            if (this.rad1.Checked == true)
                txtKQ.Text = hoten.ToLower();
            if (this.rad2.Checked == true)
                txtKQ.Text = hoten.ToUpper();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtHoTen.Clear();
            this.txtKQ.Clear();
            this.rad1.Checked = true;
            this.txtHoTen.Focus();

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.firefox_02;
           
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.firefox__02_00;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string hoten = this.txtHoTen.Text.Trim();
            if (this.rad1.Checked == true)
                txtKQ.Text = hoten.ToLower();
            if (this.rad2.Checked == true)
                txtKQ.Text = hoten.ToUpper();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.Firefox2006;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.firefox__02_00;
        }

        

        
    }
}
