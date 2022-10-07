using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestQuanbLyBanHang
{
    public partial class QuanLy2 : Form
    {
        public QuanLy2()
        {
            InitializeComponent();
        }
        QuanLy Ql = new QuanLy();
        public void login()
        {
            Form2 frm = new Form2();
            frm.Text = "Dang Nhap";
            frm.ShowDialog();
        }

        // Hàm xemm danh mục
        void XemDanhMuc(int intDanhMuc)
        {
            Form3 frm = new Form3();
            frm.Text = intDanhMuc.ToString();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //login();
        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("ban co muon dung lai khong?", "Tra loi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                Ql.Huy();

                Application.Exit();
            }
        }
        
        private void danhMucThanhPhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }

        private void danhMucKhacHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(2);
        }

        private void danhMucNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(3);

        }

        private void danhMucSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(4);
        }

        private void danhMucHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(5);
        }

        private void danhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(6);
        }

        private void danhMucThanhPhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Ql.XuLy(1);
        }

        private void danhMucKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ql.XuLy(2);
        }

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ql.XuLy(3);
        }

        private void danhMucNhanVienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ql.XuLy(4);
        }

        private void danhMucSanPhamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ql.XuLy(5);
        }

        private void danhMucChiTietHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ql.XuLy(6);
        }

        private void khachHangTheoThanhPhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.Text = "Quan Ly Khach Hang Theo Thanh Pho";
            frm.ShowDialog();
        }

        private void hoaDonTheoKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            frm.Text = "Quan Ly Hoa Don Theo Khach Hang";
            frm.ShowDialog();
        }

        private void hoaDonTheoSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.Text = "Quan Ly Hoa Don Theo San Pham";
            frm.ShowDialog();
        }

        private void quanLyDanhMucDonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void heThongToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ql.Huy();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ql.Huy();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ql.XuLy(7);
        }
    }
}
