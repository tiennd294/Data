using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyNhaSach.Data;
using QuanLyNhaSach.Builder_layer;
using System.Windows.Forms;

namespace QuanLyNhaSach.Control
{
    public class PhieuNhanCtrl
    {
        PhieuNhanData pn_Data = new PhieuNhanData();
        ThongTinSachCtrl ttsach_Ctrl = new ThongTinSachCtrl();

        public void hiethi_lv_pn(ListView lv)
        {
            lv.Items.Clear();
            DataTable dt = new DataTable();
            dt = pn_Data.Laypn();
            int n = 0;
            foreach (DataRow row in dt.Rows)
            {
                n++;
                ListViewItem item = new ListViewItem();
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEUNHANSACH"].ToString());
                item.SubItems.Add(row["NGAYNHAN"].ToString());
                item.SubItems.Add(row["MANV"].ToString());
                item.SubItems.Add(row["HOTENNV"].ToString());
                item.SubItems.Add(row["MANCC"].ToString());
                item.SubItems.Add(row["TENNCC"].ToString());
                item.SubItems.Add(row["TONGTIEN"].ToString());
                item.SubItems.Add(row["MAPHIEUDATSACH"].ToString());
                lv.Items.Add(item);

            }            

        }
        public void hiethi_lv_ctpn(ListView lv, string mapn)
        {
            lv.Items.Clear();
            DataTable dt = new DataTable();
            dt = pn_Data.Layctpn(mapn);
            int n = 0;
            foreach (DataRow row in dt.Rows)
            {
                n++;
                ListViewItem item = new ListViewItem();
                item.Text = n.ToString();
                ChiTietPhieuNhanSachInfo ctpninfo = new ChiTietPhieuNhanSachInfo();
                ctpninfo.sach_getset = ttsach_Ctrl.laysachtheoma(row["MASACH"].ToString());
                ctpninfo.dongia_getset = (long)row["DONGIA"];
                ctpninfo.soluong_getset = (int)row["SOLUONG"];
                ctpninfo.thanhtien_getset = (long)row["THANHTIEN"];

                //item.SubItems.Add(row["MAPHIEUNHANSACH"].ToString());
                //item.SubItems.Add(ctpninfo.sach_getset.MaSach);
                item.SubItems.Add(ctpninfo.sach_getset.TenSach);
                item.SubItems.Add(row["DONGIA"].ToString());
                item.SubItems.Add(row["SOLUONG"].ToString());
                item.SubItems.Add(row["THANHTIEN"].ToString());
                item.Tag = ctpninfo;
                lv.Items.Add(item);

            }

        }
        public void luuphieunhan(string mapn, DateTime ngay, string manv, string mancc, long tongtien,string mapd)
        {
            pn_Data.luuphieunhan(mapn, ngay, manv, mancc, tongtien,mapd);
        }
        public void capnhatphieunhan(string mapn, string manv, string mancc, DateTime ngay, long tongtien,string mapd)
        {
            pn_Data.capnhatphieunhan(mapn, manv, mancc, ngay, tongtien,mapd);
        }
        public void luuchitietphieunhan(string mapn, string masach, long dongia, int soluong, long thanhtien)
        {
            pn_Data.luuchitietphieunhan(mapn, masach, dongia, soluong, thanhtien);
        }
        public void xoapn(string mapn)
        {
            pn_Data.xoapn(mapn);
        }
        public void xoactpn(string mapn)
        {
            pn_Data.xoactpn(mapn);

        }

        public void ThemPhieuNhan(PhieuNhanSachInfo pn1)
        {

            pn_Data.ThemPhieuNhan(pn1);
        }

        public void XoaPhieuNhan(PhieuNhanSachInfo pn1)
        {
            pn_Data.XoaPhieuNhan(pn1);
        }

        public void timPhieuNhanSach(TextBox MaPN, ComboBox cbChonMaNV, TextBox tenNV, ComboBox cbChonMaNCC, TextBox tenNCC, ComboBox cbChonNgay, DateTimePicker dtTuNgay, DateTimePicker dtDenNgay, DataGridView dg)
        {
            DataTable tbl = pn_Data.timPhieuNhan(MaPN.Text, cbChonMaNV.Text, tenNV.Text, cbChonMaNCC.Text, tenNCC.Text, cbChonNgay.Text, dtTuNgay.Value.Date, dtDenNgay.Value.Date);
            dg.DataSource = tbl;
        }
    }
}
