using System;
namespace publicvariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cls = new Class1();
            cls.qtty = 10;
            cls.price = 10.5F;
            
            Console.WriteLine("Qty={0},Price={1}", 
                cls.qtty, cls.price);
            Console.WriteLine("Amount={0}",
                cls.qtty*cls.price);
            Console.ReadLine();
        }
    }
}
