using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lop_va_doi_tuong
{
    
   
   public class KhoHang
    {
        public string ten;
        public float klg;
        public float ton;
        public float gia;
        public KhoHang(string tenkhohang, float khanangchua, float tonkho, float giathuengay)
        {
            ten = tenkhohang;
            klg = khanangchua;
            ton = tonkho;
            gia = giathuengay;
        }
        public void nhap(float soluongnhap)
        {
            float N = klg-ton;
            if (soluongnhap >= N)
            {
                Console.WriteLine(" Kho chua hien khong du kha nang nhap {0} Kg ",soluongnhap);
                ton = klg;
                Console.WriteLine(" Chi co the nhap vao {0} Kg ",N);
                Console.WriteLine(" Kho hang {0} con ton kho {1}Kg ", ten, ton);
            }
            else
            {
                Console.WriteLine(" Da nhap vao kho {0} Kg ", soluongnhap);
                ton += soluongnhap;
                Console.WriteLine( " Kho hang {0} con ton kho {1} ",ten,ton);
            }
        }
        public virtual float tinhtien(int songaythue)
        {
            return songaythue * gia;
        }
    }
    class KhoSP : KhoHang
    {
        float heso;
        public  KhoSP(string tenkhohang, float khanangchua, float tonkho, float giathuengay,float hs):base(tenkhohang,khanangchua,tonkho,giathuengay)
        {
            heso = hs;
        }
        public override  float tinhtien(int songaythue)
        {
            return songaythue * gia * heso;
        }
    }
    class KhoNL : KhoHang
    {
        float heso;
        public KhoNL(string tenkhohang, float khanangchua, float tonkho, float giathuengay, float hs):base(tenkhohang,khanangchua,tonkho,giathuengay)
        {
            heso = hs;
        }
        public override  float tinhtien(int songaythue)
        {
            return songaythue * gia * heso;
        }
    }
    class kiemtra
    {
  static void Main()
        {
            KhoHang [] mangKH = new KhoHang[3];
            mangKH[0] = new KhoHang("Hải Châu", 500, 200, 40);
            mangKH[1] = new KhoNL("Liên Chiểu", 800, 250, 45, float.Parse("0.9"));
            mangKH[2] = new KhoSP("Cẩm Lệ", 600, 150, 42, float.Parse("0.85"));
            for (int i = 0; i < 3; i++)
            {
                float soluongnhap;
                Console.WriteLine("nhap so {0} vao kho",mangKH[i].ten);
                soluongnhap = float.Parse(Console.ReadLine());
                int songaythue;
                Console.WriteLine("can chua {0} {1} trong may ngay",soluongnhap,mangKH[i].ten);
              songaythue = Convert.ToInt32(Console.ReadLine());
                mangKH[i].nhap(soluongnhap);
                Console.WriteLine(" Thue ca cho nay can co {0} $ neu khong thi bom dan vo tinh",mangKH[i].tinhtien(songaythue));
            }
            Console.ReadLine();
        }
    }
}
