using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaSach.Data
{
    public class SachThanhLyData
    {
        DataService data = new DataService();
        public DataTable Ds_SachThanhLy()
        {
            string select = "Select * from SACH_THANH_LY";
            return data.Table(select); 
        }
    }
}
