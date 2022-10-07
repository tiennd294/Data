using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class HoaDonInfo
    {
        private IList<ChiTietHoaDonInfo> m_DanhSachHD;

        public IList<ChiTietHoaDonInfo> ChiTietHoaDon
        {
            get { return m_DanhSachHD; }
            set { m_DanhSachHD = value; }
        }

        private NhanVienInfo m_DSNV;

        public NhanVienInfo NhanVienInfo
        {
            get { return m_DSNV; }
            set { m_DSNV = value; }
        }

        private string m_MaHD;

        public string MaHoaDon
        {
            get { return m_MaHD; }
            set { m_MaHD = value; }
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

        private string m_NgayLap;

        public string NgayLap
        {
            get { return m_NgayLap; }
            set { m_NgayLap = value; }
        }


    }
}
