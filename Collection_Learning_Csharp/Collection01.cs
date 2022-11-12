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
            Console.WriteLine("Count and Capacity : {0}, {1}", l.Count, l.Capacity);

            Print_List();
        }









    }
}
