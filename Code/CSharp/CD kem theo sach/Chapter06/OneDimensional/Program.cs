using System;
using x=System.Console;

namespace OneDimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            OneDimensionalArray();
            DefaultRange();
            x.ReadLine();
        }
        static void OneDimensionalArray()
        {
            x.WriteLine("One Dimensional Array");
            string[] arrStr = new string[10];
            for (int i = 0; i < 10; i++)
            {
                x.Write("Enter the {0} string:", i);
                arrStr[i] = x.ReadLine();
            }
            x.WriteLine("Data of One Dimensional Array");
            for (int i = 0; i < 10; i++)
            {
                x.Write(arrStr[i]);
            }
            x.WriteLine();
            
        }
        static void DefaultRange()
        {           
            string[] arrStr = {"Sun","Mon","Tue",
                "Wednes","Thurs","Fri","Satur"};
            for (int i = 0; i < 7; i++)
            {                
                arrStr[i] += "day";
            }
            x.WriteLine("Weekday");
            for (int i = 0; i < 7; i++)
            {
                x.Write("{0} ",arrStr[i]);
            }            
        }
    }
}
