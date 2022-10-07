using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyNhaSach.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNhaSach.Builder_layer;

namespace QuanLyNhaSach.Control
{
    public class ThongTinSachCtrl
    {
        ThongTinSachData tts_Data = new ThongTinSachData();
        DataShow datashow = new DataShow();                
        public void HienThi(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Tbl_ThongTinSach();
            bn.BindingSource = bs;
            dg.DataSource = bs;
            //t.Text = dg[0, 0].Value.ToString();
        }
        public ThongTinSachInfo laysachtheoma(string masach)
        {
            ThongTinSachInfo ttsach_Info = new ThongTinSachInfo();
            DataTable tb = tts_Data.Ds_TTinSach(masach);
            foreach (DataRow row in tb.Rows)
            {
                ttsach_Info.MaSach = row["MASACH"].ToString();
                ttsach_Info.TenSach = row["TENSACH"].ToString();
            }
            return ttsach_Info;
        }

        public void Hienthi_listtview(ListView lv)
        {
            DataTable tb = tts_Data.LaySach();
            int n = 0;
            foreach (DataRow row in tb.Rows)
            {
                n++;
                ListViewItem item = new ListViewItem();
                item.Text = n.ToString();
                item.SubItems.Add(row["MASACH"].ToString());
                item.SubItems.Add(row["TENSACH"].ToString());
                item.SubItems.Add(row["THELOAISACH"].ToString());
                item.SubItems.Add(row["TACGIA"].ToString());
                item.SubItems.Add(row["DONGIA"].ToString());
                item.SubItems.Add(row["SOLUONG"].ToString());
                item.SubItems.Add(row["NAMXB"].ToString());
                item.SubItems.Add(row["NHAXB"].ToString());
                lv.Items.Add(item);
            }
        }
        public void load_data(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6, TextBox t7,TextBox t8,DataGridViewRow row)
        {
            t1.Text = row.Cells[0].Value.ToString();
            t2.Text = row.Cells[1].Value.ToString();
            t3.Text = row.Cells[2].Value.ToString();
            t4.Text = row.Cells[3].Value.ToString();
            t5.Text = row.Cells[4].Value.ToString();
            t6.Text = row.Cells[5].Value.ToString();
            t7.Text = row.Cells[6].Value.ToString();
            t8.Text = row.Cells[7].Value.ToString();
        }

        public DataTable Tbl_ThongTinSach()
        {
            string select = "Select * from THONG_TIN_SACH";
            return tts_Data.Table_ThongTinSach(select);
        }

        public void ThemThongTinSach(string masach, string theloai, string tensach,string tacgia, string dongia, string soluong, string namxb,string nhaxb)
        {
            string str = "Insert into THONG_TIN_SACH values('" + masach + "','" + theloai + "','" + tensach + "','" + tacgia + "','" + dongia + "','" + soluong + "','" + namxb + "','" + nhaxb + "')";
            tts_Data.ThemThongTinSach(str);

        }

        public void XoaThongTinSach(string masach)
        {
            string str = "delete from THONG_TIN_SACH where MASACH='" + masach + "'";
            tts_Data.XoaThongTinSach(str);
        }

        public void UpdateTTS(ThongTinSachInfo tts_Info, string masach)
        {
            string str = "update THONG_TIN_SACH set MASACH='" + tts_Info.MaSach + "',THELOAISACH='" + tts_Info.LoaiSach + "',TENSACH='" + tts_Info.TenSach + "',TACGIA='" + tts_Info.TacGia + "',DONGIA='" + tts_Info.DonGia + "',SOLUONG='" + tts_Info.SoLuong + "',NAMXB='" + tts_Info.NamXB + "',NHAXB='" + tts_Info.NhaXB + "'";
            str += "where MASACH = '" + masach + "'";
            tts_Data.UpdateThongTinSach(str);
        }
    }
}
