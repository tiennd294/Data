using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string tenchuho;
            tenchuho = txtTenchuho.Text;

            int chisocu, chisomoi, dongia;
            chisocu = int.Parse(txtChisocu.Text);
            chisomoi = int.Parse(txtChisomoi.Text);
            dongia = int.Parse(txtDongia.Text);

            int tongsotien = (chisomoi - chisocu) * dongia;
            txtTongsotien.Text = "So tien phai thanh toan la:" + tongsotien.ToString();






        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTenchuho.Text="";
            txtChisocu.Text ="";
            txtChisomoi.Text = "";
            int dongia = 2000;
            dongia = int.Parse(txtDongia.Text);
            
            txtTenchuho.Focus();



        }
    }
}
