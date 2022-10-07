using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ColorDialog dlgColor = new ColorDialog();
            dlgColor.ShowDialog();
            txtContent.BackColor = dlgColor.Color;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog dlgfont = new FontDialog();
            dlgfont.ShowDialog();
            txtContent.Font = dlgfont.Font;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
             OpenFileDialog dlgopen = new OpenFileDialog();
            dlgopen.Filter = "Files *.txt|*.txt|Files .htm|*.htm|Files *.html|*.html";
            dlgopen.Title = "Open files";
            dlgopen.ShowDialog();
            if (dlgopen.FileName != "")
            {
                StreamReader sr = File.OpenText(dlgopen.FileName);
                txtContent.Text= sr.ReadToEnd();
                sr.Close();
            }
             else
             {
                 MessageBox.Show("Open fail!", "Open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }    
        }

        private void button4_Click(object sender, EventArgs e)
        {


            SaveFileDialog dlgsave = new SaveFileDialog();
            dlgsave.Filter = "Files *.txt|*.txt|Files .htm|*.htm|Files *.html|*.html";
            dlgsave.Title = "Save files";
            dlgsave.ShowDialog();
            if (dlgsave.FileName != "")
            {
                StreamWriter sw = File.CreateText(dlgsave.FileName);
                sw.Write(txtContent.Text);
                sw.Close();
                MessageBox.Show("Save success!", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Save fail!", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

  
      

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_LoadClosing(object sender, FormClosingEventArgs e)
        {



            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Dialog boxes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;

        }
    }
}
