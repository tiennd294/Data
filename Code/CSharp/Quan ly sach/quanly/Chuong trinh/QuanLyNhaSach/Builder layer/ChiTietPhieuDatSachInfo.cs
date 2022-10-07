using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class ChiTietPhieuDatSachInfo
    {
         public ChiTietPhieuDatSachInfo()
        {
            m_PhieuDS = new PhieuDatSachInfo();
            m_sach = new ThongTinSachInfo();
           
        }
        
        private ThongTinSachInfo m_sach;
        public ThongTinSachInfo sach_getset
        {
            get { return m_sach; }
            set { m_sach = value; }

        }
          
        private PhieuDatSachInfo m_PhieuDS;
        public PhieuDatSachInfo PhieuDatSach
        {
            get { return m_PhieuDS; }
            set { m_PhieuDS = value; }
        }

        private string m_MaPhieuDS;

        public string MaPhieuDatSach
        {
            get { return m_MaPhieuDS; }
            set { m_MaPhieuDS = value; }
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

        private string m_ctphieudat;
        public string ctphieudat_getset
        {
            get { return m_ctphieudat; }
            set { m_ctphieudat = value; }
        }
	
	
	
    }
}
