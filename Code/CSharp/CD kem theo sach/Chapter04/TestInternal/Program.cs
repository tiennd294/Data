using System;
using System.Collections.Generic;
using System.Text;

namespace TestInternal
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cls = new Class1();
            cls.Age = 35;
            Console.WriteLine(cls.Age );
            Console.ReadLine();
        }
    }
}
