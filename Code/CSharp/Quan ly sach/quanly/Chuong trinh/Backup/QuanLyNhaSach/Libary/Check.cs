using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhaSach.Libary
{
    public class Check
    {      
            DataService data;
            DataTable table;
            //DataRow row;
            string username;

            public Check()
            {
                data = new DataService();
            }

            public bool CheckUsername(string user)
            {
                bool temp = false;
                table = data.Table("select * from NGUOIDUNG");

                foreach (DataRow row in table.Rows)
                {
                    if (user == row["TENDN"].ToString())
                    {
                        temp = true;
                        username = user;
                    }
                }
                if (temp)
                    return true;
                else
                    return false;
            }

            public bool CheckPassword(string pass)
            {
                bool temp = false;
                table = data.Table("select MATKHAU from NGUOIDUNG where TENDN = '" + username + "'");

                foreach (DataRow row in table.Rows)
                {
                    if (pass == row["MATKHAU"].ToString())
                    {
                        temp = true;
                    }
                }
                if (temp)
                    return true;
                else
                    return false;
            }

            //public string getPhanQuyen(string user)
            //{
            //    string sql = "select PHANQUYEN from NGUOIDUNG where TENDN = '" + user + "'";
            //    return data.Value(sql, "PHANQUYEN");
            //}

            public void DoiMatKhau(string tendn, string mkmoi)
            {
                SqlCommand sql = new SqlCommand("update TAIKHOAN set MATKHAU = '" + mkmoi + "' where TENDN = '" + tendn + "'");
                data.AddTypeUpdate(sql, 1);
            }
       
    }
}
