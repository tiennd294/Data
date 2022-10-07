using System;
using x = System.Console;

namespace ToStringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            string num;
            x.Write("Enter the first number:");
            num = x.ReadLine();
            if (!(num == ""))
                i = Convert.ToInt32(num);
            x.Write("Enter the second number:");
            num = x.ReadLine();
            if (!(num == ""))
                j = Convert.ToInt32(num);
            x.WriteLine();
            x.WriteLine("i-j="+ (i - j).ToString());
            x.WriteLine("i+j=" + Convert.ToString((i + j)));            
            x.ReadLine();
        }
    }
}
