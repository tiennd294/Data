using System;
using x = System.Console;

namespace ObjectArrays
{
    class Program
    {
        static void Main(string[] args)
        {
           
            object[] arrObj = new object[5];
            arrObj[0] = "123";
            arrObj[1] = 123;
            arrObj[3] = null;
            arrObj[4] = new Class1();
            x.WriteLine("One Dimensional Array");
            
            for (int i = 0; i < 5; i++)
            {
                if (!(arrObj[i] is Class1))
                    x.WriteLine("{0}={1}",i,arrObj[i]);
                else
                    x.WriteLine("{0}={1}", i, 
                        ((Class1)arrObj[i]).sum());
            }            
            x.ReadLine();
        }
    }
}
