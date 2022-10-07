using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class KhachHangInfo
    {
        private PhieuThuInfo m_Phieuthu;

        public PhieuThuInfo PhieuThuInfo
        {
            get { return m_Phieuthu; }
            set { m_Phieuthu = value; }
        }

        private PhieuXuatSachInfo m_PhieuXS;

        public PhieuXuatSachInfo PhieuXuatSach
        {
            get { return m_PhieuXS; }
            set { m_PhieuXS = value; }
        }

        private HoaDonInfo m_DSHoadon;

        public HoaDonInfo HoaDonInfo
        {
            get { return m_DSHoadon; }
            set { m_DSHoadon = value; }
        }

        private string m_MaKH;
                
        public string MaKhachHang
        {
            get { return m_MaKH; }
            set { m_MaKH = value; }
        }

        private string m_TenKH;

        public string TenKhachHang
        {
            get { return m_TenKH; }
            set { m_TenKH = value; }
        }

        private string m_Phai;

        public string Phai
        {
            get { return m_Phai; }
            set { m_Phai = value; }
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
