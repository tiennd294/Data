using System;
using System.Collections;

namespace ArrayListProject
{
    class Program
    {
       
        static void Main(string[] args)
        {
            arList = new ArrayList();
            AssignValue();
            PrintValue();
            PrintObject();
            Console.ReadLine();
        }
        static ArrayList arList; 
        static void AssignValue()
        {            
            for (int i = 0; i < 5; i++)
            {
                Class1 cls = new Class1();
                cls.name = "HCM"+i.ToString();
                cls.value = "Ho Chi Minh" + i.ToString();
                arList.Add(cls);
            }
        }
        static void PrintValue()
        {
            Console.WriteLine("Print Value");
            foreach (Class1 cls in arList)
            {
                Console.WriteLine("name:{0},  value:{1}",
                    cls.name , cls.value);
            }
        }
        static void PrintObject()
        {
            Console.WriteLine("Print Object");
            Class2 cls = new Class2();
            arList = new ArrayList();
            arList = cls.GetObject();
            if (arList.Count > 0)
            {
                foreach (object obj in arList)
                {
                    object[] objs = (object[])obj;
                    foreach (object field in objs)
                    {
                        Console.WriteLine("value:{0}", field);
                    }
                }
            }
        }
    }
}
