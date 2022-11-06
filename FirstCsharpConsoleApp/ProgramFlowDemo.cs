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

            // Let's Demo the Switch option here
            Console.WriteLine("Demo for Swich option below!!!");

            int sVal = 59;
            switch(sVal)
            {
                case 58:
                    Console.WriteLine("The value is 58!!!!");
                    break;
                case 59:
                    Console.WriteLine("The value is 59!!!!");
                    break;
                case 60:
                case 61:
                case 62:
                    Console.WriteLine("The value is btw 60 and 62!!!!");
                    break;
                default:
                    Console.WriteLine("The value is something else!!!");
                    break;
            }
            string name = "babita";
            switch (name)
            {
                case "smita":
                    Console.WriteLine("The name is smita!!!!");
                    break;
                case "abinash":
                    Console.WriteLine("The name is abinash!!!!");
                    break;
                case "ch01":
                case "ch02":
                case "ch03":
                    Console.WriteLine("the name is ch01 or ch02 or ch03!!!!");
                    break;
                default:
                    Console.WriteLine("The name is unknown!!!");
                    break;
            }

            // for and foreach loop ietration demo sample code.
            int counter = 15;
            for(var i = 0; i<counter; ++i)
            {
                Console.WriteLine("the value of i is {0}", i);
            }

            Console.WriteLine("-------------------------");

            int[] nums = { 3, 5, 6, 78, 34, 23, 45};

            foreach(var i in nums) {
                Console.WriteLine("the value of i is {0}", i);
            }

            // simillarly you can write sample code for while 
            string str = "";

            while(str != "exit")
            {
                str = Console.ReadLine();
                Console.WriteLine(str);
            }

        }
    }
}
