using System;
using System.Collections.Generic;
using System.Text;

namespace localvariable
{
    class Program
    {
        public void Sum()
        {
            float tax = qtty * price * 0.1F;
            float amount = qtty * price - tax;
            Console.WriteLine("Tax={0}",
                tax);
            Console.WriteLine("Amount={0}",
                amount);
        }
        static void Main(string[] args)
        {
            Program cls = new Program();
            cls.Sum();
            Console.ReadLine();
        }
        private int qtty = 100;
        float price = 20.5F;
        
    }
}
