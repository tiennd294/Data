using System;
using x = System.Console;

namespace LogicOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            string num;
            x.Write ("Enter the first number:");
            num=Convert.ToString(x.ReadLine());
            if(!(num==""))
                i=Convert.ToInt32(num);
            x.Write ("Enter the second number:");
            num = Convert.ToString(x.ReadLine());
            if(num==""|| num==null )
                j=1;
            else
                j = Convert.ToInt32(num);
            x.WriteLine();
            if(i>=j)
                x.WriteLine("{0}>={1}",i,j);
            else
                x.WriteLine("{0}<{1}", i, j);
            x.ReadLine();
        }
    }
}
