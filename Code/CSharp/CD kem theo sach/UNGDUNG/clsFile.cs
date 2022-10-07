using System;
using System.Collections.Generic;
using System.IO;

namespace UNGDUNG
{
    class clsFile
    {
        public List<FileInfo> GetFiles(string path)
        {
            List<FileInfo> myFile = new List<FileInfo>();             
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)
            {
                foreach (FileInfo  file in dir.GetFiles("*.mdb"))
                {
                    myFile.Add(file);                                                          
                }
            }
            return myFile;
        }
    }
}
