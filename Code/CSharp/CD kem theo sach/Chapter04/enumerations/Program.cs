using System;

namespace enumerations
{
    class Program
    {
        enum Days { 
                Sun = 1, 
                   Mon, Tue, Wed, Thu, Fri, Sat 
            };

        static void Main()
        {
            int x = (int)Days.Sat;
            int y = (int)Days.Sun;
            Console.WriteLine("Sat = {0}", x);
            Console.WriteLine("Sun = {0}", y);
            AccessEnum();
            Console.ReadLine();
        }
       static void AccessEnum()
        {
           Console.WriteLine("TransactionType");
           Console.WriteLine("Vendor={0}", 
               TransactionType.Vendor);            
        }

    }
}
