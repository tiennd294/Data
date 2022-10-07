using System;
using x=System.Console;

namespace TwoDimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDimensionalArray();
            DefaultRange();
            x.ReadLine();
        }
        static void TwoDimensionalArray()
        {
            x.WriteLine("Two Dimensional Array");
            string[,] arrStr = new string[2,3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    x.Write("Enter value of [{0},{1}]:", i,j);
                    arrStr[i,j] = x.ReadLine();
                }
                x.WriteLine();
            }

            x.WriteLine("Data of Two Dimensional Array");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    x.Write("{0} ",arrStr[i,j]);
                }
                x.WriteLine();
            }
            x.WriteLine();
            
        }
        static void DefaultRange()
        {
            string[,] arrStr = {{"Khang","Sun","Mon","Tue",
                "Wednes","Thurs","Fri","Satur"},
                    {"Ngan","Sun","Mon","Tue",
                "Wednes","Thurs","Fri","Satur"}};
            for (int j = 0; j < arrStr.GetLength(0); j++)
            {
                for (int i = 1; i < arrStr.GetLength(1); i++)
                {
                    arrStr[j,i] += "day";
                }
            }
            x.WriteLine("Weekday Schedule");
            x.WriteLine("-----------------------");
            for (int j = 0; j < arrStr.GetLength(0); j++)
            {
                for (int i = 0; i < 7; i++)
                {
                    x.Write("{0}    ", arrStr[j,i]);
                }               
                x.WriteLine();
            }
        }
    }
}

