using System;
using System.Collections.Generic;
using System.Text;

namespace myFormatCommandLine
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Standard();
            Number();
            Enumeration();
            Date();
            Console.ReadLine();
        }
        static void Standard()
        { 
            int i=10,j=15,k=50;
            Console.WriteLine("Standard Format");
            Console.WriteLine("i={0}", i);
            Console.WriteLine("i={0}, j={1}, k={2}", i,j,k);

        }
        enum Color { Yellow = 1, Blue, Green };
        static void Enumeration()
        {
            
            Console.WriteLine("Enumeration Format");
            Console.WriteLine(
                "(G) General:. . . . . . . . . {0:G}\n" +
                "(default):. . . . . . . . {0}"+
                "(default = 'G')\n" +
                "(F) Flags:. . . . . . . . . . {0:F} "+
                "(flags or integer)\n" +
                "(D) Decimal number: . . . . . {0:D}\n" +
                "(X) Hexadecimal:. . . . . . . {0:X}\n", 
                Color.Green);       
        }
        static void Date()
        {
            DateTime thisDate = DateTime.Now;
            Console.WriteLine("DateTime Format");
            Console.WriteLine(
                "(d) Short date: . . . . . . . {0:d}\n" +
                "(D) Long date:. . . . . . . . {0:D}\n" +
                "(t) Short time: . . . . . . . {0:t}\n" +
                "(T) Long time:. . . . . . . . {0:T}\n" +
                "(f) Full date/short time: . . {0:f}\n" +
                "(F) Full date/long time:. . . {0:F}\n" +
                "(g) General date/short time:. {0:g}\n" +
                "(G) General date/long time: . {0:G}\n" +
                " (default):. . . . . . . . {0} "+
                "(default = 'G')\n" +
                "(M) Month:. . . . . . . . . . {0:M}\n" +
                "(R) RFC1123:. . . . . . . . . {0:R}\n" +
                "(s) Sortable: . . . . . . . . {0:s}\n" +
                "(u) Universal sortable: . . . {0:u}"+
                "(invariant)\n" +
                "(U) Universal sortable: . . . {0:U}\n" +
                "(Y) Year: . . . . . . . . . . {0:Y}\n",
                thisDate);
        }
        static void Number()
        {
            Console.WriteLine("Numeric Format");
            Console.WriteLine(
            "(C) Currency: . . . . . . . . {0:C}\n"  +
            "(D) Decimal:. . . . . . . . . {0:D}\n"  +
            "(E) Scientific: . . . . . . . {1:E}\n"  +
            "(F) Fixed point:. . . . . . . {1:F}\n"  +
            "(G) General:. . . . . . . . . {0:G}\n"  +
            "    (default):. . . . . . . . {0} "+
            "(default = 'G')\n" +
            "(N) Number: . . . . . . . . . {0:N}\n"  +
            "(P) Percent:. . . . . . . . . {1:P}\n"  +
            "(R) Round-trip: . . . . . . . {1:R}\n" +
            "(X) Hexadecimal:. . . . . . . {0:X}\n" , 
             453,  453.45F);
        }
    }
}
