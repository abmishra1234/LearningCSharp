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
        public void Increment(int i)
        {
            i += 1;
        }

        public void RefIncrement(ref int i)
        {
            i += 1;
        }
        
        public void Demo()
        {
            int val = 5;
            Increment(val);
            Console.WriteLine(val);

            RefIncrement(ref val);
            Console.WriteLine(val);





        }









    }
}
