using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Learning_Csharp
{
    internal class ListDemo
    {
        List<string> l;

        public ListDemo()
        {
            // create the new list
            l = new List<string>(10);    


        }

        protected void Print_List()
        {
            foreach(var item in l)
            {
                Console.WriteLine(item);
            }
        }

        
        public void Solve_List()
        {
            string[] comedians = { "Anupam kher", "Akhay Kumar", "John Lever", "Junior mahmood", "Sharukh Khan" };
            l.AddRange(comedians);

            // Add individual item
            l.Add("Abinash Mishra");
            l.Add("Smita Mishra");
            l.Add("Aahana Mishra");

            // Examine the count and capaity.
            //Console.WriteLine("Count and Capacity : {0}, {1}", l.Count, l.Capacity);

            //Print_List();
            // lets access the individual item in list
            //Console.WriteLine(l[0]);

            // let's remove item from the list
            //l.RemoveAt(0);
            //Print_List();

            l.Sort();
            //Print_List();

            // Serching the List Content
            int ansInd = l.BinarySearch("Smita Mishra");
            //Console.WriteLine(ansInd);
            //Console.WriteLine(l[ansInd]);

            // TODO: Determine if a list contains a given item
            Console.WriteLine(l.Contains("Abinash Mishra"));

            // The Exists function gives us a more Customizable way to search
            // by using a predicate function to examine each element in the list
            bool found = l.Exists(x => x.Length > 12);
            Console.WriteLine("Found : {0}", found);

            // Use the Exist function to search through items
            found = l.Exists(x => x.Contains("Abhinash Mishra"));
            Console.WriteLine("Found : {0}", found); // False for "Abhinash Mishra"

            // Use the Find method for searching through the items
            var item = l.Find(x => x.Contains("Aahana Mishra"));
            Console.WriteLine(item);

            item = l.Find(x => x.StartsWith("A"));
            Console.WriteLine(item);

            Console.WriteLine("====================");

            // Find the all item from the list which Starts With 'A'
            var itemList = l.FindAll(x => x.StartsWith("A"));
            foreach (var str in itemList)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("====================");

            var nameList = l.FindAll(x => x.Length > 12);
            foreach (var str in nameList)
            {
                Console.WriteLine(str);
            }



            //l.RemoveAt(0);
            //Console.WriteLine(l.Contains("Abinash Mishra"));
            //            Print_List();


        }









    }
}
