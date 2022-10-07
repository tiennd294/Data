using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class NhaCungCapInfo
    {
        private PhieuNhanSachInfo m_PhieuNS;

        public PhieuNhanSachInfo PhieuNhanSach
        {
            get { return m_PhieuNS; }
            set { m_PhieuNS = value; }
        }

        private PhieuDatSachInfo m_PhieuDS;

        public PhieuDatSachInfo PhieuDatSach
        {
            get { return m_PhieuDS; }
            set { m_PhieuDS = value; }
        }

        private PhieuChiInfo m_PhieuChi;

        public PhieuChiInfo PhieuChi
        {
            get { return m_PhieuChi; }
            set { m_PhieuChi = value; }
        }

        private string m_MaNCC;

        public string MaNhaCungCap          
        {
            get { return m_MaNCC; }
            set { m_MaNCC = value; }
        }

        private string m_TenNCC;

        public string TenNhaCungCap
        {
            get { return m_TenNCC; }
            set { m_TenNCC = value; }
        }

        private string m_DiaChi;

        public string DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        private string m_DienThoai;

        public string DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }

        private string m_MaSoThue;

        public string MaSoThue
        {
            get { return m_MaSoThue; }
            set { m_MaSoThue = value; }
        }

        private string m_GhiChu;

        public string GhiChu
        {
            get { return m_GhiChu; }
            set { m_GhiChu = value; }
        }
	

	
    }
}
