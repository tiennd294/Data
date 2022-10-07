using System;

namespace CustomExceptionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Custom Exception");
            Class1 cls = new Class1();
            Console.Write("Enter path: ");
            string path = "";
            path = Console.ReadLine();
            try
            {
                cls.CustomException (path);
            }
            catch(myException ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex.ErrorMessage );
            }
            Console.ReadLine();
        }
    }
}
