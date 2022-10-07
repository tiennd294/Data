using System;
using x = System.Console;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            x.WriteLine("Jagged Array");
            x.WriteLine("------------------");
            int[][] JaggedArr = new int[5][];
            JaggedArr[0] = new int[] { 1, 3, 5, 7, 9 };
            JaggedArr[1] = new int[] { 0, 2, 4, 6 };
            JaggedArr[2] = new int[] { 10, 11 };
            JaggedArr[3] = new int[] { 13, 22,19,20 };
            JaggedArr[4] = new int[] { 15, 16,7 };

            for (int i = 0; i < JaggedArr.GetLength(0); i++)
            {
                foreach (int j in JaggedArr[i])
                {
                    x.Write("{0}  ", j);
                }
                x.WriteLine();
            }                            
            x.ReadLine();
        }
    }
}
