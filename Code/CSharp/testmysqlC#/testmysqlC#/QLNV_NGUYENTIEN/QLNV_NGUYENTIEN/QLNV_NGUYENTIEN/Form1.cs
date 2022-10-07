using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNV_NGUYENTIEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void phongBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhongBan frmphongban = new frmPhongBan();
            frmphongban.Show();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmnhanvien = new frmNhanVien();
            frmnhanvien.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
