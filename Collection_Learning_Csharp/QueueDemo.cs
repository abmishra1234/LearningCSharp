using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Learning_Csharp
{
    internal class QueueDemo
    {
        Queue<string> mQueue;
        public QueueDemo()
        {
            mQueue = new Queue<string>();   
        }

        private void PrintQueue()
        {
            foreach (var item in mQueue)
            {
                Console.WriteLine(item);   
            }

            Console.WriteLine("===================");

        }

        public void Demo()
        {
            // Enqueue
            mQueue.Enqueue("Mike");
            mQueue.Enqueue("Bali");
            mQueue.Enqueue("Clark");
            mQueue.Enqueue("Tommy");
            mQueue.Enqueue("Putin");

            Console.WriteLine(mQueue.Count);
            PrintQueue();

            // Dequeue
            mQueue.Dequeue();

            // Contains?
            Console.WriteLine(mQueue.Contains("Bali"));

            // Discuss the Peek Method
            var item = mQueue.Peek();
            Console.WriteLine(item);

            
            //PrintQueue();
        }
    }
}
