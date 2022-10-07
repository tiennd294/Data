using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using QuanLyNhaSach.Control;

namespace QuanLyNhaSach
{
    public partial class frmSachThanhLy : DockContent
    {
        SachThanhLyCtrl stl_Ctrl = new SachThanhLyCtrl();
        public frmSachThanhLy()
        {
            InitializeComponent();
        }

        private void frmSachThanhLy_Load(object sender, EventArgs e)
        {
            stl_Ctrl.HienThi(txtMaTL, txtMaSach, txtLyDoTL, dateTimePickerNL, txtGhiChu, dataGridView1);
        }
    }
}