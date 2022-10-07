using System;
using System.IO;

namespace CustomExceptionProject
{
    class Class1
    {
        public void CustomException(string strpath)
        {
            Console.WriteLine("Custom Exception");
            try
            {
                DirectoryInfo dir =
                    new DirectoryInfo(strpath);
                foreach (DirectoryInfo folder in
                    dir.GetDirectories())
                {
                    Console.Write("{0} ", folder.Name);
                    Console.WriteLine("{0}",
                    folder.CreationTime.ToShortDateString());
                }
                Console.ReadLine();
            }
            catch
            {
                throw new 
                myException("This is Custom Exception");
            }
            
        }
    }
}
