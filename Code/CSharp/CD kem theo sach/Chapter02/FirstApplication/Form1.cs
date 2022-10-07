using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FirstApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.ResourceManager.GetString("Taikhoan");
            label2.Text = Properties.Resources.ResourceManager.GetString("Matkhau");
            Text = Properties.Resources.ResourceManager.GetString("Tuade");
        }
    }
}