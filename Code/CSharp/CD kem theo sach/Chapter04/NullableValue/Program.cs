using System;
namespace NullableValue
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
            int y = num.GetValueOrDefault();                      
            try
            {
                y = num.Value;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
