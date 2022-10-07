using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class NhaXuatBanInfo
    {
        private string m_MaNXB;

        public string MaNhaXB
        {
            get { return m_MaNXB; }
            set { m_MaNXB = value; }
        }

        private string m_TenNXB;

        public string TenNhaXB
        {
            get { return m_TenNXB; }
            set { m_TenNXB = value; }
        }

        private string m_DiaChi;

        public string DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        private string m_GhiChu;

        public string GhiChu
        {
            get { return m_GhiChu; }
            set { m_GhiChu = value; }
        }
	
	
    }
}
