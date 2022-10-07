using System;
using x = System.Console;
namespace ArithmeticOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 3;
            x.WriteLine("{0}+{1}={2}",i,j,i-j);
            x.WriteLine("{0}-{1}={2}", i, j, i + j);
            x.WriteLine("{0}*{1}={2}", i, j, i * j);
            x.WriteLine("{0}/{1}={2}", i, j, i / j);
            x.WriteLine("{0}%{1}={2}", i, j, i % j);
            x.ReadLine();

        }
    }
}
