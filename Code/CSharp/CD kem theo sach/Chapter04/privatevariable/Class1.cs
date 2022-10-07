using System;
namespace privatevariable
{
    class Class1
    {
        private int qtty = 100;
        float price = 20.5F;                
        public void Sum()
        {
            float tax = qtty * price * 0.1F;
            float amount = qtty * price - tax;
            Console.WriteLine("Tax={0}",
                tax);
            Console.WriteLine("Amount={0}",
                amount);
        }
    }
}
