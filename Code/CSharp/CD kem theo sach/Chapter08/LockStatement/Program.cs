using System;
using System.Threading;

namespace LockStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lock statement");
            Console.WriteLine("---------------------------------------");
            try
            {
                BankAccount myAcc = new BankAccount(1000);
                
                Thread[] threads = new Thread[5];
                for (int i = 0; i < 5; i++)
                {
                    Thread t = new Thread(
                        new ThreadStart(myAcc.DoTransaction));
                    threads[i] = t;
                }
                for (int i = 0; i < 5; i++)
                {
                    threads[i].Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message );
            }
            Console.ReadLine();
        }
    }
}
