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
            //InsertValue();
            //InsertValue();
            //InsertValue();
            //TriemList();
            //RemoveValue();
            //IndexValue();  
            //SearchValue();                      
            //TrimList();
            //ClearList();
            Console.ReadLine();

        }
        #region Working with List

            static void AssignValue()
            {
                myList = new List<string>();
                Console.WriteLine("\nCapacity: {0}", myList.Capacity);
                myList.Add("C# 2005");
                myList.Add("NET Framework 2.0");
                myList.Add("SQL Server 2005");
                myList.Add("Visual Basic 2005");
                myList.Add("C# 2005 Example");
                myList.Add("C# 2003 Example");
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
                Console.ReadLine();
                Console.WriteLine("Searching");
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
                Console.ReadLine();
                Console.WriteLine("Insert data");
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
                Console.ReadLine();
                Console.Write("Enter index number:");
                int x = 0;
                x=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("the {0}th element: {1}",
                    x,myList[x]);
            }
            static void RemoveValue()
            {
                Console.ReadLine();
                Console.WriteLine("Remove");
                Console.Write("Enter name to remove:");
                string name = Console.ReadLine();
                myList.Remove(name);

                Console.WriteLine();
                foreach (string myItem in myList)
                {
                    Console.WriteLine(myItem);
                }
                Console.WriteLine("Capacity: {0}", myList.Capacity);
                Console.WriteLine("Count: {0}", myList.Count);
            }
            static void TrimList()
            {
                Console.ReadLine();
                myList.TrimExcess();
                Console.WriteLine("\nTrim List");
                Console.WriteLine("Capacity: {0}", myList.Capacity);
                Console.WriteLine("Count: {0}", myList.Count);
            }
            static void ClearList()
            {
                Console.ReadLine();
                myList.Clear();
                Console.WriteLine("\nClear List");
                Console.WriteLine("Capacity: {0}", myList.Capacity);
                Console.WriteLine("Count: {0}", myList.Count);

            }
        #endregion
    }
}
