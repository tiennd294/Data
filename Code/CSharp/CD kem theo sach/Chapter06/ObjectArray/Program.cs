using System;
using x=System.Console ;
namespace ObjectArray
{
    class Program
    {
        static void Main(string[] args)
        {
            x.WriteLine("Object Array");
            x.WriteLine("------------------");
            object[] arrObj;
            Class1 cls= new Class1();
            arrObj = cls.GetObject();            
            foreach (object o in arrObj)
            {
                x.WriteLine("{0}", o);
            }
            
            x.WriteLine();
            x.ReadLine();
        }
    }
}
