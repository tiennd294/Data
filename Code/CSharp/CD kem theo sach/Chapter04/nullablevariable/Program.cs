using System;

namespace nullablevariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            if (num.HasValue == true)
            {
                Console.WriteLine("num = " + num.Value);
            }
            else
            {
                Console.WriteLine("num = Null");
            }

        }
    }
}
