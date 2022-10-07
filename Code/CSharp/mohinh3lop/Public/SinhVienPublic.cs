using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public
{
    public class SinhVienPublic:LophocPublic
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _Pass;

        public string Pass
        {
            get { return _Pass; }
            set { _Pass = value; }
        }
        private string _Avartar;

        public string Avartar
        {
            get { return _Avartar; }
            set { _Avartar = value; }
        }
    }
}
