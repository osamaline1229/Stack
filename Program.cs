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
            mystack.push(600);


            Console.WriteLine("The Stack vlaue are :");
            printStackvalue(mystack);
            Console.WriteLine("The Lenght of My stack is:");
            Console.WriteLine(mystack.count);
            Console.WriteLine();
            mystack.Pop();
            mystack.Peek();
            Console.WriteLine("The Stack vlaue are :" + mystack.Peek());
            printStackvalue(mystack);

            Console.WriteLine("The Stack vlaue are :");
            mystack.Push("the top of Stack");
            printStackvalue(mystack);

        }
        public static void printStackvalue(IEnumerable myCollection)
        {
            foreach (var i in myCollection)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }

    }


}
