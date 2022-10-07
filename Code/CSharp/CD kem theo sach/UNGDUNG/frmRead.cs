using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UNGDUNG
{
    public partial class frmRead : Form
    {
        public frmRead()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileName();
            ReadFile(textBox1.Text);
        }
        void FileName()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "C:\\";
            string strFilter="All Text File(.txt) |*.txt|";
            strFilter += "All Document (.doc)|*.doc";
            op.Filter = strFilter;
            if (op.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = op.FileName;
            }
        }
        void ReadFile(string path)
        {
            if (path != "")
            {
                StreamReader sr = new StreamReader(path);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}