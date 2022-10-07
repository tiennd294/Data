using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace myRegion
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
        #region Format of Number             
            static void Standard()
            {
                int i = 10, j = 15, k = 50;
                Console.WriteLine("Standard Format");
                Console.WriteLine("i={0}", i);
                Console.WriteLine("i={0}, j={1}, k={2}", i, j, k);

            }
            enum Color { Yellow = 1, Blue, Green };
            static void Enumeration()
            {
                Console.WriteLine("Enumeration Format");
                Console.WriteLine(
                    "(G) General:. . . . . . . . . {0:G}\n" +
                    "(default):. . . . . . . . {0}" +
                    "(default = 'G')\n" +
                    "(F) Flags:. . . . . . . . . . {0:F} " +
                    "(flags or integer)\n" +
                    "(D) Decimal number: . . . . . {0:D}\n" +
                    "(X) Hexadecimal:. . . . . . . {0:X}\n",
                    Color.Green);
            }
        #endregion
    }
}