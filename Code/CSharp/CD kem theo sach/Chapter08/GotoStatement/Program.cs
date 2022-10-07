using System;
using System.Collections.Generic;
using System.Text;

namespace GotoStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you like?");
            Console.Write("Java,C#,VB,C++,Fox:");
            string s = Console.ReadLine();
            Console.WriteLine("------------------");
            switch (s)
            {
                case "VB":
                    VisualBasic();
                    break;
                case "Java":
                    Java();
                    break;
                case "C#":
                    CSharp();
                    break;
                case "C++":
                    goto case "C#";                   
                case "Fox":
                    goto case "VB";                   
                default:
                    goto case "C#";                   
            }            
            Console.WriteLine("Good luck for you.");
            Console.ReadLine();
        }
        static void Java()
        {
            Console.WriteLine("You should study");
            Console.WriteLine("Intro Java");
            Console.WriteLine("Advanced Java");
            Console.WriteLine("Java Server Pages");
            Console.WriteLine("Java Servlet");
            Console.WriteLine("Java Server Faces");
            Console.WriteLine("Enterprise Java Bean");
        }
        static void VisualBasic()
        {
            Console.WriteLine("You should study");
            Console.WriteLine("Visual Basic 6.0");
            Console.WriteLine("Visual Basic .NET");
            Console.WriteLine("Active Server Pages");
            Console.WriteLine("ASP.NET");
            Console.WriteLine("SQL Server");            
        }
        static void CSharp()
        {
            Console.WriteLine("You should study");
            Console.WriteLine("Intro C#");
            Console.WriteLine("Advanced C#");            
            Console.WriteLine("ASP.NET");
            Console.WriteLine("SQL Server");
        }
    }
}
