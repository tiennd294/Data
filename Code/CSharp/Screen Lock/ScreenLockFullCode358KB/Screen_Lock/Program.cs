using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Screen_Lock
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
            //Application.Run(new ScreenLock());
            //SingleInstance.SingleApplication.Run(new ScreenLock());
            bool ownmutex;

            // Tạo và lấy quyền sở hữu một Mutex có tên là Icon;
            using (Mutex mutex = new Mutex(true, "Screen", out ownmutex))
            {

                // Nếu ứng dụng sở hữu Mutex, nó có thể tiếp tục thực thi;
                // nếu không, ứng dụng sẽ thoát.
                if (ownmutex)
                {
                    Application.Run(new ScreenLock());
                    //giai phong Mutex;
                    mutex.ReleaseMutex();
                }
                else
                    Application.Exit();
            }
        }
    }
}
