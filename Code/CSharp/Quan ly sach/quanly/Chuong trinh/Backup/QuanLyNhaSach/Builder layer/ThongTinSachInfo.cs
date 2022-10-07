using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class ThongTinSachInfo
    {
        private DanhMucSachInfo m_DMS;

        public DanhMucSachInfo DanhMucSach
        {
            get { return m_DMS; }
            set { m_DMS = value; }
        }

        private DanhMucLoaiSachInfo m_DMLS;

        public DanhMucLoaiSachInfo DanhMucLoaiSach
        {
            get { return m_DMLS; }
            set { m_DMLS = value; }
        }

        private SachThanhLyInfo m_SachTL;

        public SachThanhLyInfo SachThanhLy
        {
            get { return m_SachTL; }
            set { m_SachTL = value; }
        }
	

        private string m_MaSach;

        public string MaSach
        {
            get { return m_MaSach; }
            set { m_MaSach = value; }
        }

        private string m_LoaiSach;

        public string LoaiSach
        {
            get { return m_LoaiSach; }
            set { m_LoaiSach = value; }
        }

        private string m_TenSach;

        public string TenSach
        {
            get { return m_TenSach; }
            set { m_TenSach = value; }
        }

        private string m_TacGia;

        public string TacGia
        {
            get { return m_TacGia; }
            set { m_TacGia = value; }
        }

        private string m_DonGia;

        public string DonGia
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

        private string m_NamXb;

        public string NamXB
        {
            get { return m_NamXb; }
            set { m_NamXb = value; }
        }

        private string m_NhaXBs;

        public string NhaXB
        {
            get { return m_NhaXBs; }
            set { m_NhaXBs = value; }
        }
	
    }
}
