using System;

namespace HelloWorld
{
    public class Solution
    {
        public void Enquiry()
        {
            Console.WriteLine("Hello World!!!");
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " Welcome to your first exercise!!");

            Console.WriteLine("Hello " + name + " I believe you need to share us your address?");

            string address = Console.ReadLine();

            Console.WriteLine(address);
        }
    }
}
