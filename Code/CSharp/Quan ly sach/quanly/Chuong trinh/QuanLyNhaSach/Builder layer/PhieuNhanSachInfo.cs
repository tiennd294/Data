using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class PhieuNhanSachInfo
    {
        public PhieuNhanSachInfo()
        {
            m_nhacungcap = new NhaCungCapInfo();
            m_nhanvien = new NhanVienInfo();
            m_phieudatsach = new PhieuDatSachInfo();

        }
        private NhanVienInfo m_nhanvien;
        public NhanVienInfo nhanvien_getset
        {
            get { return m_nhanvien; }
            set { m_nhanvien = value; }
        }

        private NhaCungCapInfo m_nhacungcap;
        public NhaCungCapInfo nhacungcap_getset
        {
            get { return m_nhacungcap; }
            set { m_nhacungcap = value; }
        }
        private PhieuDatSachInfo m_phieudatsach;

        public PhieuDatSachInfo phieudatsach_getset
        {
            get { return m_phieudatsach; }
            set { m_phieudatsach = value; }
        }
	
        private IList<ChiTietPhieuNhanSachInfo> m_ChiTietPNS;

        public IList<ChiTietPhieuNhanSachInfo> ChitietPNS
        {
            get { return m_ChiTietPNS; }
            set { m_ChiTietPNS = value; }
        }

        

        private string m_maPNhan;

        public string MaPhieuNhanSach
        {
            get { return m_maPNhan; }
            set { m_maPNhan = value; }
        }

        private string m_MaNV;

        public string MaNhanVien
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }

        private string m_MaNCC;

        public string MaNhaCC
        {
            get { return m_MaNCC; }
            set { m_MaNCC = value; }
        }
        private DateTime m_NgayNhan;

        public DateTime NgayNhan
        {
            get { return m_NgayNhan; }
            set { m_NgayNhan = value; }
        }
        private long m_TongTien;

        public long TongTien
        {
            get { return m_TongTien; }
            set { m_TongTien = value; }
        }
        private string  m_MaPD;

        public string  MaPhieuDatSach
        {
            get { return m_MaPD; }
            set { m_MaPD = value; }
        }
	
    }
}
