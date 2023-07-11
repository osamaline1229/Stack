using System;
using System.Collections;

namespace Stack
{
    internal class stack
    {
        private static void Main(string[] args)
        {
            
            stack<int> mystack = new stack<int>();
            mystack.push(100);
            mystack.push(200);
            mystack.push(300);
            mystack.push(400);
            mystack.push(500);
            mystack.pop();
            Console.WriteLine(mystack.pop());
            mystack.peek();
            Console.WriteLine(mystack.peek());









        }
        
    }


}
