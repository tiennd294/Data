using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Customer
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
            //Application.Run(new Customer());
            bool ownmutex;
            using (Mutex mutex = new Mutex(true, "Customer", out ownmutex))
            {
                if (ownmutex)
                {
                    Application.Run(new Customer());
                    mutex.ReleaseMutex();
                }
                else
                    Application.Exit();
            }
        }
    }
}
