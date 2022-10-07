using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhanSo.DTO;
using PhanSo.DataAccess;

namespace PhanSo.Business
{
    class PhanSoBLL
    {
        //public PhanSoDTO Docdulieu(string strpath)
        //{
        //    PhanSoDTO Phanso = new PhanSoDTO();
        //    PhanSoDAO PdDAO = new PhanSoDAO();
        //    Phanso = PdDAO.docdulieu(strpath);
        //    return Phanso;
        //}
        public void Ghidulieu(PhanSoDTO Phanso, string strpath)
        {
            PhanSoDAO PsDAO = new PhanSoDAO();
            PsDAO.Ghidulieu(Phanso, strpath);
            
        }
    }
}
