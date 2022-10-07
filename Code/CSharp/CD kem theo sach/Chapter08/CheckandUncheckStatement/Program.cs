using System;
using System.Collections.Generic;
using System.Text;

namespace CheckandUncheckStatement
{
    class Program
    {
        static short x = 32760;
        static short y = 32760;
        static void Main(string[] args)
        {
            //Console.WriteLine(
            //    "Normal output value is: {0}",
            //     Normal());
            Console.WriteLine(
                "Checked output value is: {0}",
                 CheckedOverFlow());
            //Console.WriteLine(
            //     "UnChecked output value is: {0}",
            //     UnCheckedOverFlow());
            Console.ReadLine();
        }
        static int CheckedOverFlow()
        {
            int z = 0;
            try
            {
                z = checked((short)(x * y));
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.ToString());
            }
            return z;
        }
        static int UnCheckedOverFlow()
        {
            int z = 0;
            try
            {
                z = unchecked((short)(x * y));
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.ToString());
            }
            return z;
        }
        static int Normal()
        {
            int z = 0;
            try
            {
                z = x * y;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.ToString());
            }
            return z;
        }
    }
}
