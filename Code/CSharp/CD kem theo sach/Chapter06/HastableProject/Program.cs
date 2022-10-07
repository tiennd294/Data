using System;
using System.Collections ;
 

namespace HastableProject
{
    class Program
    {
        static Hashtable hash ;
        static void Main(string[] args)
        {
            hash = new Hashtable();
            AssignValue();
            PrintValue();
            UseMethodAndProperty();
            UseIEnumerator();
            Console.ReadLine();
        }
        static void AssignValue()
        {
            Console.WriteLine("Add Key/Value pairs");
            hash.Add("server", "(local);");
            hash.Add("database", "northwind;");
            hash.Add("uid", "sa;");
            hash.Add("pwd", "sa;");
        }
        static void PrintValue()
        {
            Console.WriteLine("Print Key/Value pairs");
            foreach (DictionaryEntry de in hash)
            {
                Console.WriteLine("key:{0},  value:{1}", 
                    de.Key, de.Value);
            }
        }
        static void UseMethodAndProperty()
        {
            ICollection valueColl = hash.Values;            
            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }
            ICollection keyColl = hash.Keys;            
            foreach (string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s);
            }

            Console.WriteLine("Remove (\"pwd\")");
            hash.Remove("pwd");

            if (!hash.ContainsKey("pwd"))
            {
                Console.WriteLine("Key \"pwd\" is not found.");
            }
        }
        
    }
}
