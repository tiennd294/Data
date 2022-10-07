using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApplication
{
    class Class1
    {
        public string x;
        public string y;

        public void ReadValue()
        {
            Console.Write("Enter X string: ");
            x = Console.ReadLine();
            Console.Write("Enter Y string: ");
            y = Console.ReadLine();
        }
        public void PrintValue()
        {            
            Console.WriteLine("x: {0}, y: {1}", x, y);
        }
    }
     
    
}
