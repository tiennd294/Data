using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phuong_Trinh_Bac_2
{
    public partial class Form1 : Form
    {
        double a, b, c;
        string thongbao;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtXuatX1.Enabled = false;
            txtXuatX2.Enabled = false;
            Focus();
        }

        private void txtThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
                Application.Exit();
        }

        private void txtBoQua_Click(object sender, EventArgs e)
        {
            txtNhapA.ResetText();
            txtNhapB.ResetText();
            txtNhapC.ResetText();
            txtNhapA.Focus();
        }

        public void Input(ref int flag)
        {
            try
            {
                a = double.Parse(txtNhapA.Text);
                b = double.Parse(txtNhapB.Text);
                c = double.Parse(txtNhapC.Text);
            }
            catch
            {
                MessageBox.Show("Bạn nhập sai rồi!", "Thông báo");
                flag = 1;//danh dau co dau tien neu loi
                txtNhapA.Focus();
            }
        }
        public void XuLy()
        {
            if (a == 0)
                if (b == 0)
                    if (c == 0)
                        MessageBox.Show("Phương Trình Vô Số Nghiệm", "Kết quả");
                    else
                        MessageBox.Show("Phương Trình Vô Nghiệm1", "Kết quả");
                else
                {
                    thongbao = "Phương trình có nghiệm là: \n\n" + (-c / b).ToString();
                    MessageBox.Show(thongbao, "Kết quả");
                }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    MessageBox.Show("Phương Trình Vô Nghiệm", "Thông báo");
                else if (delta == 0)
                {
                    thongbao = "Phương trình có nghiệm kép: \n\n" + (-b / (2 * a)).ToString();
                    MessageBox.Show(thongbao, "Ket qua");
                }
                else
                {
                    txtXuatX1.Text = ((-b + Math.Sqrt(delta)) / (2 * a)).ToString();
                    txtXuatX2.Text = ((-b - Math.Sqrt(delta)) / (2 * a)).ToString();
                }
            }
        }
       

        private void txtNhapA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");
        }

        private void txtNhapB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");
        }

        private void txtNhapC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");
        }

        private void btmThucHien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmThucHien_Click_1(object sender, EventArgs e)
        {
            int flag = 0;//cai dat mat dinh cho la co
            Input(ref flag);//truyen gia la co
            if (flag == 0)//o tren ta co flag =1 o day ta co flag =0 thi neu flag khac 1 thi thuc thi ham xuly con =1 thi ngung chuong trinh
                XuLy();// zax flag la gj ha a
            //no la 1 en thoi e de luu gia tri tai thoi diem xay ra su kien roi goi no lai thoi con ref ma e hoi la truyen tham so e doc lai cuon ebook hom truoc 
            //e se ro ref la gi
            //nhung bai tap ve ke thua da hinh deu chyen wa gjao dien dc ha a
            //tat ca deu dc ko co j khong the lam
            // khj nao thj saj den stack queue ha a
            //a oi

        }
    }
}