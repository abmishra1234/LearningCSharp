using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Learning_Csharp
{
    internal class Collection01
    {
        List<string> l;

        public Collection01()
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

            // Examine the count and capaity.
            //Console.WriteLine("Count and Capacity : {0}, {1}", l.Count, l.Capacity);

            //Print_List();
            // lets access the individual item in list
            //Console.WriteLine(l[0]);

            // let's remove item from the list
            //l.RemoveAt(0);
            //Print_List();

            l.Sort();
            Print_List();

            // Serching the List Content
            int ansInd = l.BinarySearch("Smita Mishra");
            Console.WriteLine(ansInd);
            Console.WriteLine(l[ansInd]);

            // TODO: Determine if a list contains a given item
            Console.WriteLine(l.Contains("Abinash Mishra"));

            l.RemoveAt(0);
            Console.WriteLine(l.Contains("Abinash Mishra"));
            Print_List();


        }









    }
}
