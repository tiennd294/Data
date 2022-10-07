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
    public class PhieuThuCtrl
    {
        PhieuThuData ptData = new PhieuThuData();
        DataShow ds = new DataShow();        
        public void HienThi(DataGridView dg, BindingNavigator bn, TextBox t)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Tbl_PhieuThu();
            bn.BindingSource = bs;
            dg.DataSource = bs;
            t.Text = dg[0, 0].Value.ToString();
            
        }

        public DataTable Tbl_PhieuThu()
        {
            string select = "Select * from PHIEUTHU";
            return ptData.Table_PhieuThu(select);
        }

        public void ThemPT(string MaPT, string MaNV, string MaKH, string NgayLap, string LyDoThu, string TongTien)
        {
            string str = "Insert into PHIEUTHU values('" +MaPT+ "','" +MaNV+ "','" +MaKH+ "','" +NgayLap+ "','" +LyDoThu+ "','" +TongTien+ "')";
            ptData.ThemPT(str);

        }

        public void XoaPT(string maPT)
        {
            string str = "delete from PHIEUTHU where MAPHIEUTHU='" +maPT+ "'";
            ptData.XoaPT(str);
        }

        public void UpdatePT(PhieuThuInfo ptInfo, string MaPT)
        {
            string str = "update PHIEUTHU set MAPHIEUTHU='" +ptInfo.maPhieuThu+ "',MANV='" +ptInfo.MaNV+ "',MAKH='" +ptInfo.MaKhachHang+ "',NGAYLAP='" +ptInfo.NgayLap+ "',LYDOTHU='" +ptInfo.LyDoThu+ "',TONGTIEN='" +ptInfo.TongTien+ "'";
            str += "where MAPHIEUTHU = '" +MaPT+ "'";
            ptData.UpdatePT(str);
        }
        public void HienThiListView(ListView lv)
        {
            lv.Items.Clear();

            DataTable dtb = ptData.DS_PhieuThu();

            int n = 0;
            foreach (DataRow row in dtb.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEUTHU"].ToString());
                //item.SubItems.Add(row["MANV"].ToString());
                //item.SubItems.Add(row["MAKH"].ToString());
                item.SubItems.Add(row["NGAYLAP"].ToString());
                item.SubItems.Add(row["LYDOTHU"].ToString());
                item.SubItems.Add(row["TONGTIEN"].ToString());
                
                lv.Items.Add(item);
            }
        }
    }
}
