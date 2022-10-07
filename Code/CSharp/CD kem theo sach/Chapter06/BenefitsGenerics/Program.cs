using System;
using System.Collections.Generic;
using System.Collections;

namespace BenefitsGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayListType();
            GrenericType();
            GrenericYieldType();
            Console.ReadLine();

        }
        static void ArrayListType()
        {
            ArrayList arr = new ArrayList();
            arr.Add(100);
            arr.Add(1000);
            arr.Add("Hello Generics Type");
            foreach (object o in arr)
                Console.WriteLine("{0}", o);

            
             //foreach (int i in arr)
             //   Console.WriteLine("{0}", i);
            
        }
        static void GrenericType()
        {
            List<int> list1 = new List<int>();
            list1.Add(100);
            list1.Add(1000);
            list1.Add(2000);            
            foreach (int i in list1)
                Console.WriteLine("{0}", i);

        }
         
    }
}
