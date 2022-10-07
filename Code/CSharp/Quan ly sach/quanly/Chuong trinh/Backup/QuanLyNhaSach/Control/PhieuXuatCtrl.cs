using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyNhaSach.Data;
using QuanLyNhaSach.Builder_layer;
using System.Windows.Forms;

namespace QuanLyNhaSach.Control
{
    public class PhieuXuatCtrl
    {
        PhieuXuatData px_Data = new PhieuXuatData();
        ThongTinSachCtrl ttsach_Ctrl = new ThongTinSachCtrl();


        public void hiethi_lv_px(ListView lv)
        {
            lv.Items.Clear();
            DataTable dt = new DataTable();
            dt = px_Data.Laypx();
            int n = 0;
            foreach (DataRow row in dt.Rows)
            {
                n++;
                ListViewItem item = new ListViewItem();
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEUXUATSACH"].ToString());
                item.SubItems.Add(row["NGAYLAP"].ToString());
                item.SubItems.Add(row["MANV"].ToString());
                item.SubItems.Add(row["HOTENNV"].ToString());
                item.SubItems.Add(row["MAKH"].ToString());
                item.SubItems.Add(row["HOTENKH"].ToString());
                item.SubItems.Add(row["TONGTIEN"].ToString());
                lv.Items.Add(item);

            }

        }
        public void hiethi_lv_ctpx(ListView lv, string mapx)
        {
            lv.Items.Clear();
            DataTable dt = new DataTable();
            dt = px_Data.Layctpx(mapx);
            int n = 0;
            foreach (DataRow row in dt.Rows)
            {
                n++;
                ListViewItem item = new ListViewItem();
                item.Text = n.ToString();
                ChiTietPhieuXuatSachInfo ctpxinfo = new ChiTietPhieuXuatSachInfo();
                ctpxinfo.sach_getset = ttsach_Ctrl.laysachtheoma(row["MASACH"].ToString());
                //ctpdinfo.sach_getset = ttsach_Ctrl.laysachtheoma(row["TENSACH"].ToString());
                //ctpdinfo.MaPhieuDatSach = (string)row["MAPHIEUDATSACH"];
                ctpxinfo.dongia_getset = (long)row["DONGIA"];
                ctpxinfo.soluong_getset = (int)row["SOLUONG"];
                ctpxinfo.thanhtien_getset = (long)row["THANHTIEN"];

                //item.SubItems.Add(row["MAPHIEUDATSACH"].ToString());
                //item.SubItems.Add(ctpdinfo.sach_getset.MaSach);
                item.SubItems.Add(ctpxinfo.sach_getset.TenSach);
                item.SubItems.Add(row["DONGIA"].ToString());
                item.SubItems.Add(row["SOLUONG"].ToString());
                item.SubItems.Add(row["THANHTIEN"].ToString());
                item.Tag = ctpxinfo;
                lv.Items.Add(item);

            }

        }
        public void luuphieuxuat(string mapx, DateTime ngay, string manv, string makh, long tongtien)
        {
            px_Data.luuphieuxuat(mapx, ngay, manv, makh, tongtien);
        }
        public void capnhatphieuxuat(string mapx, string manv, string makh,DateTime ngay, long tongtien)
        {
            px_Data.capnhatphieuxuat(mapx,manv,makh,ngay, tongtien);
        }
        public void luuchitietphieuxuat(string mapx, string masach, long dongia, int soluong, long thanhtien)
        {
            px_Data.luuchitietphieuxuat(mapx, masach, dongia, soluong, thanhtien);
        }
        public void xoapx(string mapx)
        {
            px_Data.xoapx(mapx);
        }
        public void xoactpx(string mapx)
        {
            px_Data.xoactpx(mapx);

        }

        public void ThemPhieuXuat(PhieuXuatSachInfo px1)
        {

            px_Data.ThemPhieuXuat(px1);
        }

        public void XoaPhieuXuat(PhieuXuatSachInfo px1)
        {
            px_Data.XoaPhieuXuat(px1);
        }

        public void timPhieuXuatSach(TextBox MaPX, ComboBox cbChonMaNV, TextBox tenNV, ComboBox cbChonMaKH, TextBox tenKH, ComboBox cbChonNgay, DateTimePicker dtTuNgay, DateTimePicker dtDenNgay, DataGridView dg)
        {
            DataTable tbl = px_Data.timPhieuXuat(MaPX.Text, cbChonMaNV.Text, tenNV.Text, cbChonMaKH.Text, tenKH.Text, cbChonNgay.Text, dtTuNgay.Value.Date, dtDenNgay.Value.Date);
            dg.DataSource = tbl;
        }
    }
}
