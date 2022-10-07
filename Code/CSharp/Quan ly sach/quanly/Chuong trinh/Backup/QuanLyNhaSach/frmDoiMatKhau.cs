using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaSach.Control;
using WeifenLuo.WinFormsUI.Docking;

namespace QuanLyNhaSach
{
    public partial class frmDoiMatKhau : DockContent
    {        
        TaiKhoanCtrl tk_Ctrl = new TaiKhoanCtrl();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            tk_Ctrl.ThayDoiMatKhau( txtMKMoi.Text, txtTenDN.Text);
            this.Close();
        }
    }
}