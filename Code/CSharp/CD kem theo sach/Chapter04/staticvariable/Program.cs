using System;
namespace staticvariable
{
    class Program
    {
        static int qtty = 100;
        static float price = 20.5F;
        static void Main(string[] args)
        {
            float tax = qtty * price * 0.1F;
            float amount = qtty * price - tax;
            Console.WriteLine("Tax={0}",
                tax);
            Console.WriteLine("Amount={0}",
                amount);
            Console.ReadLine();
        }
    }
}
