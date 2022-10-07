using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class PhieuThuInfo
    {
        private string m_MaPT;

        public string maPhieuThu
        {
            get { return m_MaPT; }
            set { m_MaPT = value; }
        }

        private string m_MaNV;

        public string MaNV
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

        private string m_LyDoThu;

        public string LyDoThu
        {
            get { return m_LyDoThu; }
            set { m_LyDoThu = value; }
        }

        private string m_TongTien;

        public string TongTien
        {
            get { return m_TongTien; }
            set { m_TongTien = value; }
        }
    }
}
