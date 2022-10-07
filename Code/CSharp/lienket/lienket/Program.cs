using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lienket
{
    class OutOfRange : Exception { };
    class dslkinfo
    {
        public int stt;
        public dslkinfo tiep;
    };
    class dslk
    {
        dslkinfo dau, duoi;
        public dslk()
        {
            dau = new dslkinfo();
            dau.stt = 0;
            duoi = new dslkinfo();
            duoi.stt = 0;
            dau.tiep = duoi;
            duoi.tiep = duoi;
        }
        public dslkinfo dichuyeninfo(int k)
        {
            int i;
            dslkinfo tam = dau;
            for (i = 0; i < k && tam != duoi; i++)
            {
                tam = tam.tiep;
            }
            try
            {
                if (i < k)
                    throw (new OutOfRange());
            }
            catch (Exception e)
            {
                Console.Write("ngoai le:{}", e);
            }
            return tam;
        }
        public void cheninfo(dslkinfo a, int vt)
        {
            a.tiep = dichuyeninfo(vt).tiep;
            dichuyeninfo(vt).tiep = a;
        }
        public int dodai_dslk()
        {
            int i;
            dslkinfo tam = dau;
            for (i = 0; tam != duoi; i++)
            {
                tam = tam.tiep;
            }
            return i - 1;
        }
        public void showds()
        {
            dslkinfo tam = dau;
            tam = dau.tiep;
            for (; tam != duoi; tam = tam.tiep)
            {
                Console.WriteLine(tam.stt);
            }
        }
        class program
        {
            public static void Main()
            {
                dslk ds = new dslk();
                dslkinfo info = new dslkinfo();
                info.stt = 1;
                ds.cheninfo(info, 0);
                for (int i = 2; i < 11; i++)
                {
                    info = new dslkinfo();
                    info.stt = i;
                    ds.cheninfo(info, 0);
                }
                ds.showds();
                Console.ReadLine();
            }
        }
    }
}
