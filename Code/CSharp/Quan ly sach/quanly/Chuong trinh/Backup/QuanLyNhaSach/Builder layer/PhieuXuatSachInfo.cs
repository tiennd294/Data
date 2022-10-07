using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class PhieuXuatSachInfo
    {
        public PhieuXuatSachInfo()
        {
            m_khachhang = new KhachHangInfo();
            m_nhanvien = new NhanVienInfo();
        
        }
        private NhanVienInfo m_nhanvien;
        public NhanVienInfo nhanvien_getset
        {
            get { return m_nhanvien; }
            set { m_nhanvien = value; }
        }

        private KhachHangInfo m_khachhang;
        public KhachHangInfo khachhang_getset
        {
            get { return m_khachhang; }
            set { m_khachhang = value; }
        }
        private IList<ChiTietPhieuXuatSachInfo> m_ChiTietPXS;

        public IList<ChiTietPhieuXuatSachInfo> ChitietPXS
        {
            get { return m_ChiTietPXS; }
            set { m_ChiTietPXS = value; }
        }
        private DateTime m_NgayLap;

        public DateTime NgayLap
        {
            get { return m_NgayLap; }
            set { m_NgayLap = value; }
        }
        private string m_maPXuat;

        public string MaPhieuXuatSach
        {
            get { return m_maPXuat; }
            set { m_maPXuat = value; }
        }

        private long m_TongTien;

        public long TongTien
        {
            get { return m_TongTien; }
            set { m_TongTien = value; }
        }	

        private string m_MaNV;

        public string MaNhanVien
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }

        private string m_MaKH;

        public string MaKhachHang
        {
            get { return m_MaKH; }
            set { m_MaKH = value; }
        }
        
    }
}
