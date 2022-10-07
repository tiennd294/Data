using System;
using x = System.Console;

namespace AssigmentOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 3;
            i-=j;
            x.WriteLine("i decrement {0}={1}",j, i);
            j+=i;
            x.WriteLine("j increment {0}={1}",i, j);
            i *= j;
            x.WriteLine("i increment {0} times={1}", j, i);
            j /= i;
            x.WriteLine("j devide {0} times={1}", i, j);
            NullableVariable();
            x.ReadLine();
        }
        static void NullableVariable()
        {
            int? xInt = null;            
            int yInt = xInt ?? 10;
            x.WriteLine("y ={0} ", yInt);
        }
    }
}
