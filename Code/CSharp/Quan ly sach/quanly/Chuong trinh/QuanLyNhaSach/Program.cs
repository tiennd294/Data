using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmBackup_Database());        
            Application.Run(new frmMain());
            //Application.Run(new frmTimPhieuDatSach());
            //Application.Run(new frmDangNhap());
            //Application.Run(new frmDanhMucLoaiSach());
            //Application.Run(new frmDanhMucSach());
            //Application.Run(new frmPhieuDatSach());
            //Application.Run(new frmPhieuXuatSach());
            //Application.Run(new frmThongKeBaoCao());
            //Application.Run(new frmKhachHang());
            //Application.Run(new frmNhaCC());
            //Application.Run(new frmNhanVien());
            //Application.Run(new QuanLyNhaSach.Report.frmTKNhanVien());
            //Application.Run(new frmTonKho());
            //Application.Run(new frmPhieuNhanSach());
            //Application.Run(new QuanLyNhaSach.Report.frmReportKhachHang());
            //Application.Run(new frmTimPhieuNhanSach());
            //Application.Run(new frmDoiMatKhau());
            //Application.Run(new frmThongTinSach());
            //Application.Run(new QuanLyNhaSach.Report.frmReportPhieuXuatSach());
        }
    }
}