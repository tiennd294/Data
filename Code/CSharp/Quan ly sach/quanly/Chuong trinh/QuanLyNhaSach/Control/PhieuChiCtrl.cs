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
    public class PhieuChiCtrl
    {
        PhieuChiData pcData = new PhieuChiData();
        DataShow ds = new DataShow();
        public void HienThi(DataGridView dg, BindingNavigator bn, TextBox t)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Tbl_PhieuChi();
            bn.BindingSource = bs;
            dg.DataSource = bs;
            t.Text = dg[0, 0].Value.ToString();

        }

        public DataTable Tbl_PhieuChi()
        {
            string select = "Select * from PHIEUCHI";
            return pcData.Table_PhieuChi(select);
        }

        public void ThemPC(string MaPC, string MaNV, string MaNCC, string NgayLap, string LyDoChi, string TongTien)
        {
            string str = "Insert into PHIEUCHI values('" +MaPC+ "','" + MaNV + "','" +MaNCC+ "','" + NgayLap + "','" + LyDoChi + "','" + TongTien + "')";
            pcData.ThemPC(str);

        }

        public void XoaPC(string maPC)
        {
            string str = "delete from PHIEUCHI where MAPC='" + maPC + "'";
            pcData.XoaPC(str);
        }

        public void UpdatePC(PhieuChiInfo pcInfo, string MaPC)
        {
            string str = "update PHIEUCHI set MAPC='" + pcInfo.maPhieuChi + "',MANV='" + pcInfo.MaNV + "',MANCC='" + pcInfo.MaNCC + "',NGAYLAP='" + pcInfo.NgayLap + "',LYDOCHI='" + pcInfo.LyDoChi + "',TONGSOTIEN='" + pcInfo.TongTien + "'";
            str += "where MAPC = '" + MaPC + "'";
            pcData.UpdatePC(str);          
        }
        public void HienThiListView(ListView lv)
        {
            lv.Items.Clear();

            DataTable dtb = pcData.DS_PhieuChi();

            int n = 0;
            foreach (DataRow row in dtb.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPC"].ToString());
                //item.SubItems.Add(row["MANV"].ToString());
                //item.SubItems.Add(row["MAKH"].ToString());
                item.SubItems.Add(row["NGAYLAP"].ToString());
                item.SubItems.Add(row["LYDOCHI"].ToString());
                item.SubItems.Add(row["TONGSOTIEN"].ToString());

                lv.Items.Add(item);
            }
        }
    }
}
