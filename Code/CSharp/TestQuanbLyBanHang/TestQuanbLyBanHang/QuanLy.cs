using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TestQuanbLyBanHang
{
    class QuanLy
    {
        public void XuLy(int chon)
        {
            SqlCommand cmd = new SqlCommand();
            ketnoi kn = new ketnoi();
            kn.ket_noi();
            cmd.Connection = kn.con;

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DangNhap ", kn.con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);

            if (dt.Rows[0][2].ToString() == "dung")
            {
                switch (chon)
                {
                    case 1:
                        {
                            Form4 frm = new Form4();
                            frm.Text = "Quan Ly Danh Muc Thanh Pho";
                            frm.ShowDialog();
                            break;
                        }
                    case 2:
                        {
                            Form5 frm = new Form5();
                            frm.Text = "Quan Ly Danh Muc Khach Hang";
                            frm.ShowDialog();
                            break;
                        }
                    case 3:
                        {
                            Form6 frm = new Form6();
                            frm.Text = "Quan Ly Danh Muc Hoa Don";
                            frm.ShowDialog();
                            break;
                        }
                    case 4:
                        {
                            Form7 frm = new Form7();
                            frm.Text = "Quan Ly Danh Muc Nhan Vien";
                            frm.ShowDialog();
                            break;
                        }
                    case 5:
                        {
                            Form8 frm = new Form8();
                            frm.Text = "Quan Ly Danh Muc San Pham";
                            frm.ShowDialog();
                            break;
                        }
                    case 6:
                        {
                            Form9 frm = new Form9();
                            frm.Text = "Quan Ly Danh Muc Chi Tiet Hoa Don";
                            frm.ShowDialog();
                            break;
                        }
                    case 7:
                        {
                            Form13 frm = new Form13();
                            frm.Text = "Doi Mat Khau";
                            frm.ShowDialog();
                            break;
                        }
                    default:
                        break;
                }
            }
            else
            {
                Form2 frm = new Form2();
                frm.Text = "Dang Nhap";
                frm.ShowDialog();
            }
        }
        public void Huy()
        {
            SqlCommand cmd = new SqlCommand();
            ketnoi kn = new ketnoi();
            kn.ket_noi();
            cmd.Connection = kn.con;
            cmd.CommandText = System.String.Concat("UPDATE DangNhap SET TG='sai'");
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
    }
}
