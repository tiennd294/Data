using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using DAL;
using System.Data;

namespace BUL
{
    public class SinhVienBUL
    {
        SinhVienDAL svdal=new SinhVienDAL();
        public DataTable DanhSachSV()
        {
            return svdal.DanhSachSV();
        }
        public DataTable Danhsachmasv()
        {
            return svdal.Danhsachmasv();
        }
        public int ThemSV(SinhVienPublic p)
        {
            return svdal.ThemSV(p);
        }
        public int SuaSV(SinhVienPublic p)
        {
            return svdal.SuaSV(p);
        }
        public int XoaSV(SinhVienPublic p)
        {
            return svdal.XoaSV(p);
        }
    }
}
