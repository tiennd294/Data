using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class PhieuDatSachInfo
    {
        public PhieuDatSachInfo()
        {
            m_nhacungcap = new NhaCungCapInfo();
            m_nhanvien = new NhanVienInfo();
        
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
        private IList<ChiTietPhieuDatSachInfo> m_ChiTietPDS;

        public IList<ChiTietPhieuDatSachInfo> ChitietPDS
        {
            get { return m_ChiTietPDS; }
            set { m_ChiTietPDS = value; }
        }
        
        private string m_maPDat;

        public string MaPhieuDatSach
        {
            get { return m_maPDat; }
            set { m_maPDat = value; }
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
        private DateTime m_NgayDat;

        public DateTime NgayDat
        {
            get { return m_NgayDat; }
            set { m_NgayDat = value; }
        }
        private long m_TongTien;

        public long TongTien
        {
            get { return m_TongTien; }
            set { m_TongTien = value; }
        }

    }
}
