using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public  class NhanVienInfo
    {
        private IList<HoaDonInfo> m_DSHD;

        public IList<HoaDonInfo> HoaDoninfo
        {
            get { return m_DSHD; }
            set { m_DSHD = value; }
        }

        private IList<PhieuXuatSachInfo> m_PhieuXS;

        public IList<PhieuXuatSachInfo> PhieuXuatSach
        {
            get { return m_PhieuXS; }
            set { m_PhieuXS = value; }
        }

        private IList<PhieuNhanSachInfo> m_PhieuNS;

        public IList<PhieuNhanSachInfo> PhieuNhanSach
        {
            get { return m_PhieuNS; }
            set { m_PhieuNS = value; }
        }

        private IList<PhieuDatSachInfo> m_PhieuDS;

        public IList<PhieuDatSachInfo> PhieuDatSach
        {
            get { return m_PhieuDS; }
            set { m_PhieuDS = value; }
        }

        private PhieuThuInfo m_PhieuThu;

        public PhieuThuInfo PhieuThu
        {
            get { return m_PhieuThu; }
            set { m_PhieuThu = value; }
        }

        private PhieuChiInfo m_PhieuChi;

        public PhieuChiInfo PhieuChi
        {
            get { return m_PhieuChi; }
            set { m_PhieuChi = value; }
        }

        private string m_MaNV;

        public string MaNhanVien    
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }

        private string m_TenNV;

        public string TenNhanVien
        {
            get { return m_TenNV; }
            set { m_TenNV = value; }
        }

        private string m_Phai;

        public string Phai
        {
            get { return m_Phai; }
            set { m_Phai = value; }
        }

        private string m_ChucVu;

        public string ChucVu
        {
            get { return m_ChucVu; }
            set { m_ChucVu = value; }
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
            	
    }
}
