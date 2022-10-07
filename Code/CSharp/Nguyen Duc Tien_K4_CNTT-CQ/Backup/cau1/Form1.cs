using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cau1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gioiThieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Họ và Tên: Nguyễn Đức Tiến \nNgày Sinh: 10/07/1991 \nLớp: K4_CNTT-CQ", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thoatChuongTrinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 a = new Form2();
                a.MdiParent = this;
                a.Show();
            }
            catch { }
        }
    }
}
