using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = (args.Length == 0 ? "" : args[0]);
            Console.WriteLine("Hello C# 2005 \r\n" + str);
            Console.ReadLine();
        }
    }
}
