using System;

namespace BreakStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value of Array");
            int[] arrInt = {4,2,5,7,4,-8,9,10};
            for (short i = 0; i < arrInt.Length; i++)
            {                
                Console.WriteLine("arrInt[{0}]={1}",
                    i, arrInt[i]);
            }
            Console.WriteLine("Use break statement");
            for (short i = 0; i < arrInt.Length; i++)
            {
                if (arrInt[i] < 0)
                    break;
                Console.WriteLine("arrInt[{0}]={1}", 
                    i, arrInt[i]);                
            }
            Console.ReadLine();
        }
    }
}
