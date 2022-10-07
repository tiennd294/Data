using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class ChiTietPhieuXuatSachInfo
    {
          public ChiTietPhieuXuatSachInfo()
        {
            m_PhieuXS = new PhieuXuatSachInfo();
            m_sach = new ThongTinSachInfo();
           
        }
        
        private ThongTinSachInfo m_sach;
        public ThongTinSachInfo sach_getset
        {
            get { return m_sach; }
            set { m_sach = value; }

        }
          
        private PhieuXuatSachInfo m_PhieuXS;
        public PhieuXuatSachInfo PhieuXuatSach
        {
            get { return m_PhieuXS; }
            set { m_PhieuXS = value; }
        }

        private string m_MaPhieuXS;

        public string MaPhieuXuatSach
        {
            get { return m_MaPhieuXS; }
            set { m_MaPhieuXS = value; }
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

        private string m_ctphieuxuat;
        public string ctphieuxuat_getset
        {
            get { return m_ctphieuxuat; }
            set { m_ctphieuxuat = value; }
        }

    }
}
