using System;

namespace ForStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for statement");
            int x = 0;
            for(x=0;x<10;x++)
            {
                Console.WriteLine("x={0}", x);                
            }
            //UseFor1();
            //UseFor2();
            //UseFor3();
            Console.ReadLine();
        }
        static void UseFor()
        {
            Console.WriteLine("for statement");            
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("x={0}", x);
            }
           
        }
        static void UseFor1()
        {
            Console.WriteLine("for statement");
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("x={0}", x);
            }
            //Console.WriteLine("x={0}", x);
        }
        static void UseFor2()
        {
            Console.WriteLine("for with increase 2");
            for (int x = 0; x < 10; x+=2)
            {
                Console.WriteLine("x={0}", x);
            }
        }
        static void UseFor3()
        {
            Console.WriteLine("for with decrease");
            for (int x = 10; x > 0; x--)
            {
                Console.WriteLine("x={0}", x);
            }
        }
    }
}
