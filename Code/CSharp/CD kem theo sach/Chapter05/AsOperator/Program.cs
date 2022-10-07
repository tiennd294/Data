using System;

namespace AsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objArray = new object[5];
            objArray[0] = new Class1();            
            objArray[2] = "C# 2005";
            objArray[3] = 100;
            objArray[4] = new Class1(); 
            
            for (int i = 0; i < objArray.Length; ++i)
            {
                string s = objArray[i] as string;
                Console.Write("{0}:", i);
                if (s != null)
                {
                    Console.WriteLine("'" + s + "'");
                }
                else
                {
                    Console.WriteLine("not a string");
                }
            }
            Console.ReadLine();
        }
    }
}
