using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testmenu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void onopen(object sender, EventArgs e)
        {
            
                MessageBox.Show("Create by Tien_Nguyen ");

            
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem.Click += new EventHandler(oncustom);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutToolStripMenuItem.Click += new EventHandler(onopen);
        }

        void onfull(object sender, EventArgs e)
        {
            ColorDialog a = new ColorDialog();
            a.FullOpen = true;
            a.ShowDialog();
        }
        void oncustom(object sender, EventArgs e)
        {
            ColorDialog a = new ColorDialog();
            a.AllowFullOpen = false;
            a.ShowDialog();
        }
        void onnomal(object sender, EventArgs e)
        {
            ColorDialog a = new ColorDialog();
            a.Color = Color.PaleGoldenrod;
            a.ShowDialog();
        }

        void onwithcolor(object sender, EventArgs e)
        {
            ColorDialog a = new ColorDialog();
            a.FullOpen = true;
            a.CustomColors = new int[5] { 0x00ff8040, 0x00c256fe, 0x00a2005, 0x0004f002, 0x002194b5 };
            a.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Run(new Form1());
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem.Click += new EventHandler(onfull);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Click += new EventHandler(onwithcolor);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem.Click += new EventHandler(onnomal);
        }
    }
}
