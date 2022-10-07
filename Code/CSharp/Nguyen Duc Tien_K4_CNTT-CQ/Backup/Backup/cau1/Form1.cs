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
            MessageBox.Show("Họ và Tên: Nguyen Tuan Minh \nNgày Sinh: 19/11/1993 \nLớp: K4CNTT-LT", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thoatChuongTrinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }
    }
}
