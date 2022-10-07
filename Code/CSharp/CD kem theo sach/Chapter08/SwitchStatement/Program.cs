using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Switch, Case, Default");
            Console.Write("Enter first number:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.Write ("Enter operator+ - * / %:");
            string op =  Console.ReadLine();
            switch (op)
            { 
                case "+":
                    Console.WriteLine("Sum ={0}",i+j);
                    break;
                case "-":
                    Console.WriteLine("Sub ={0}", i - j);
                    break;
                case "*":
                    Console.WriteLine("Multiple ={0}", i * j);
                    break;
                case "/":
                    Console.WriteLine("Devide ={0}", i / j);
                    break;
                case "%":
                    Console.WriteLine("Mod ={0}", i % j);
                    break;
                default:
                    Console.WriteLine("Sum ={0}", i + j);
                    break;
            }
            Console.ReadLine();
        }
        short days(short month,int year)
        {
            short day = 31;
            switch (month)
            {                
                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;
                case 2:
                    if (year % 4 == 0)
                        day = 29;
                    else
                        day = 28;
                    break;
            }
            return day;
        }
    }
}
