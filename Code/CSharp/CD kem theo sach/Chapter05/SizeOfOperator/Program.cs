using System;
using x = System.Console;

namespace SizeOfOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            x.WriteLine("The size of short is {0}.", 
                sizeof(short));
            x.WriteLine("The size of int is {0}.", 
                sizeof(int));
            x.WriteLine("The size of long is {0}.", 
                sizeof(long));
            x.WriteLine("The size of bool is {0}.", 
                sizeof(bool));
            x.ReadLine();
        }
    }
}
