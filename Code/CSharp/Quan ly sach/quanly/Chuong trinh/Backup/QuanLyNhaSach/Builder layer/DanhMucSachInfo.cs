using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class DanhMucSachInfo
    {
        private IList<ThongTinSachInfo> m_DmSach;

        public IList<ThongTinSachInfo> ThongTinSach
        {
            get { return m_DmSach; }
            set { m_DmSach = value; }
        }

        private string m_MaSach;

        public string MaSach
        {
            get { return m_MaSach; }
            set { m_MaSach = value; }
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

        private string m_NhaXB;

        public string NhaXuatBan
        {
            get { return m_NhaXB; }
            set { m_NhaXB = value; }
        }

        private string m_NamXB;

        public string namXuatBan
        {
            get { return m_NamXB; }
            set { m_NamXB = value; }
        }

        private string m_SoLuong;

        public string SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        }

	
    }
}
