using System;
using System.Collections.Generic;
using System.Text;

namespace ThrowProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Throw Statement");
            Class1 cls = new Class1();
            Console.Write("Enter path: ");
            string path = "";
            path = Console.ReadLine();            
            try
            {
                //cls.FolderWithThrow(path);
                cls.FolderThrowWithoutException(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
