using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class TonKhoInfo
    {
        private string m_Sach;

        public string MaSach
        {
            get { return m_Sach; }
            set { m_Sach = value; }
        }
        private string m_Thang;

        public string Thang
        {
            get { return m_Thang; }
            set { m_Thang = value; }
        }
        private string m_Nam;

        public string Nam
        {
            get { return m_Nam; }
            set { m_Nam = value; }
        }
        private string m_DonGia;

        public string DonGia
        {
            get { return m_DonGia; }
            set { m_DonGia = value; }
        }
        private string m_TongNhap;

        public string TongNhap
        {
            get { return m_TongNhap; }
            set { m_TongNhap = value; }
        }
        private string m_TongXuat;

        public string TongXuat
        {
            get { return m_TongXuat; }
            set { m_TongXuat = value; }
        }
        private string m_TonDK;

        public string TonDauKy
        {
            get { return m_TonDK; }
            set { m_TonDK = value; }
        }
        private string m_TonCK;

        public string TonCuoiKy
        {
            get { return m_TonCK; }
            set { m_TonCK = value; }
        }	
    }
}
