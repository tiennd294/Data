using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyNhaSach.Builder_layer;

namespace QuanLyNhaSach.Data
{
    public class PhieuDatData
    {
        DataService ds = new DataService();
        public DataTable Layctpd(string mapd)
        {
            string qr = "select * from CHI_TIET_PHIEU_DAT_SACH where MAPHIEUDATSACH = '" + mapd + "'";
            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);
            return ds;
        }
        public DataTable Laypd()
        {
            string qr = "select * from PHIEU_DAT_SACH,NHANVIEN, NHA_CUNG_CAP where PHIEU_DAT_SACH.MANV=NHANVIEN.MANV AND PHIEU_DAT_SACH.MANCC = NHA_CUNG_CAP.MANCC";
            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);
            return ds;
        }
        public void luuphieudat(string mapd, DateTime ngay, string manv, string mancc, long tongtien)
        {
            string qr = "insert into PHIEU_DAT_SACH values('" + mapd + "','" + mancc + "','" + ngay + "','" + tongtien + "'," + manv + ")";
            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);

        }
        public void capnhatphieudat(string mapd,string manv,string mancc, DateTime ngay, long tongtien)
        {
            
            string qr = "update PHIEU_DAT_SACH set  MANV = '" + manv + "',MANCC = '" + mancc + "',NGAYDAT='" + ngay + "',TONGTIEN=" + tongtien + " where MAPHIEUDATSACH='" + mapd + "'";            
            SqlCommand cm = new SqlCommand(qr);            
            ds.Load1(cm);

        }

        public void luuchitietphieudat(string mapd, string masach, long dongia, int soluong, long thanhtien)
        {
            string qr = "insert into CHI_TIET_PHIEU_DAT_SACH values('" + mapd + "','" + masach + "'," + dongia + "," + soluong + "," + thanhtien + ")";
            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);
        }
        public void xoapd(string mapd)
        {
            this.xoactpd(mapd);
            string qr1 = "delete from PHIEU_DAT_SACH where MAPHIEUDATSACH = '" + mapd + "'";
            SqlCommand cm1 = new SqlCommand(qr1);
            ds.Load1(cm1);
        }
        public void xoactpd(string mapd)
        {
            string qr = "delete from CHI_TIET_PHIEU_DAT_SACH where MAPHIEUDATSACH = '" + mapd + "'";
            SqlCommand cm = new SqlCommand(qr);
            ds.Load1(cm);
        }

        public void ThemPhieuDat(PhieuDatSachInfo pd)
        {
            SqlCommand cmd = new SqlCommand("insert into PHIEU_DAT_SACH values(@maphieu,@manv,@mancc, @ngaydat, @tongtien)");
            cmd.Parameters.Add("maphieu", SqlDbType.NVarChar).Value = pd.MaPhieuDatSach;
            cmd.Parameters.Add("manv", SqlDbType.NVarChar).Value = pd.nhanvien_getset.MaNhanVien;
            cmd.Parameters.Add("mancc", SqlDbType.NVarChar).Value = pd.nhacungcap_getset.MaNhaCungCap;
            cmd.Parameters.Add("ngaydat", SqlDbType.DateTime).Value = pd.NgayDat.ToString();
            cmd.Parameters.Add("tongtien", SqlDbType.BigInt).Value = pd.TongTien; 
            ds.Execute(cmd);
        }
        public void XoaPhieuDat(PhieuDatSachInfo pd)
        {
            this.xoactpd(pd.MaPhieuDatSach);
            SqlCommand cmd = new SqlCommand("delete from PHIEU_DAT_SACH where MAPHIEUDATSACH=@ma");
            cmd.Parameters.Add("ma", SqlDbType.NVarChar).Value = pd.MaPhieuDatSach;
            ds.Execute(cmd);
        }


        public DataTable timPhieuDat(string maPD, string chonMaNV,string maNV, string chonMaNCC,string maNCC, string chonNgay, DateTime tuNgay, DateTime denNgay)
        {
            if (maPD == "")
                maPD = "";
            SqlCommand cmd = new SqlCommand();
            String sql = "select * from PHIEU_DAT_SACH where (MAPHIEUDATSACH Like '%' + @maPD + '%' )";
            cmd.Parameters.Add("maPD", SqlDbType.VarChar).Value = maPD;
            
            if (chonMaNV != "None")
            {
                sql += chonMaNV + " (MANV LIKE '%' + @manv  + '%') ";
                cmd.Parameters.Add("manv", SqlDbType.VarChar).Value = maNV;
            }

           
            if (chonNgay != "None")
            {
                sql += chonNgay + " NGAYDAT >= @Tu AND NGAYDAT <= @Den ";
                cmd.Parameters.Add("Tu", SqlDbType.VarChar).Value = tuNgay;
                cmd.Parameters.Add("Den", SqlDbType.VarChar).Value = denNgay;
            }          
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
