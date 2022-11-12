using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCsharpConsoleApp
{
    internal class DifferentTypeOfParameters
    {
        // Let's try to differentiate the by value and by reference type concept in C#
        public void Demo()
        {
            string[] names = new string[2];
            names[0] = "Abinash";
            names[1] = "Mishra";

            Console.WriteLine("Hello {0} {1}", names);

            var al = new System.Collections.ArrayList(2);

            al.Add("First Item");
            al.Add("Second Item");
            al.Add("Third Item");

            // iterate the element from the collection class like ArrayList
            foreach(var item in al)
            {
                Console.WriteLine(item);
            }

            al.AddRange(new string[] { "Abinash", "Babita", "Smita", "Aastha", "Amaya", "Aahana" });

            al.Sort();

            // iterate the element from the collection class like ArrayList
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
}
