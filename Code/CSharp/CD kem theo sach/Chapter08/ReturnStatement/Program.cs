using System;
using System.Collections.Generic;
using System.Text;

namespace ReturnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value of Array");
            int[] arrInt = { 4, 2, 5, 7, 4, -8, 9, 10 };
            Print(arrInt);
            Sum(arrInt);
            Console.ReadLine();
        }
        static void Print(int[] arrInt)
        {
            Console.WriteLine("omitted return statement");
            for (short i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine("arrInt[{0}]={1}",
                    i, arrInt[i]);
            }
            return;
        }
        static long Sum(int[] arrInt)
        {
            long result = 0;
            for (short i = 0; i < arrInt.Length; i++)
            {
                result+= arrInt[i];
            }
            Console.WriteLine("return statement");
            Console.WriteLine("Sum of arrInt={0}",
                    result);
            return result;
        }
    }
}
