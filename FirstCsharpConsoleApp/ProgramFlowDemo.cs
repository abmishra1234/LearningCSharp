using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCsharpConsoleApp
{
    internal class ProgramFlowDemo
    {

        public void Demo()
        {
            int theVal = 45;

            // if and else
            if (theVal < 50)
            {
                Console.WriteLine("theVal is less than 50");
            }
            else
                Console.WriteLine("theVal is greater or equal to 50");

            theVal = 51;
            // ternary operator
            Console.WriteLine(theVal < 50 ? "theVal is less than 50" : "theVal is greater than or equal to 50");







        }





    }
}
