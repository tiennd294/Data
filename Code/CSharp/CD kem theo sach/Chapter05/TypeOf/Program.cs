using System;
using System.Reflection;
using x = System.Console;

namespace TypeOfOperator
{
    class Program
    {
        static void Main(string[] args)
        {    
            Type t = typeof(Class1);
            foreach(FieldInfo f in t.GetFields())
                x.WriteLine("Field is {0}.", 
                f.Name);
            foreach (MethodInfo f in t.GetMethods())
                x.WriteLine("Method is {0}.",
                f.Name);
            x.ReadLine();
        }
    }
}
