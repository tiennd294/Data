using System;
using System.Collections.Generic;
using System.Text;

namespace staticclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cls = new Class1();
            Console.WriteLine("Tax={0}",
                cls.tax );
            Console.WriteLine("Amount={0}",
                Class1.qtty * Class1.price);
            Console.ReadLine();
        }
    }
}
