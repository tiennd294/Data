using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatchFinallyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Catch Finally Block");
            Class1 cls = new Class1();
            string SQL = "select  CustomerID,";
            SQL += "CompanyName,City,Countries";
            SQL += " from Customers";
            cls.PrintCustomers(SQL);
            Console.ReadLine();
        }
    }
}
