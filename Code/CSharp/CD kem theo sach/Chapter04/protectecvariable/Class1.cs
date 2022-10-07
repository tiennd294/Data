using System;
namespace protectecvariable
{
    public class Class1
    {
        public int qtty = 0;
        public float price = 0;
        float tax = 0;
        protected float amount = 0;
        public void Sum()
        {
            tax = qtty * price * 0.1F;
            amount = qtty * price-tax;
            Console.WriteLine("Tax={0}",
                tax);
        }
    }
    

}
