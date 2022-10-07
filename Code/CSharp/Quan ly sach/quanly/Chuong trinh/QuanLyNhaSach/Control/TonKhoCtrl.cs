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
    public class TonKhoCtrl
    {
        TonKhoData tk_Data = new TonKhoData();        
        DataShow datashow = new DataShow();
        public void LoadComboBox(ComboBox cbo, string Display, string Value)
        {
            datashow.LoadToComboBox(cbo, tk_Data.DS_SachTon(), Display, Value);
        }
        //public void hienthiCBThang(ComboBox cb)
        //{   cb.DataSource = tk_Data.Laynhanvien();
        //    cb.DisplayMember = "THANG";
        //    cb.ValueMember = "THANG";
        //}
        public void HienThi(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Tbl_SachTK();
            bn.BindingSource = bs;
            dg.DataSource = bs;
            //t.Text = dg[0, 0].Value.ToString();
        }
        public void load_data(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6, TextBox t7, TextBox t8, DataGridViewRow row)
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

        public DataTable Tbl_SachTK()
        {
            string select = "Select * from TONKHO";
            return tk_Data.Table_SachTon(select);
        }

        public void ThemSachTon(string masach, string thang, string nam, string dongia, string tongnhap, string tongxuat, string tondk, string tonck)
        {
            string str = "Insert into TONKHO values('" + masach + "','" + thang + "','" + nam + "','" + dongia + "','" + tongnhap + "','" + tongxuat + "','" + tondk + "','" + tonck + "')";
            tk_Data.ThemSachTon(str);

        }

        public void XoaSachTon(string masach)
        {
            string str = "delete from TONKHO where MASACH='" + masach + "'";
            tk_Data.XoaSachTon(str);
        }

        public void UpdateSachTon(TonKhoInfo tkInfo, string maSach)
        {
            string str = "update TONKHO set MASACH='" + tkInfo.MaSach + "',THANG='" + tkInfo.Thang + "',NAM='" + tkInfo.Nam + "',DONGIABQ='" + tkInfo.DonGia + "',TONGNHAP='" + tkInfo.TongNhap + "',TONGXUAT='" + tkInfo.TongXuat + "',TONDAUKY='" + tkInfo.TonDauKy + "',TONCUOIKY='" + tkInfo.TonCuoiKy + "'";
            str += "where MASACH = '" + maSach + "'";
            tk_Data.UpdateSachTon(str);
        }



        public void TimSachTon(ComboBox c1, DataGridView dg)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = tk_Data.TimSachTon(c1.Text);
            dg.DataSource = bs;
        }
    }
}
