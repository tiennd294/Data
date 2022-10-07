using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Public;
using System.Data.SqlClient;

namespace DAL
{
    public class SinhVienDAL
    {
        KetNoi kn = new KetNoi();
        public DataTable DanhSachSV()
        {
            return kn.LOADDATA("SELECT * FROM Users");
        }
        public DataTable Danhsachmasv()
        {
            return kn.LOADDATA("SELECT tensv from Users");
        }
        public int ThemSV(SinhVienPublic p)
        {
            int Nparameter = 4;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaSV"; value[0] = p.Name;
            name[1] = "@TenSV"; value[1] = p.Pass;
            name[2] = "@NamSinh"; value[2] = p.Avartar;
            name[3] = "@MaLop"; value[3] = p.MaLop;
            return kn.Update("Insert into Users(masv, tensv,namsinh,malop) values (@masv,@tensv,@namsinh,@malop)", name, value, Nparameter);
        }
        public int SuaSV(SinhVienPublic p)
        {
            int Nparameter = 4;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaSV"; value[0] = p.Name;
            name[1] = "@TenSV"; value[1] = p.Pass;
            name[2] = "@NamSinh"; value[2] = p.Avartar;
            name[3] = "@MaLop"; value[3] = p.MaLop;
            return kn.Update("Update Users set tensv= @tensv,namsinh=@namsinh, malop=@malop Where masv=@masv", name, value, Nparameter);
        }
        public int XoaSV(SinhVienPublic p)
        {
            int Nparameter = 1;
            string[] name = new string[Nparameter];
            object[] value = new object[Nparameter];
            name[0] = "@MaSV"; value[0] = p.Name;

            return kn.Update("Delete from Users Where masv=@masv", name, value, Nparameter);
        }

    }
}
