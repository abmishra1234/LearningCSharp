using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Learning_Csharp
{
    internal class StackDemo
    {
        Stack<string> mStack;

        public StackDemo()
        {
            mStack = new Stack<string>();

        }

        void PrintStack()
        {
            foreach (var item in mStack)
            {
                Console.WriteLine(item);    
            }
            Console.WriteLine("=====================");
        }
        public void Demo()
        {
            //string str = new string("");
            //mStack.TryPeek(out str);
            //Console.WriteLine(str);

            // The Push method for pushing the element
            mStack.Push("Abi");
            mStack.Push("Elon");
            mStack.Push("Mark");
            mStack.Push("Gaurav");
            mStack.Push("Kemlin");
            mStack.Push("Putin");
            mStack.Push("Michel");

            string str = new string("");
            mStack.TryPeek(out str);
            Console.WriteLine(str);

            // Just use the Count Properties
            Console.WriteLine(mStack.Count);

            // Check that this element exist in your stack or not?
            Console.WriteLine(mStack.Contains("Abin"));

            // Let's see the sample code for peek method
            var item = mStack.Peek();
            Console.WriteLine("Top Element here is : {0}", item);

            // Display your current Stack Elements
            // You will obsserve that while traversing the element one by one
            PrintStack();

            // Pop is also giving top element but here
            // the element is popped from stack also...
            item = mStack.Pop();
            //Console.WriteLine(item);
            PrintStack();

            // How do you fid that element already exist?
            Console.WriteLine("Item exist? {0}", mStack.Contains("Gaurav"));

            Console.WriteLine("Item exist? {0}", mStack.Contains("Prem"));



        }
    }
}
