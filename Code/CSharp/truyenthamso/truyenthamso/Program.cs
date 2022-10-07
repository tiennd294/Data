using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace truyenthamso
{
    public struct point
    {
        public int x;
        public int y;
    }
    public class MyObject
    {
        public int i;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            Console.WriteLine("Value Of i before PassByValue Method is {0}",i);
            PassByValue(i);
            Console.WriteLine("Value Of i after PassByValue Method is {0}", i);
            Console.WriteLine("");
            Console.WriteLine("Value Of i before PassByRef Method is {0}", i);
            PassByRef(ref i);
            Console.WriteLine("Value Of i before PassByRef Method is {0}", i);
            Console.WriteLine("");
            
            point p; p.x = 10; p.y = 15;
            Console.WriteLine("Value Of p before PassByValue is x={0}. y={1}",p.x,p.y);
            PassByValue(p);
            Console.WriteLine("Value Of p after PassByValue is x={0}. y={1}", p.x, p.y);
            Console.WriteLine("");
            Console.WriteLine("Value Of p before PassByRef is x={0}. y={1}", p.x, p.y);
            PassByRef(ref p);
            Console.WriteLine("Value Of p after PassByRef is x={0}. y={1}", p.x, p.y);
            Console.WriteLine("");

            MyObject o = new MyObject();
            o.i = 10;
            Console.WriteLine("Value of o.i before PassReferenceType is {0}", o.i);
            PassReferenceType(o);
            Console.WriteLine("Value of o.i after PassReferenceType is {0}", o.i);


        }
        public static void PassByValue(point p)
        {
            Console.WriteLine("Entering public static void PassByValue(point p)");
            Console.WriteLine("Value Of point.x={0}, poit.y={1}",p.x,p.y);
            p.x++;
            p.y++;
            Console.WriteLine("New Value Of point.x={0}, poit.y={1}", p.x, p.y);
            Console.WriteLine("Exiting public static void PassByValue(point p)");
        }
        public static void PassByValue(int i)
        {
            Console.WriteLine("Entering public static void PassByValue(int i)");
            Console.WriteLine("Value Of i={0}",i);
            i++;
            Console.WriteLine("New Value Of i={0}", i);
            Console.WriteLine("Exiting public static void PassByValue(int i)");

        }
        public static void PassByRef(ref point p)
        {
            Console.WriteLine("Entering public static void PassByRef(ref point p)");
            Console.WriteLine("Value Of point.x={0}, poit.y={1}", p.x, p.y);
            p.x++;
            p.y++;
            Console.WriteLine("New Value Of point.x={0}, poit.y={1}", p.x, p.y);
            Console.WriteLine("Exiting public static void PassByValue(ref point p)");
        }
        public static void PassByRef(ref int i)
        {
            Console.WriteLine("Entering public static void PassByRef(ref int i)");
            Console.WriteLine("Value Of i={0}", i);
            i++;
            Console.WriteLine("New Value Of i={0}", i);
            Console.WriteLine("Exiting public static void PassByRef(ref int i)");
        }
        public static void PassReferenceType(MyObject o)
        {
            Console.WriteLine("Entering public static void PassReferenceType(MyObject o)");
            Console.WriteLine("Value Of MyObject.i={0}", o.i);
            o.i++;
            Console.WriteLine("New Value Of MyObject.i={0}", o.i);
            Console.WriteLine("Exiting public static void PassReferenceType(MyObject o)");

        }
    }
}
