using System;
using x = System.Console;

namespace EqualsMethod
{
    class Program
    {
        static void Main(string[] args)
        {            
            string firststring;
            x.Write("Enter the first string:");
            firststring = x.ReadLine();
            string secondstring;
            x.Write("Enter the second string:");
            secondstring =  x.ReadLine();
            if (firststring.Equals(secondstring))
                x.WriteLine("Equals");
            if (!firststring.Equals(secondstring))
                x.WriteLine("Not Equals");
            x.ReadLine();
        }
    }
}
