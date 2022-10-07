using System;

namespace AliasOperator
{
    class Program
    {        
        static void Main(string[] args)
        {
            int Console = System.Sum(10, 20);
            global::System.Console.WriteLine(
               "Console={0}", Console);
            global::System.Console.ReadLine();
        }
    }
}


