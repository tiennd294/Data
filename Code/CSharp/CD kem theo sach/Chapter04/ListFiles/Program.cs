using System;
using d=System.IO.Directory ;

namespace ListFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string strPath;
            Console.Write("Enter the path: ");
            strPath=Console.ReadLine();
            if (strPath.Equals(""))
                strPath = @"C:\Program Files\Projects";
            Console.WriteLine("Folders of {0}: ", strPath);
            foreach(string name in d.GetDirectories(strPath))
                Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
