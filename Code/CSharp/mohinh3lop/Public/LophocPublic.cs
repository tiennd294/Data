using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public
{
    public class LophocPublic:MonHocPublic
    {
        private int _MaLop;

        public int MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
        private string _TenLop;

        public string TenLop
        {
            get { return _TenLop; }
            set { _TenLop = value; }
        }
    }
}
