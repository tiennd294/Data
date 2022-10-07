using System;
using x = System.Console;

namespace IncrementAnddecrementOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 3;
            i++;
            x.WriteLine("i increment 1={0}", i);
            j--;
            x.WriteLine("j decrement 1={0}", j);
            x.ReadLine();
        }
    }
}
