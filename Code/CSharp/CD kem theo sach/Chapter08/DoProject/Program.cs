using System;

namespace DoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do statement");
            int x = 0;
            do
            {
                Console.WriteLine("x={0}",x);
                x++;
            }
            while (x < 10);
            Console.ReadLine();
        }
    }
}
