using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhaSach.Builder_layer;

namespace QuanLyNhaSach.Data
{
    public class DanhMucLoaiSachData
    {
        DataService ds = new DataService();
        public DataTable layDanhMucLoaiSach()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAISACH");
            ds.Load1(cmd);
            return ds;
        }
        public ErrorInfo themLoaiSach(DanhMucLoaiSachInfo ls)
        {
            SqlCommand cmd = new SqlCommand("insert into LOAISACH values(@ma, @ten)");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ls.MaLoaiSach;
            cmd.Parameters.Add("ten", SqlDbType.VarChar).Value = ls.TenLoaiSach;
            return ds.Execute1(cmd);
        }
        public ErrorInfo XoaLoaiSach(DanhMucLoaiSachInfo ls)
        {
            SqlCommand cmd = new SqlCommand("delete from LOAISACH where MALOAISACH=@ma");
            cmd.Parameters.Add("ma", SqlDbType.NVarChar).Value = ls.MaLoaiSach;

            return ds.Execute1(cmd);
        }
        public ErrorInfo CapNhatLoaiSach(DanhMucLoaiSachInfo ls)
        {
            SqlCommand cmd = new SqlCommand("update LOAISACH set TENLOAISACH=@ten where MALOAISACH=@ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ls.MaLoaiSach;
            cmd.Parameters.Add("ten", SqlDbType.VarChar).Value = ls.TenLoaiSach;
            return ds.Execute1(cmd);
        }
    }
}
