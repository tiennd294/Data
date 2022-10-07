using System;
using System.Collections.Generic;
using System.Text;

namespace TryFinallyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Finally Block");
            Class1 cls = new Class1();
            string SQL = "select  CustomerID,";
            SQL += "CompanyName,City,Country";
            SQL += " from Customers";
            cls.PrintCustomers(SQL);
            Console.ReadLine();
        }
    }
}
