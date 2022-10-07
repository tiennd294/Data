using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaSach.Data
{
    public class DanhMucSachData
    {
        DataService data = new DataService();
        public DataTable Ds_DMS(string theloaisach)
        {
            string select = "Select * from THONG_TIN_SACH where THELOAISACH='"+theloaisach+"'";
            return data.Table(select);
        }

        public DataTable table_sach()
        {
            string str = "select * from THONG_TIN_SACH";
            return data.Table(str);
        }
    }
}
