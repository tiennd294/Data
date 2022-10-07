using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class ChiTietHoaDonInfo
    {
        private HoaDonInfo m_HoaDon;

        public HoaDonInfo HoaDon
        {
            get { return m_HoaDon; }
            set { m_HoaDon = value; }
        }

        private string m_MaHoaDon;

        public string MaHoaDOn
        {
            get { return m_MaHoaDon; }
            set { m_MaHoaDon = value; }
        }

        private string m_MaSach;

        public string MaSach
        {
            get { return m_MaSach; }
            set { m_MaSach = value; }
        }

        private string m_DonGia;

        public string DonGiaBan
        {
            get { return m_DonGia; }
            set { m_DonGia = value; }
        }

        private string m_SoLuong;

        public string SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        }

        private string m_ThanhTien;

        public string ThanhTien
        {
            get { return m_ThanhTien; }
            set { m_ThanhTien = value; }
        }
    }
}
