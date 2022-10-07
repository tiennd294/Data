using System;
namespace SpecialCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string strPath;
            strPath = "C:\\Program Files\\Projects";
            Console.WriteLine(strPath);
            strPath = @"C:\Program Files\Projects";
            Console.WriteLine(strPath);
            Console.ReadLine();
        }
    }
}
