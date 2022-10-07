using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhaSach.Builder_layer;

namespace QuanLyNhaSach.Data
{
    public class PhieuNhanData
    {
        DataService ds = new DataService();
        public DataTable Layctpn(string mapn)
        {
            string qr = "select * from CHI_TIET_PHIEU_NHAN_SACH where MAPHIEUNHANSACH = '" + mapn + "'";
            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);
            return ds;
        }
        public DataTable Laypn()
        {
            string qr = "select * from PHIEU_NHAN_SACH,NHANVIEN, NHA_CUNG_CAP,PHIEU_DAT_SACH where PHIEU_NHAN_SACH.MANV=NHANVIEN.MANV AND PHIEU_NHAN_SACH.MANCC = NHA_CUNG_CAP.MANCC AND PHIEU_NHAN_SACH.MAPHIEUDATSACH= PHIEU_DAT_SACH.MAPHIEUDATSACH";
            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);
            return ds;
        }
        public void luuphieunhan(string mapn, DateTime ngay, string manv, string mancc, long tongtien,string mapd)
        {
            string qr = "insert into PHIEU_NHAN_SACH values('" + mapn + "','" + mancc + "','" + ngay + "','" + tongtien + "','" + mapd + "'," + manv + ")";

            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);

        }
        public void capnhatphieunhan(string mapn, string manv, string mancc, DateTime ngay, long tongtien, string mapd)
        {
            string qr = "update PHIEU_NHAN_SACH set  MANV = '" + manv + "',MANCC = '" + mancc + "',NGAYNHAN='" + ngay + "',TONGTIEN=" + tongtien + ",MAPHIEUDATSACH = '" + mapd + "' where MAPHIEUNHANSACH='" + mapn + "'";

            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);

        }

        public void luuchitietphieunhan(string mapn, string masach, long dongia, int soluong, long thanhtien)
        {
            string qr = "insert into CHI_TIET_PHIEU_NHAN_SACH values('" + mapn + "','" + masach + "'," + dongia + "," + soluong + "," + thanhtien + ")";
            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);
        }
        public void xoapn(string mapn)
        {
            this.xoactpn(mapn);
            string qr1 = "delete from PHIEU_NHAN_SACH where MAPHIEUNHANSACH = '" + mapn + "'";
            SqlCommand cm1 = new SqlCommand(qr1);
            ds.Load1(cm1);
        }
        public void xoactpn(string mapn)
        {
            string qr = "delete from CHI_TIET_PHIEU_NHAN_SACH where MAPHIEUNHANSACH = '" + mapn + "'";
            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);
        }

        public void ThemPhieuNhan(PhieuNhanSachInfo pn)
        {
            SqlCommand cmd = new SqlCommand("insert into PHIEU_NHAN_SACH values(@maphieu,@manv,@mancc, @ngaynhan, @tongtien,@mapd)");
            cmd.Parameters.Add("maphieu", SqlDbType.NVarChar).Value = pn.MaPhieuNhanSach;
            cmd.Parameters.Add("manv", SqlDbType.NVarChar).Value = pn.nhanvien_getset.MaNhanVien;
            cmd.Parameters.Add("mancc", SqlDbType.NVarChar).Value = pn.nhacungcap_getset.MaNhaCungCap;
            cmd.Parameters.Add("ngaynhan", SqlDbType.DateTime).Value = pn.NgayNhan.ToString();
            cmd.Parameters.Add("tongtien", SqlDbType.BigInt).Value = pn.TongTien;
            cmd.Parameters.Add("mapd", SqlDbType.NVarChar).Value = pn.phieudatsach_getset.MaPhieuDatSach;

            ds.Execute(cmd);
        }
        public void XoaPhieuNhan(PhieuNhanSachInfo pn)
        {
            this.xoactpn(pn.MaPhieuNhanSach);
            SqlCommand cmd = new SqlCommand("delete from PHIEU_NHAN_SACH where MAPHIEUNHANSACH=@ma");
            cmd.Parameters.Add("ma", SqlDbType.NVarChar).Value = pn.MaPhieuNhanSach;
            ds.Execute(cmd);
        }


        public DataTable timPhieuNhan(string maPN, string chonMaNV, string maNV, string chonMaNCC, string maNCC, string chonNgay,DateTime tuNgay, DateTime denNgay)
        {
            if (maPN == "")
                maPN = "";
            SqlCommand cmd = new SqlCommand();
            String sql = "select * from PHIEU_NHAN_SACH where (MAPHIEUNHANSACH Like '%' + @maPN + '%' )";
            cmd.Parameters.Add("maPN", SqlDbType.VarChar).Value = maPN;
            
            if (chonMaNV != "None")
            {
                sql += chonMaNV + " (MANV LIKE '%' + @manv  + '%') ";
                cmd.Parameters.Add("manv", SqlDbType.VarChar).Value = maNV;
            }
            
            if (chonNgay != "None")
            {
                sql += chonNgay + " NGAYNHAN >= @Tu AND NGAYNHAN <= @Den ";
                cmd.Parameters.Add("tu", SqlDbType.VarChar).Value = tuNgay;
                cmd.Parameters.Add("den", SqlDbType.VarChar).Value = denNgay;
            }

            //
            if (chonMaNCC != "None")
            {
                sql += chonMaNCC + "(MANCC=@mancc)";
                cmd.Parameters.Add("mancc", SqlDbType.VarChar).Value = maNCC;
            }
            cmd.CommandText = sql;

            //ds.Execute(cmd);
            ds.Load1(cmd);

            return ds;
        }
    }
}
