using System;

namespace protectecvariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 cls = new Class2();
            cls.qtty = 10;
            cls.price = 10.5F;
            Console.WriteLine("Qty={0},Price={1}",
                cls.qtty, cls.price);
            cls.Sum();            
            cls.Print();
            Console.ReadLine();
        }
    }
}
