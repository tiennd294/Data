using System;
using System.IO;
using System.Text;

namespace ThrowProject
{
    class Class1
    {
        public void FolderWithThrow(string strpath)
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void FolderThrowWithoutException(string strpath)
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
            catch  
            {
                throw;
            }
        }
    }
}
