using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class ChiTietPhieuNhanSachInfo
    {
         public ChiTietPhieuNhanSachInfo()
        {
            m_PhieuNS = new PhieuNhanSachInfo();
            m_sach = new ThongTinSachInfo();
           
        }
        
        private ThongTinSachInfo m_sach;
        public ThongTinSachInfo sach_getset
        {
            get { return m_sach; }
            set { m_sach = value; }

        }
          
        private PhieuNhanSachInfo m_PhieuNS;
        public PhieuNhanSachInfo PhieuNhanSach
        {
            get { return m_PhieuNS; }
            set { m_PhieuNS = value; }
        }

        private string m_MaPhieuNS;

        public string MaPhieuNhanSach
        {
            get { return m_MaPhieuNS; }
            set { m_MaPhieuNS = value; }
        }

        private string m_MaSach;

        public string MaSach
        {
            get { return m_MaSach; }
            set { m_MaSach = value; }
        }

        private long m_dongia;
        public long dongia_getset
        {
            get { return m_dongia; }
            set { m_dongia = value; }

        }

        private int m_soluong;
        public int soluong_getset
        {
            get { return m_soluong; }
            set { m_soluong = value; }

        }

        private long m_thanhtien;
        public long thanhtien_getset
        {
            get { return m_thanhtien; }
            set { m_thanhtien = value; }

        }

        private string m_ctphieuNhan;
        public string ctphieudat_getset
        {
            get { return m_ctphieuNhan; }
            set { m_ctphieuNhan = value; }
        }
	
    }
}
