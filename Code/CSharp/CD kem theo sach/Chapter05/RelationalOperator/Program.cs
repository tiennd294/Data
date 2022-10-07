using System;
using x = System.Console;

namespace RelationalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            x.WriteLine((2 + 2) != 4);           
            object s = 1;
            object t = 1;
            x.WriteLine(s != t);
            string a = "hello";
            string b = "hello";
            x.WriteLine(a != b);
            x.WriteLine((object)a != (object)b);
            x.ReadLine();
        }
    }
}

