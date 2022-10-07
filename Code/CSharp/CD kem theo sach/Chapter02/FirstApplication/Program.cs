using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FirstApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());            
        }
        static void Hello()
        {
            Console.WriteLine("Hello C# 2005");
        }
    }
}