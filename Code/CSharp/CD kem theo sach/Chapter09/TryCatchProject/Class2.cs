using System;
using System.IO;
using System.Text;

namespace TryCatchProject
{
    class Class2
    {
        public void TryMultiCatch(string strpath)
        {
            int i = 50;
            string[] Folders = new string[i];
            try
            {
                Console.WriteLine("Folder List");
                Folders = Directory.GetDirectories(strpath);
                for (int j = 0; j < i; j++) 
                   Console.WriteLine("{0}={1}",j, Folders[j]);
                Console.WriteLine();
            }
            
            catch (IOException ioex)
            {
                Console.WriteLine("IOException Error:");
                Console.WriteLine(ioex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception Error:");
                Console.WriteLine(ex.Message);
            }            
        }
        public void TryOneCatch(string strpath)
        {
            int i = 50;
            string[] Folders = new string[i];
            try
            {
                Console.WriteLine("Folder List");
                Folders = Directory.GetDirectories(strpath);
                for (int j = 0; j < i; j++)
                    Console.WriteLine("{0}={1}", j, Folders[j]);
                Console.WriteLine();
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Exception Error:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
