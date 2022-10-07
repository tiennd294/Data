using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhanSo.Business;
using PhanSo.DTO;

namespace PhanSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Environment.CurrentDirectory + "\\data.xml");
            //PhanSoBLL Psxuly = new PhanSoBLL(); 
            //PhanSoDTO Phanso = Psxuly.Docdulieu(Environment.CurrentDirectory+"data.xml");
            //txtTuso.Text = Phanso.Tuso.ToString();
            //txtMauso.Text = Phanso.Mauso.ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
               
                PhanSoBLL PsXuly = new PhanSoBLL();
                PhanSoDTO PhanSo = new PhanSoDTO();
                PhanSo.Tuso = int.Parse(txtTuso.Text);
                PhanSo.Mauso = int.Parse(txtMauso.Text);
                PsXuly.Ghidulieu(PhanSo, Environment.CurrentDirectory + "\\data.xml");
                MessageBox.Show("thanh cong");
            }
            catch (Exception ex)
            { MessageBox.Show("loi roi"+ex); }
        }
    }
}
