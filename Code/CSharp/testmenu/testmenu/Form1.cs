using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;



namespace testmenu
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void open1(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            if (a.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("you selected the file"+a.FileName);
            }
        }

        void onexit(object sender, EventArgs e)
        {
            Dispose();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openToolStripMenuItem.Click += new EventHandler(open1);
        }
    }
}
