using System;

namespace TryCatchProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Catch Block");
            Class1 cls = new Class1();
            Console.Write("Enter path: ");
            string path = "";
            path=Console.ReadLine();
            cls.FolderWithoutTryCatch(path);
            //cls.FolderWithTryCatch(path);
            //MultiCatch(path);
            Console.ReadLine();
        }
        static void MultiCatch(string path)
        {
            Class2 cls = new Class2();
            cls.TryOneCatch(path);
            //cls.TryMultiCatch(path);           
        }
    }
}
