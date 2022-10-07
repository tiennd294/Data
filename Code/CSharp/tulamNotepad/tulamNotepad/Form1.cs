using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Collections;
using System.Windows.Forms.Design;




namespace tulamNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool dirty = false;
        string fname = "";

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;//chi chon de mo
            ofd.Filter = "Text Files|*.txt";//mo file 
            ofd.ShowDialog();
            if (File.Exists(ofd.FileName))//su ton tai
            {
                fname = ofd.FileName;//xu ly file
                StreamReader sr = new StreamReader(fname);
                richTextBox1.Text = sr.ReadToEnd();
                dirty = false;
                sr.Close();

            }	
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void savedata()
        {
            if (fname == "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files|*.txt";
                DialogResult res = sfd.ShowDialog();
                if (res == DialogResult.Cancel)
                {
                    return;
                }
                fname = sfd.FileName;
                MessageBox.Show(fname);
            }
            StreamWriter sw = new StreamWriter(fname);
            sw.WriteLine(richTextBox1.Text);
            sw.Flush();
            sw.Close();
            dirty = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savedata();
        }

    }
}
