using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class DanhMucLoaiSachInfo
    {
        private string m_MaLS;

        public string MaLoaiSach
        {
            get { return m_MaLS; }
            set { m_MaLS = value; }
        }

        private string m_TenLS;

        public string TenLoaiSach
        {
            get { return m_TenLS; }
            set { m_TenLS = value; }
        }
        private IList<ThongTinSachInfo> m_DMLS;

        public IList<ThongTinSachInfo> ThongTinSach
        {
            get { return m_DMLS; }
            set { m_DMLS = value; }
        }

        
	


    }
}
