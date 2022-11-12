using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Learning_Csharp
{
    internal class LinkedListDemo
    {
        LinkedList<string> ll;

        // Method for Printing the all element of the linkedlist
        private void PrintLinkedList()
        {
            foreach (var item in ll)
            {
                Console.WriteLine(item);    
            }

            Console.WriteLine( "======================");
        }

        public LinkedListDemo()
        {
            ll = new LinkedList<string>();

        }

        public void Demo()
        {
            string[] songs = {"Shout", "Satisfaction", "Help!", "Stairway to Heaven", "Come Sail Away", 
            "All Night Long", "Right here right now"};

            // Items can be added at the front and back of the list 
            ll.AddFirst("Rafi");
            ll.AddFirst("Lata");
            ll.AddFirst("Kishor");
            ll.AddFirst("Asha");
            ll.AddLast("Sonu Nigam"); // So if you can print your linklist, this string is at the last place

            // First and Last properties return the first and
            // last element

            var head = ll.First;
            Console.WriteLine(head);

            var tail = ll.Last;
            Console.WriteLine(tail);

            /* 
                Items can be added and removed relative
                to an existing item 
            */

            if (head != null)
                ll.AddAfter(head, "Elon");   // They are kind of bad song right now

            var itemNode = ll.Find("Kishor");

            if(itemNode != null)
                ll.AddAfter(itemNode, "Mark"); // They are kind of bad song right now

            PrintLinkedList();

            // Lets write some code for removal of perticular node
            ll.Remove("Elon");
            PrintLinkedList();


            ll.RemoveLast();
            PrintLinkedList();


        }
    }
}
