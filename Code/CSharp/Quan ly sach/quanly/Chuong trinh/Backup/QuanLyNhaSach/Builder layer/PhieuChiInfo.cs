using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class PhieuChiInfo
    {
        private string m_MaPC;

        public string maPhieuChi
        {
            get { return m_MaPC; }
            set { m_MaPC = value; }
        }

        private string m_MaNV;

        public string MaNV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }

        private string m_MaNCC;

        public string MaNCC
        {
            get { return m_MaNCC; }
            set { m_MaNCC = value; }
        }

        private string m_NgayLap;

        public string NgayLap
        {
            get { return m_NgayLap; }
            set { m_NgayLap = value; }
        }

        private string m_LyDoChi;

        public string LyDoChi
        {
            get { return m_LyDoChi; }
            set { m_LyDoChi = value; }
        }

        private string m_TongTien;

        public string TongTien
        {
            get { return m_TongTien; }
            set { m_TongTien = value; }
        }
	
	
    }
}
