using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Mon_2
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
            Application.Run(new Bai_04.Bai_01.F_chinh());
        }
    }
}
