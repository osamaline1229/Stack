using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Queue
    {
        private int[] queue;
        private int first;

        public Queue(int n)
        {
            this.queue = new int[n];
            first = -1;
        }






        //public static void printStackvalue(IEnumerable myCollection)
        //{
        //    foreach (var i in myCollection)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    Console.WriteLine();
        //}
        public void Enqueue(int number)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full");
                return;
            }
            //top++
            queue[++first] = number;

        }

        public int peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            return queue[first];
        }

        private bool IsEmpty()
        {
            return first == 0;
        }
        private bool IsFull()
        {
            return first >= queue.Length - 1;
        }
    }
    

}
