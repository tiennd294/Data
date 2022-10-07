using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            object obj = (object)i;
            Console.WriteLine("obj ={0}", obj);
            obj = 200;
            i = (int)obj;
            Console.WriteLine("i ={0}", i);
            //nullvalue();
            Console.ReadLine();
        }
        static void nullvalue()
        {
            object obj = new object();
            int i = (int)obj;
            Console.WriteLine("i ={0}", i);
        }
    }


}
