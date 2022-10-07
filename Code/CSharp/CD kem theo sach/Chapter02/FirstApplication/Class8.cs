using System;
using System.IO;
using System.Text;

namespace FirstApplication
{
    class Class8
    {
        void ListOfFiles()
        {
            string strPath = "C:\\";            
            if (!strPath.Equals(""))
            { 
                foreach (string file in Directory.GetFiles("*.*"))
                {
                    Console.WriteLine(file);
                }
            }
        }
        void List()
        {
            ListOfFiles();
        }
    }
}
