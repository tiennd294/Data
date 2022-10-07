using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace WindowsForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        

        private void click1(object sender, MouseEventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.firefox_02;
        }

        private void click2(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.firefox__02_00;
        }

        private void click3(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.Firefox2006;
        }

        private void click4(object sender, MouseEventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.firefox__02_00;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
