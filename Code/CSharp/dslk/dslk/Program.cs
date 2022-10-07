using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dslk
{
   
        public class ll
        {
            public Node head, current;
            public class Node
            {
                public Node next;
                public int item;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                ll danhsach = new ll();
                danhsach.head = null;
                for (int i = 1; i <= 4; i++)
                {
                    danhsach.current = new ll.Node();
                    danhsach.current.item = i * 10;
                    danhsach.current.next = danhsach.head;
                    danhsach.head = danhsach.current;
                    Console.WriteLine(danhsach.current.item);
                }

                danhsach.current = danhsach.head;
                while (danhsach.current != null)
                {
                    Console.WriteLine(danhsach.current.item);
                    danhsach.current = danhsach.current.next;
                }
                Console.ReadLine();
            }
        }
    }
