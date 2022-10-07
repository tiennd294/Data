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
    public partial class frmDanhMucSach : DockContent
    {
        DanhMucSachCtrl dms_Ctrl = new DanhMucSachCtrl();
        public frmDanhMucSach()
        {
            InitializeComponent();
            dms_Ctrl.LoadComboBox(cboLoaiSach, "THELOAISACH", "MASACH");
        }

        private void frmDanhMucSach_Load(object sender, EventArgs e)
        {
            //dms_Ctrl.HienThi(dataGridView1);
        }

        private void cboLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            dms_Ctrl.HienThi(dataGridView1,cboLoaiSach.Text);
        }


    }
}