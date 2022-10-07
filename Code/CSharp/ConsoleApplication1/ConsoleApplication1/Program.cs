using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class SV
    {
         string ten;
         int tuoi;
         public SV(string ten, int tuoi)
         {
             this.ten = ten;
             this.tuoi = tuoi;
         }
    
    
    public void Nhap()
    {
        Console.WriteLine("Nhap Ten: ");
        ten=Console.ReadLine();
        Console.WriteLine("Nhap Tuoi: ");

        string tuoi1=Console.ReadLine();
        tuoi = int.Parse(tuoi1);
    }
    public void xuat()
    {
        Console.WriteLine("Ten : {0} \n Tuoi: {1}",ten,tuoi);
    }

    }

    class SVCD : SV
    {
        int diem; int diem2; int diem1;
        string hak;
       
        public SVCD(string ten, int tuoi, int diem, int diem1, int diem2, string hak)
            : base(ten, tuoi)
    {

        this.diem = diem; this.diem1 = diem1; this.diem2 = diem2;
        this.hak=hak;
    }
    public void Nhap1()
    {
        Nhap();
        Console.WriteLine("Nhap Diem: ");
        string str = Console.ReadLine();
        diem = int.Parse(str);
 
        Console.WriteLine("Nhap Diem1: ");
        string str1 = Console.ReadLine();
        diem1 = int.Parse(str1);
        
        Console.WriteLine("Nhap Diem2: ");
        string str2= Console.ReadLine();
        diem2 = int.Parse(str2);

        Console.WriteLine("Nhap Hanh kiem: ");
        hak = Console.ReadLine();
    }
    double tinh()
    {
        return (diem + diem1 + diem2) / 3;
    }
    public void Xuat()
    {
        base.xuat();
        Console.WriteLine("Hanh kiem: {0} \n Diem Trung Binh: {1}",hak,tinh());
    }
 
    }

    class Program 

     {
       
        static void Main(string[] args)
        {
            SVCD sc = new SVCD("hhhhhhhh",21,7,8,9,"Tot");
            sc.Nhap1();
            sc.Xuat();
            Console.ReadLine();

            
        }
    }
}