using System;
using System.Collections ;
namespace GenericsProject
{
    class Program
    {
        static void Main(string[] args)
        {            
            GenericList<int> list1 ;
            list1 = new GenericList<int>();
         
            GenericList<string> list2 ;
            list2 = new GenericList<string>();

            GenericList<Class1> list3;
            list3 = new GenericList<Class1>();
            Console.ReadLine();
        }
        static void ArrayListType()
        {
            ArrayList arr = new ArrayList();
         
            arr.Add(100);
            arr.Add(1000);
            arr.Add("Hello Generics Type");
            foreach (object o in arr)
            {
               
                Console.WriteLine("{0}", o);
            }

        }

    }
}
