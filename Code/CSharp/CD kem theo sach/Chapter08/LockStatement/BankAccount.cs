using System;
using System.Collections.Generic;
using System.Text;

namespace LockStatement
{
    class BankAccount
    {               
        int BalanceAmt = 0;
        public BankAccount(int InitialAmount)
        {
            BalanceAmt = InitialAmount;
        }
        private Object WillLock = new Object();
        int DrawMoney(int DrawAmount)
        {
            if (BalanceAmt < 0)
            {
                throw new Exception("Negative Balance Amount");
            }
            lock (WillLock)
            {
                if (BalanceAmt >= DrawAmount)
                {
                    Console.WriteLine("Balance before Withdrawal :  " + BalanceAmt);
                    Console.WriteLine("Amount to Withdraw        :  " + DrawAmount);
                    BalanceAmt = BalanceAmt - DrawAmount;
                    Console.WriteLine("Balance after Withdrawal  :  " + BalanceAmt);
                    Console.WriteLine("---------------------------------------");
                    return DrawAmount;
                }
                else
                {
                    return 0; 
                }
            }
        }
        int DrawMoneys(int DrawAmount)
        {
            if (BalanceAmt < 0)
            {
                throw new Exception("Negative Balance Amount");                
            }
            
            if (BalanceAmt >= DrawAmount)
            {
                Console.WriteLine("Balance before Withdrawal :  " + BalanceAmt);
                Console.WriteLine("Amount to Withdraw        :  " + DrawAmount);
                BalanceAmt = BalanceAmt - DrawAmount;
                Console.WriteLine("Balance after Withdrawal  :  " + BalanceAmt);
                Console.WriteLine("---------------------------------------");
                return DrawAmount;
            }
            else
            {
                return 0; 
            }
           
        }

        Random r = new Random();
        public void DoTransaction()
        {
            for (int i = 0; i < 5; i++)
            {
                DrawMoneys(r.Next(10, 200));
            }
        }

    }

}
