using System;
using x=System.Console ;

namespace ArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            x.WriteLine("Original Array");
            int[] myIntArray = new int[5] { 1, 5, 3, 2, 4 };
            Object[] myObjArray = new Object[5] 
                { 206, 127, 208, 129, 130 };
            x.WriteLine("integer array:");
            PrintValue(myIntArray);
            x.WriteLine("Object array: ");
            PrintValue(myObjArray);

            x.WriteLine("Sorted Array");
            Array.Sort(myIntArray);
            x.WriteLine("integer array after sorting:");
            PrintValue(myIntArray);
            Array.Sort(myObjArray);
            x.WriteLine("Object array after sorting: ");
            PrintValue(myObjArray);

            x.WriteLine("Copy Array");
            Array.Copy(myIntArray, myObjArray, 2);
            x.Write("integer array:");
            PrintValue(myIntArray);
            x.Write("Object array: ");
            PrintValue(myObjArray);
            x.ReadLine();
        }
        public static void PrintValue(Object[] myArr)
        {
            foreach (Object i in myArr)
            {
                x.Write("\t{0}", i);
            }
            x.WriteLine();
        }

        public static void PrintValue(int[] myArr)
        {
            foreach (int i in myArr)
            {
                x.Write("\t{0}", i);
            }
            x.WriteLine();
        }

    }
}
