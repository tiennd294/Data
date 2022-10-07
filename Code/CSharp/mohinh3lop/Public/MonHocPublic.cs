using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public
{
    public class MonHocPublic
    {
        private int _MaMon;

        public int MaMon
        {
            get { return _MaMon; }
            set { _MaMon = value; }
        }
        private string _TenMon;

        public string TenMon
        {
            get { return _TenMon; }
            set { _TenMon = value; }
        }
    }
}
