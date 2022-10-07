using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyNhaSach.Data;
using QuanLyNhaSach.Builder_layer;
using System.Windows.Forms;



namespace QuanLyNhaSach.Control
{
    public class PhieuDatCtrl
    {
        PhieuDatData pd_Data = new PhieuDatData();
        ThongTinSachCtrl ttsach_Ctrl = new ThongTinSachCtrl();

        public void HienThiCB(ComboBox cb)
        {

            cb.DataSource = pd_Data.Laypd();
            cb.DisplayMember = "MAPHIEUDATSACH";
            cb.ValueMember = "MAPHIEUDATSACH";
        }
        public void hiethi_lv_pd(ListView lv)
        {
            lv.Items.Clear();
            DataTable dt = new DataTable();
            dt = pd_Data.Laypd();
            int n = 0;
            foreach (DataRow row in dt.Rows)
            {
                n++;
                ListViewItem item = new ListViewItem();
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEUDATSACH"].ToString());
                item.SubItems.Add(row["NGAYDAT"].ToString());
                item.SubItems.Add(row["MANV"].ToString());                
                item.SubItems.Add(row["HOTENNV"].ToString());
                item.SubItems.Add(row["MANCC"].ToString());
                item.SubItems.Add(row["TENNCC"].ToString());                
                item.SubItems.Add(row["TONGTIEN"].ToString());
                lv.Items.Add(item);

            }

        }
        public void hiethi_lv_ctpd(ListView lv, string mapd)
        {
            lv.Items.Clear();
            DataTable dt = new DataTable();
            dt = pd_Data.Layctpd(mapd);
            int n = 0;
            foreach (DataRow row in dt.Rows)
            {
                n++;
                ListViewItem item = new ListViewItem();
                item.Text = n.ToString();                
                ChiTietPhieuDatSachInfo ctpdinfo = new ChiTietPhieuDatSachInfo();                
                ctpdinfo.sach_getset = ttsach_Ctrl.laysachtheoma(row["MASACH"].ToString());
                //ctpdinfo.sach_getset = ttsach_Ctrl.laysachtheoma(row["TENSACH"].ToString());
                //ctpdinfo.MaPhieuDatSach = (string)row["MAPHIEUDATSACH"];
                ctpdinfo.dongia_getset = (long)row["DONGIA"];
                ctpdinfo.soluong_getset = (int)row["SOLUONG"];
                ctpdinfo.thanhtien_getset = (long)row["THANHTIEN"];

                //item.SubItems.Add(row["MAPHIEUDATSACH"].ToString());
                //item.SubItems.Add(ctpdinfo.sach_getset.MaSach);
                item.SubItems.Add(ctpdinfo.sach_getset.TenSach);
                item.SubItems.Add(row["DONGIA"].ToString());
                item.SubItems.Add(row["SOLUONG"].ToString());
                item.SubItems.Add(row["THANHTIEN"].ToString());
                item.Tag = ctpdinfo;
                lv.Items.Add(item);

            }

        }
        public void luuphieudat(string mapd, DateTime ngay, string manv, string mancc, long tongtien)
        {
            pd_Data.luuphieudat(mapd, ngay, manv, mancc, tongtien);
        }
        public void capnhatphieudat(string mapd, string manv, string mancc, DateTime ngay, long tongtien)
        {
            pd_Data.capnhatphieudat(mapd,manv,mancc, ngay, tongtien);
        }
        public void luuchitietphieudat(string mapd, string masach, long dongia, int soluong, long thanhtien)
        {
            pd_Data.luuchitietphieudat(mapd, masach, dongia, soluong, thanhtien);
        }
        public void xoapd(string mapd)
        {
            pd_Data.xoapd(mapd);
        }
        public void xoactpd(string mapd)
        {
            pd_Data.xoactpd(mapd);

        }

        public void ThemPhieuDat(PhieuDatSachInfo pd1)
        {

            pd_Data.ThemPhieuDat(pd1);
        }

        public void XoaPhieuDat(PhieuDatSachInfo pd1)
        {
            pd_Data.XoaPhieuDat(pd1);
        }

        public void timPhieuDatSach(TextBox MaPD, ComboBox cbChonMaNV, TextBox MaNV, ComboBox cbChonMaNCC,TextBox tenNCC, ComboBox cbChonNgay ,DateTimePicker dtTuNgay,DateTimePicker dtDenNgay, DataGridView dg)
        {
            DataTable tbl = pd_Data.timPhieuDat(MaPD.Text, cbChonMaNV.Text, MaNV.Text, cbChonMaNCC.Text, tenNCC.Text,cbChonNgay.Text,dtTuNgay.Value.Date,dtDenNgay.Value.Date);
            dg.DataSource = tbl;
        }
        
    }
}
