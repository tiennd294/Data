using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StringToMD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnConvert_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(CDBSQL.md5(textBox1.Text));
            
            textBox2.Text = CDBSQL.md5(textBox1.Text);
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = CDBSQL.DecryptString(textBox2.Text, textBox2.Text);
            }
            catch { }
        }
    }
}