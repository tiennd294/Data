using System;
using System.Collections.Generic;
using System.Text;
using QuanLyNhaSach.Data;

namespace QuanLyNhaSach.Control
{
    public class TaiKhoanCtrl
    {
        TaiKhoanData tk_Data = new TaiKhoanData();
        public void ThayDoiMatKhau(string MatKhau_moi, string tenDN)
        {
            string strSQL = "update TAIKHOAN set MATKHAU='" + MatKhau_moi + "' ";
            strSQL += "where TENDN = '" + tenDN + "'";
            tk_Data.SuaTaiKhoan(strSQL);
        }
    }
}
