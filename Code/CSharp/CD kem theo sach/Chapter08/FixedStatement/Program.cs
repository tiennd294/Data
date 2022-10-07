using System;

namespace FixedStatement
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            Console.WriteLine("fixed statement");             
            Point pt = new Point();
            pt.x = 5;
            pt.y = 6;            
            fixed (int* p = &pt.x)
            {
                SquarePtrParam(p);
            }           
            Console.WriteLine("x={0},y={1}", pt.x, pt.y);
            Console.ReadLine();
        }
        unsafe static void SquarePtrParam(int* p)
        {
            *p *= *p;
        }
    }
}
