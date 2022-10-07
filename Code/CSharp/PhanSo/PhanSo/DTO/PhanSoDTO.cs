using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhanSo.DTO
{
    class PhanSoDTO
    {
        #region "variable"
        private int _Tuso;
        private int _Mauso;

        #endregion

        #region "properties"
        public int Tuso
        {
            get { return _Tuso; }
            set { _Tuso = value; }
        }
        

        public int Mauso
        {
            get { return _Mauso; }
            set { _Mauso = value; }
        }
        #endregion

        #region "Method"
        public PhanSoDTO()
        {
            _Tuso = 0;
            _Mauso = 1;
        }
        public PhanSoDTO(int tuso, int mauso)
        {
            _Tuso = tuso;
            _Mauso = mauso;
        }
        public int UCLN(int tuso, int mauso)
        {
            while (tuso != mauso)
            {
                if (tuso > mauso)
                    tuso = tuso - mauso;
                else
                    mauso = mauso - tuso;
            }
            return tuso;
        }

        public void Rutgon()
        {
            int maxUCLN = this.UCLN(_Tuso, _Mauso);
            _Tuso = _Tuso / maxUCLN;
            _Mauso = _Mauso / maxUCLN;
        }
        #endregion

    }
}
