using System;
using System.Collections.Generic;
using System.Text;

namespace ContinueStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value of Array");
            int[] arrInt = { 4, 2, 5, -7, 4, -8, 9, -10 };
            for (short i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine("arrInt[{0}]={1}",
                    i, arrInt[i]);
            }
            Console.WriteLine("Use continue statement");
            for (short i = 0; i < arrInt.Length; i++)
            {
                if (arrInt[i] > 0)
                    continue;
                Console.WriteLine("arrInt[{0}]={1}",
                    i, arrInt[i]);
            }
            Console.ReadLine();
        }
    }
}
