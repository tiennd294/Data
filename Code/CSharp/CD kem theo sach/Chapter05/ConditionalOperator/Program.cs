using System;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 0;
            int kq = 0;
            Console.Write("Enter the number j:");
            j = Convert.ToInt32(Console.ReadLine());
            kq=(j>i)?j-i:i-j;
            Console.WriteLine("kq={0}",kq);
            Console.ReadLine();
        }
    }
}
