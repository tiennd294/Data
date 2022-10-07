using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhaSach.Builder_layer;

namespace QuanLyNhaSach.Data
{
    public class PhieuXuatData
    {
        DataService ds = new DataService();
        public DataTable Layctpx(string mapx)
        {
            string qr = "select * from CHI_TIET_PHIEU_XUAT_SACH where MAPHIEUXUATSACH = '" + mapx + "'";
            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);
            return ds;
        }
        public DataTable Laypx()
        {
            string qr = "select * from PHIEU_XUAT_SACH,NHANVIEN,KHACHHANG where PHIEU_XUAT_SACH.MANV=NHANVIEN.MANV AND PHIEU_XUAT_SACH.MAKH = KHACHHANG.MAKH";
            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);
            return ds;
        }
        public void luuphieuxuat(string mapx, DateTime ngay, string manv, string makh, long tongtien)
        {
            string qr = "insert into PHIEU_XUAT_SACH values('" + mapx + "','" + makh + "','" + ngay + "','" + tongtien + "'," + manv + ")";

            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);

        }
        public void capnhatphieuxuat(string mapx,string manv,string makh, DateTime ngay, long tongtien)
        {
            string qr = "update PHIEU_XUAT_SACH set  MANV = '" + manv + "',MAKH = '" + makh + "',NGAYLAP='" + ngay + "',TONGTIEN=" + tongtien + " where MAPHIEUXUATSACH='" + mapx + "'";

            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);

        }

        public void luuchitietphieuxuat(string mapx, string masach, long dongia, int soluong, long thanhtien)
        {
            string qr = "insert into CHI_TIET_PHIEU_XUAT_SACH values('" + mapx + "','" + masach + "'," + dongia + "," + soluong + "," + thanhtien + ")";
            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);
        }
        public void xoapx(string mapx)
        {
            this.xoactpx(mapx);
            string qr1 = "delete from PHIEU_XUAT_SACH where MAPHIEUXUATSACH = '" + mapx + "'";
            SqlCommand cm1 = new SqlCommand(qr1);
            ds.Load1(cm1);
        }
        public void xoactpx(string mapx)
        {
            string qr = "delete from CHI_TIET_PHIEU_XUAT_SACH where MAPHIEUXUATSACH = '" + mapx + "'";
            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);
        }

        public void ThemPhieuXuat(PhieuXuatSachInfo px)
        {
            SqlCommand cmd = new SqlCommand("insert into PHIEU_XUAT_SACH values(@maphieu,@manv,@makh, @ngaylap, @tongtien)");
            cmd.Parameters.Add("maphieu", SqlDbType.VarChar).Value = px.MaPhieuXuatSach;
            cmd.Parameters.Add("manv", SqlDbType.VarChar).Value = px.nhanvien_getset.MaNhanVien;
            cmd.Parameters.Add("makh", SqlDbType.VarChar).Value = px.khachhang_getset.MaKhachHang;
            cmd.Parameters.Add("ngaylap", SqlDbType.DateTime).Value = px.NgayLap.ToString();
            cmd.Parameters.Add("tongtien", SqlDbType.BigInt).Value = px.TongTien;

            ds.Execute(cmd);
        }
        public void XoaPhieuXuat(PhieuXuatSachInfo px)
        {
            this.xoactpx(px.MaPhieuXuatSach);
            SqlCommand cmd = new SqlCommand("delete from PHIEU_XUAT_SACH where MAPHIEUXUATSACH=@ma");
            cmd.Parameters.Add("ma", SqlDbType.NVarChar).Value = px.MaPhieuXuatSach;
            ds.Execute(cmd);
        }


        public DataTable timPhieuXuat(string maPX, string chonMaNV, string maNV, string chonMaKH, string maKH, string chonNgay, DateTime tuNgay, DateTime denNgay)
        {
            if (maPX == "")
                maPX = "";
            SqlCommand cmd = new SqlCommand();
            String sql = "select * from PHIEU_XUAT_SACH where (MAPHIEUXUATSACH Like '%' + @maPX + '%' )";
            cmd.Parameters.Add("maPX", SqlDbType.VarChar).Value = maPX;

            if (chonMaNV != "None")
            {
                sql += chonMaNV + " (MANV LIKE '%' + @manv  + '%') ";
                cmd.Parameters.Add("manv", SqlDbType.VarChar).Value = maNV;
            }
           
            if (chonNgay != "None")
            {
                sql += chonNgay + " NGAYLAP >= @Tu AND NGAYLAP <= @Den ";
                cmd.Parameters.Add("tu", SqlDbType.VarChar).Value = tuNgay;
                cmd.Parameters.Add("den", SqlDbType.VarChar).Value = denNgay;
            }

            if (chonMaKH != "None")
            {
                sql += chonMaKH + "(MAKH=@makh)";
                cmd.Parameters.Add("makh", SqlDbType.VarChar).Value = maKH;
            }
            cmd.CommandText = sql; 
            ds.Load1(cmd);
            return ds;
        }
    }
}
