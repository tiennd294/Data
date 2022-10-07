using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace queuetest
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myqueue = new Queue();
            for(int i=0;i<6;i++)
                myqueue.Enqueue(i);
            for (int i = 0; i < 6; i++)
                Console.WriteLine("{0}",myqueue.Dequeue());


        }
    }
}
