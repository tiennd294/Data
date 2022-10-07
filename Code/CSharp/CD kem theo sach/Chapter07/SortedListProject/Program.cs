using System;
using System.Collections.Generic;
using System.Text;

namespace SortedListProject
{
    class Program
    {
        static SortedList<string,string> mySList;
        static void Main(string[] args)
        {
            Console.WriteLine("Working with SortedList");
            AssignValue();
            PrintValue();
            //InsertValue();
            //RemoveValue();
            //IndexKeyValue();
            //SearchKeyValue();
            //TrimList();
            //ClearList();
            Console.ReadLine();
        }

        #region Working with SortedList

        static void AssignValue()
        {
            mySList = new SortedList<string,string>();
            Console.WriteLine("\nCapacity: {0}", mySList.Capacity);
            Console.WriteLine("Count: {0}", mySList.Count);
            Console.WriteLine();
            mySList.Add("C#8","C# 2005");
            mySList.Add("NF2","NET Framework 2.0");
            mySList.Add("SQL","SQL Server 2005");
            mySList.Add("VB8","Visual Basic 2005");
            mySList.Add("C#E8","C# 2005 Example");
            mySList.Add("C#E7","C# 2003 Example");
        }
        
        static void PrintValue()
        {
            foreach (string myKey in mySList.Keys)
            {
                Console.Write("{0}=", myKey);
                Console.WriteLine("{0}", mySList[myKey]);
            }

            Console.WriteLine("\nCapacity: {0}", mySList.Capacity);
            Console.WriteLine("Count: {0}", mySList.Count);
        }
        static void PrintKeyValue()
        {
            foreach (KeyValuePair<string, string> myKeyValue in mySList)
            {
                Console.Write("{0}=", myKeyValue.Key);
                Console.WriteLine("{0}", myKeyValue.Value);
            }

            Console.WriteLine("\nCapacity: {0}", mySList.Capacity);
            Console.WriteLine("Count: {0}", mySList.Count);
        }
        static void InsertValue()
        {
            Console.ReadLine();
            Console.WriteLine("Insert data");
            Console.Write("Enter key to add:");
            string newkey = Console.ReadLine();
            Console.Write("Enter value to add:");
            string newvalue = Console.ReadLine();
            try
            {
                mySList.Add(newkey, newvalue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            foreach (string myKey in mySList.Keys)
            {
                Console.Write("{0}=", myKey);
                Console.WriteLine("{0}",
                    mySList[myKey]);
            }
        }
        static void RemoveValue()
        {
            Console.ReadLine();
            Console.WriteLine("Remove");
            Console.Write("Enter key to remove:");
            string key = Console.ReadLine();
            mySList.Remove(key);

            Console.WriteLine();
            foreach (string myKey in mySList.Keys)
            {
                Console.Write("{0}=", myKey);
                Console.WriteLine("{0}",
                    mySList[myKey]);
            }
            Console.WriteLine("Capacity: {0}", mySList.Capacity);
            Console.WriteLine("Count: {0}", mySList.Count);
        }
        static void IndexKeyValue()
        {
            Console.ReadLine();
            Console.Write("Enter index of key:");
            int x = 0;
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("the {0}th key: {1}",
                x, mySList.Keys[x]);
            Console.WriteLine();
            Console.Write("Enter index of value:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("the {0}th value: {1}",
                x, mySList.Values[x]);
        }
        
        static void SearchKeyValue()
        {
            Console.ReadLine();
            Console.WriteLine("Searching");
            Console.Write("Enter key to find?:");
            string key = Console.ReadLine();
            Console.WriteLine("Find key: {0}", key);
            if (mySList.ContainsKey(key))
            {
                Console.Write("Key={0} ", key);
                Console.WriteLine("Value={0}", 
                    mySList[key]);
            }
            else
                Console.Write("Key not found");

            Console.WriteLine();
            Console.Write("Enter value to find?:");
            string value = Console.ReadLine();
            Console.WriteLine("Find key: {0}", value);
            if (mySList.ContainsValue(value))
            {
                int pos= mySList.IndexOfValue(value);
                Console.Write("Key={0} ", mySList.Keys[pos]);
                Console.WriteLine("Value={0}",
                    value);
            }
            else
                Console.Write("Value not found");

        }
        static void TrimList()
        {
            Console.ReadLine();
            mySList.TrimExcess();
            Console.WriteLine("\nTrim SortedList");
            Console.WriteLine("Capacity: {0}", mySList.Capacity);
            Console.WriteLine("Count: {0}", mySList.Count);
        }
        
           
        
        static void ClearList()
        {
            Console.ReadLine();
            mySList.Clear();
            Console.WriteLine("\nClear SortedList");
            Console.WriteLine("Capacity: {0}", mySList.Capacity);
            Console.WriteLine("Count: {0}", mySList.Count);

        }
        
        #endregion

    }
}
