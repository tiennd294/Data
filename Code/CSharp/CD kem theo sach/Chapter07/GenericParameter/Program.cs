using System;

namespace GenericParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            myGenericParameter<int> cls;
            cls = new myGenericParameter<int>();
            cls.Print(1000);
            Console.WriteLine(
            "Parameter with any data type");
            PrintValue();
            Console.ReadLine();
        }
        static void PrintValue()
        {
            myGenericParameter<int> clsInt;
            clsInt = new myGenericParameter<int>();
            clsInt.Print(100);
            myGenericParameter<float> clsFloat;
            clsFloat = new myGenericParameter<float>();
            clsFloat.Print(100.20F);
            myGenericParameter<string> clsString;
            clsString = new myGenericParameter<string>();
            clsString.Print("Hello Generic of C#");
            Class1 cls1 = new Class1();
            myGenericParameter<Class1> clsClass1;
            clsClass1 = new myGenericParameter<Class1>();
           
        }
    }
}
