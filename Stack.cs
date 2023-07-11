using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        private int[] stack;
        private int top;

        public Stack(int n)
        {
            this.stack = new int[n];
            top = -1;
        }






        //public static void printStackvalue(IEnumerable myCollection)
        //{
        //    foreach (var i in myCollection)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    Console.WriteLine();
        //}
        public void push(int number)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full");
                return;
            }
            //top++
            stack[++top] = number;

        }

        public int peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            return stack[top];
        }

        private bool IsEmpty()
        {
            return top == -1;
        }
        private bool IsFull()
        {
            return top >= stack.Length - 1;
        }
    }
    

}
