using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UNGDUNG
{
    public partial class frmAppend : Form
    {
        public frmAppend()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream f = new FileStream(textBox1.Text, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(f);
                sw.BaseStream.Seek(0, SeekOrigin.End);
                sw.WriteLine(textBox2.Text);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            string strFilter = "All Text File(.txt) |*.txt|";
            strFilter += "All Document (.doc)|*.doc";
            op.Filter = strFilter;
            if (op.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = op.FileName;
            }
        }
        void ReadFile(string path)
        {
            try
            {
                if (path != "")
                {
                    StreamReader sr = new StreamReader(path);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream f = new FileStream(textBox1.Text, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(f);
                sw.BaseStream.Seek(0, SeekOrigin.Begin);
                sw.WriteLine(textBox2.Text);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
    }
}