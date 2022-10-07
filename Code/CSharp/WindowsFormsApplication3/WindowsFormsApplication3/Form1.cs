using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string tenchuho;
            tenchuho = txttenchuho.Text;

            int chisocu, chisomoi, dongia;
            chisocu = int.Parse(txtchisocu.Text);
            chisomoi = int.Parse(txtchisomoi.Text);
            dongia = int.Parse(txtdongia.Text);

            int tongsotien = (chisomoi - chisocu) * dongia;
            txttongsotien.Text = "So tien phai thanh toan la:" + tongsotien.ToString();






        }

        private void button2_Click(object sender, EventArgs e)
        {


            txttenchuho.Text = "";
            txtchisocu.Text = "";
            txtchisomoi.Text = "";
            int dongia = 2000;
            dongia = int.Parse(txtdongia.Text);

        }
    }
}
