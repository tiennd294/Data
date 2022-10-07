using System;
using System.Collections.Generic;
using System.Text;

namespace ListProject
{
    class Program
    {
        static List<string> myList;
        static void Main(string[] args)
        {
            Console.WriteLine("Working with List");
            AssignValue();
            PrintValue();
            InsertValue();
            SearchValue();
            IndexValue();
            RemoveValue();
            TriemList();
            ClearList();
            Console.WriteLine();
        }
        #region Working with List

            static void AssignValue()
            {
                myList = new List<string>();
                Console.WriteLine("\nCapacity: {0}", myList.Capacity);

                myList.Add("Tyrannosaurus");
                myList.Add("Amargasaurus");
                myList.Add("Mamenchisaurus");
                myList.Add("Deinonychus");
                myList.Add("Compsognathus");
            }
            static void PrintValue()
            {            
                foreach (string myItem in myList)
                {
                    Console.WriteLine(myItem);
                }

                Console.WriteLine("\nCapacity: {0}", myList.Capacity);
                Console.WriteLine("Count: {0}", myList.Count);

            }
            static void SearchValue()
            {
                Console.Write("Enter name to find?:");
                string name = Console.ReadLine();
                Console.WriteLine("Find: {0}",name);
                if( myList.Contains(name))
                    Console.Write("Found!");
                else
                Console.Write("Not found");

            }
            static void InsertValue()
            {
                Console.Write("Enter name to add:");
                string newname = Console.ReadLine();
                myList.Insert(2, newname);
                Console.WriteLine();
                foreach (string myItem in myList)
                {
                    Console.WriteLine(myItem);
                }
            }
            static void IndexValue()
            {
                Console.WriteLine("the 3th element: {0}", myList[3]);
            }
            static void RemoveValue()
            {
                Console.Write("Enter name to remove:");
                string name = Console.ReadLine();
                myList.Remove(name);

                Console.WriteLine();
                foreach (string myItem in myList)
                {
                    Console.WriteLine(myItem);
                }
            }
            static void TriemList()
            {
                myList.TrimExcess();
                Console.WriteLine("\nTrim List");
                Console.WriteLine("Capacity: {0}", myList.Capacity);
                Console.WriteLine("Count: {0}", myList.Count);
            }
            static void ClearList()
            {
                myList.Clear();
                Console.WriteLine("\nClear List");
                Console.WriteLine("Capacity: {0}", myList.Capacity);
                Console.WriteLine("Count: {0}", myList.Count);

            }
        #endregion
    }
}
