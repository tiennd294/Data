using System;
using System.Collections.Generic;
using System.Text;

namespace DebuggerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Catch Finally Block");
            Console.Write("Enter Country: ");
            string strWhere = Console.ReadLine();
            Class1 cls = new Class1();
            string SQL = "select  CustomerID,";
            SQL += "CompanyName,City";
            SQL += " from Customers ";
            SQL += " where Country='";
            SQL += strWhere + "'";
            cls.PrintCustomers(SQL);
            Console.ReadLine();
        }
    }
}
