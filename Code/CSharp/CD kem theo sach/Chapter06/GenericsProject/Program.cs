using System;

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
        }
    }
}
