using System;
using x=System.Console;

namespace MultiDimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiDimensionalArray();          
            x.ReadLine();
        }
        static void MultiDimensionalArray()
        {
            x.WriteLine("Multi Dimensional Array");
            string[,,] arrStr = new string[2,3,4];
            for (int ij = 0; ij < 2; ij++)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        x.Write("[{0},{1},{2}]= ",
                            ij, i, j);
                        arrStr[ij,i, j] = x.ReadLine();
                    }
                    x.WriteLine();
                }
                x.WriteLine();
            }
            x.WriteLine("Multi Dimensional Array");
            for (int ij = 0; ij < 2; ij++)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        x.Write("{0} ", 
                            arrStr[ij, i, j]);
                    }
                    x.WriteLine();
                }
                x.WriteLine();
            }
            x.WriteLine();
            
        }        
    }
}


