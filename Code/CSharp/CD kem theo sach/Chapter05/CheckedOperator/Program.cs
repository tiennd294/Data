using System;

namespace CheckedOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cls = new Class1();
            //Console.WriteLine(
            //    "Normal output value is: {0}",
            //     cls.Normal());
            //Console.WriteLine(
            //    "Checked output value is: {0}",
            //     cls.CheckedOverFlow());
            Console.WriteLine(
                 "UnChecked output value is: {0}",
                 cls.UnCheckedOverFlow());
            Console.ReadLine();

        }
    }
}
