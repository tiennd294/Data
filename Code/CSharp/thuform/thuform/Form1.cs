﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace thuform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("jjjjjjjjjjjjj");
        }
    }
}
