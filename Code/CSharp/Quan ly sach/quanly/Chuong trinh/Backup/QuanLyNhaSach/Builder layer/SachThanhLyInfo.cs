using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class SachThanhLyInfo
    {
        private IList<ThongTinSachInfo> m_TTSachTL;

        public IList<ThongTinSachInfo> ThongTinSach
        {
            get { return m_TTSachTL; }
            set { m_TTSachTL = value; }
        }
	

    }
}
