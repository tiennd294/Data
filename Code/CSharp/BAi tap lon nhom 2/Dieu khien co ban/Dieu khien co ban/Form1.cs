using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dieu_khien_co_ban
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //add countries to combobox
            cboquocgia.Items.Add("VietNam");
            cboquocgia.Items.Add("England");
            cboquocgia.Items.Add("Thailand");
            cboquocgia.Items.Add("France");
            cboquocgia.Items.Add("Canada");



        }

        private void button1_Click(object sender, EventArgs e)
        {

            
     string hienthi="";
      string newline = Environment.NewLine;
      hienthi += "Hoten:" + txthoten.Text + newline;
      hienthi += "Tuoi:" + txttuoi.Text + newline;
      hienthi += "Dia chi:" + txtdiachi.Text + newline;
      hienthi += "Thanh pho:" + txtthanhpho.Text + newline;
      hienthi += "So nam kinh nghiem:" + txtsonamkinhnghiem.Text + newline;
      hienthi += "Nang luc:" + txtnangluc.Text + newline;
      hienthi += "So dien thoai:" + msodienthoai.Text + newline;
      hienthi += "Email:" + txtemail.Text + newline;

     hienthi += "Ngay tham gia:" + mngaythamgia.Text + newline;
            MessageBox.Show(hienthi, "Form 1");
}

        private void button2_Click(object sender, EventArgs e)
        {
        this.Close();
        }



        
    }
}
