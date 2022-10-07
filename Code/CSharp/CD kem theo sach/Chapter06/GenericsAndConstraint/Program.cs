using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAndConstraint
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericEmployees<Employees> clsGeneric;            
            clsGeneric = GetInfo();
            PrintInfo(clsGeneric);
            Console.ReadLine();
            SearchInfo(clsGeneric);
            Console.ReadLine();
        }
        static void SearchInfo(
            GenericEmployees<Employees> myGeneric)
        {
            Console.WriteLine("Search in Generic");
            Console.Write("Enter name:");
            string name = Console.ReadLine();
            Employees emp=myGeneric.FindEmployee(name);
            if (emp != null)
            {
                Console.WriteLine("Found!");
                Console.Write("{0} ", emp.Code);
                Console.Write("{0} ", emp.Name);
                Console.Write("{0} ", emp.Address);
                Console.Write("{0} ", emp.Age);
                Console.WriteLine();
            }
            else
                Console.Write("Not Found!");
        }
        static void PrintInfo(
            GenericEmployees<Employees> myGeneric)
        {
            Console.WriteLine("Constraint data type");
            foreach (Employees emp in myGeneric)
            {
                Console.Write("{0} ", emp.Code);
                Console.Write("{0} ", emp.Name);
                Console.Write("{0} ", emp.Address);
                Console.Write("{0} ", emp.Age);
                Console.WriteLine();
            }
        }
        static GenericEmployees<Employees> GetInfo()
        {
            Console.WriteLine("Add info for staff");
            GenericEmployees<Employees> clsGeneric;
            clsGeneric = new GenericEmployees<Employees>();
            Employees cls;
            cls = new Employees();
            cls.Code = "A001";
            cls.Name = "Anh Hai";
            cls.Address = "1 Le Duan";
            cls.Age = 30;
            clsGeneric.AddInfo(cls);
            cls = new Employees("A002", 
                "Chi Ba", "1 Le Loi", 25);
            clsGeneric.AddInfo(cls);
            cls = new Employees("A003", 
                "Chi Tu", "1 Le Lai", 20);
            clsGeneric.AddInfo(cls);
            Console.WriteLine();
            return clsGeneric;
        }
    }
}
