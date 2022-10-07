using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public
{
    public class SVChiTietPublic:SinhVienPublic
    {
        private string _NamHoc;

        public string NamHoc
        {
            get { return _NamHoc; }
            set { _NamHoc = value; }
        }
    }
}
