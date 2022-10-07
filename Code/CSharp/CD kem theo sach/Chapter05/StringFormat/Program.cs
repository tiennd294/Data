using System;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            Console.WriteLine("Date={0}", dt.ToString());
            string strDate = dt.ToString("dd/MMM/yyyy");
            Console.WriteLine("dd/MMM/yyyy={0}", strDate);
            strDate = dt.ToString("dd/MM/yyyy");
            Console.WriteLine("dd/MM/yyyy={0}", strDate);
            float num = 1025.35F;
            string str = FormatNumber(num);
            Console.WriteLine("###,###.#={0}", str);
            Console.WriteLine("###,###.#={0:###,###.#}", num);
            Console.ReadLine();
        }
        static string FormatNumber(float Num)
        {
            string str = "0";

			if (Num != 0)
				str = string.Format("{0:###,###.#}",Num);
            return str;
        }
    }
}
