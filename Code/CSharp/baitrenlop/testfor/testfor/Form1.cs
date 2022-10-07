using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testfor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[5];
        int sopt = 0;
        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (sopt == 5)
                    MessageBox.Show("Mảng đã đầy!");
                else
                {
                    a[sopt] = Convert.ToInt32(this.txtNhap.Text);
                    sopt++;
                    this.txtNhap.ResetText();
                    this.txtNhap.Focus();
                }
            }
            catch (Exception ex)
            {
                this.lblKQ.Text = "Nhap Loi! ";
            }


        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                this.lblKQ.Text = "Mảng rỗng!";
            else
                Array.Sort(a, 0, sopt);
                this.lblKQ.Text = "Đã sắp xếp mảng tăng dần!";

        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                this.lblKQ.Text = "Mảng rỗng!";
              else
                Array.Reverse(a, 0, sopt);
            this.lblKQ.Text = "Đã sắp xếp mảng giảm dần!";

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.lblKQ.Text = "";
            sopt = 0;
            this.txtNhap.Focus();
            txtNhap.Text = "";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (sopt==0)
                this.lblKQ.Text = "Mảng rỗng!";
                else
                {
                this.lblKQ.Text="Các phần tử trong mảng là:\n\r";
                for (int i = 0; i < sopt; i++)
                this.lblKQ.Text += a[i] + "  ";
                }
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
