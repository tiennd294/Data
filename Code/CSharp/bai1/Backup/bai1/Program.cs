using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai1
{
    class Fraction
    {
        public int a;
        public int b;
        public void print()
        {
            Console.WriteLine("{0}/{1}",a,b);
        }
    }
    class ReferenceTest
    {
        static void Main(string[] args)
        {
            Fraction a=new Fraction();
            a.a = 45;
            a.b = 54;
            a.print(); 

        }
    }
}
