using System;
using System.IO;
using System.Text;

namespace TryCatchProject
{
    class Class1
    {
        public void FolderWithoutTryCatch(string strpath)
        {
            Console.WriteLine("Folder List");
            DirectoryInfo dir = 
                new DirectoryInfo(strpath);
            foreach (DirectoryInfo folder in 
                dir.GetDirectories())
            {
                Console.WriteLine("{0}",folder.Name);
                Console.WriteLine("{0}", 
                folder.CreationTime.ToShortDateString());
            }
            Console.ReadLine();
        }
        public void FolderWithTryCatch(string strpath)
        {
            Console.WriteLine("Folder List");
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
            catch( Exception ex)
            {
                Console.WriteLine("Sorry, Error occured!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
