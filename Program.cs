﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class stack
    {
        private static void Main(string[] args)
        {
            
            Queue<int> myqueue = new Queue<int>();
            myqueue.Enqueue(1);
            myqueue.Enqueue(2);
            myqueue.Enqueue(3);
            myqueue.Enqueue(4);
            myqueue.Enqueue(5);

            

            myqueue.Dequeue();
            myqueue.Dequeue();

            foreach (int i in myqueue)
            {
                Console.WriteLine(i);
            }

            myqueue.Peek();
            Console.WriteLine("the peek value is "+myqueue.Peek());

            myqueue.Enqueue(9);
            myqueue.Enqueue(7);
            myqueue.Dequeue();

            foreach (int i in myqueue)
            {
                Console.WriteLine(i);
            }

            

            Console.WriteLine("the peek value is" +myqueue.Peek());

            
            Console.WriteLine();

            
            
            









        }
        
    }


}
