using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xml2
{
    class XL_PHANSO
    {
        private LT_PHANSO lt_ps = null;
        private TH_PHANSO th_ps = null;
        public XL_PHANSO(LT_PHANSO lt_ps, TH_PHANSO th_ps)
        {

            this.lt_ps = lt_ps;

            this.th_ps = th_ps; this.th_ps.tuso = this.lt_ps.tuso; this.th_ps.mauso = this.lt_ps.mauso;
        }
        public void Ghi(string strFilename)
        {

            this.lt_ps.tuso = this.th_ps.tuso; this.lt_ps.mauso = this.th_ps.mauso; this.lt_ps.GhiPhanSo(strFilename);
        }
        public static XL_PHANSO operator +(XL_PHANSO ps1, XL_PHANSO ps2)
        {

            XL_PHANSO kq = new XL_PHANSO(new LT_PHANSO() , new TH_PHANSO());

            kq.th_ps.tuso = ps1.th_ps.tuso * ps2.th_ps.mauso + ps2.th_ps.tuso * ps1.th_ps.mauso;

            kq.th_ps.mauso = ps1.th_ps.mauso * ps2.th_ps.mauso;

            return kq;

        }
        public void CapNhat(XL_PHANSO ps)
        {

            this.th_ps.tuso = ps.th_ps.tuso;

            this.th_ps.mauso = ps.th_ps.mauso;

        }
        public void RutGon()
        {

            int tuso = this.th_ps.tuso;

            int mauso = this.th_ps.mauso;

            int maxUC = TimMaxUocChung(tuso, mauso);

            tuso = tuso / maxUC; mauso = mauso / maxUC; this.th_ps.tuso = tuso; this.th_ps.mauso = mauso;
        }
        public int TimMaxUocChung(int a, int b)

        {

            while (a != b)
            {

                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;

        }


    }
}
