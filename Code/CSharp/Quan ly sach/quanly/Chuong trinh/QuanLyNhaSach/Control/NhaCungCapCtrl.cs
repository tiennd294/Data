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
    public class NhaCungCapCtrl
    {
        NhaCungCapData nccData = new NhaCungCapData();
        DataShow datashow = new DataShow();
        public void HienThiCB(ComboBox cb)
        {

            cb.DataSource = nccData.Laynhacungcap();
            cb.DisplayMember = "MANCC";
            cb.ValueMember = "MANCC";
        }

        public void HienThi(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Tbl_NhaCungCap();
            bn.BindingSource = bs;
            dg.DataSource = bs;
            //t.Text = dg[0, 0].Value.ToString();
        }

        public void LoadComboBox(ComboBox cbo, string Display, string Value)
        {
            datashow.LoadToComboBox(cbo, nccData.DS_NCC(), Display, Value);
        }
        public DataTable Tbl_NhaCungCap()
        {
            string select = "Select * from NHA_CUNG_CAP";
            return nccData.Table_NhaCungCap(select);
        }

        public void ThemNV(string MaNCC, string TenNCC, string DiaChi, string DienThoai, string MaSoThue, string GhiChu)
        {
            string str = "Insert into NHA_CUNG_CAP values('" + MaNCC + "','" + TenNCC + "','" + DiaChi + "','" + DienThoai + "','" + MaSoThue + "','" + GhiChu + "')";
            nccData.ThemNCC(str);

        }

        public void XoaNV(string maNCC)
        {
            string str = "delete from NHA_CUNG_CAP where MANCC='" + maNCC + "'";
            nccData.XoaNCC(str);
        }

        public void UpdateNV(NhaCungCapInfo nccInfo, string maNCC)
        {
            string str = "update NHA_CUNG_CAP set MANCC='" + nccInfo.MaNhaCungCap + "',TENNCC='" + nccInfo.TenNhaCungCap + "',DIACHI='" + nccInfo.DiaChi+ "',DIENTHOAI='" + nccInfo.DienThoai + "',MASOTHUE='" + nccInfo.MaSoThue + "',GHICHU='" + nccInfo.GhiChu+ "'";
            str += "where MANCC = '" + maNCC + "'";
            nccData.UpdateNCC(str);
        }

        public void TimNCC(ComboBox c1, ComboBox c2, TextBox t1, ComboBox c3, TextBox t2, ComboBox c4, TextBox t3, DataGridView dg)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = nccData.TimNCC(c1.Text, c2.Text, t1.Text, c3.Text, t2.Text, c4.Text, t3.Text);
            dg.DataSource = bs;
        }
    }
}
