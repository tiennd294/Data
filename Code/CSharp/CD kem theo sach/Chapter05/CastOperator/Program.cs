using System;

namespace CastOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cls= new Class1();
            int i = (int)cls.getObject();
            Console.WriteLine("i ={0}",i);           
            Console.ReadLine();
        }
        
    }
}
