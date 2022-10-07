using System;
using System.IO;

namespace NewOperartor
{
    class Program
    {
        static void Main(string[] args)
        {            
            DirectoryInfo dir = 
                new DirectoryInfo("C:\\");
            Console.WriteLine("List of Folders");
            foreach (DirectoryInfo d in 
                dir.GetDirectories())
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Name:{0}", d.Name);
                Console.WriteLine("Created Date:{0}", 
                   d.CreationTime.ToShortDateString());
                Console.WriteLine("Files:{0}", 
                   d.GetFiles("*.*").Length);   
            }            
            Console.ReadLine();
        }
    }
}
