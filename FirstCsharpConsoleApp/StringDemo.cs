using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCsharpConsoleApp
{
    internal class StringDemo
    {
        public void Demo()
        {
            // here our job is to take string class and do some hands on wiht the string class
            string str1 = "Mishra";
            string str2 = "Mishra";

            // Concat
            string str3 = string.Concat(str1, str2);
            Console.WriteLine(str3);

            // Join
            string str4 = string.Join('_', str1, str2);
            Console.WriteLine(str4);

            // Compare Usage as sample
            int value = string.Compare(str1, str2);
            Console.WriteLine(value.ToString());

            string str5 = string.Copy("Hello Mishra");
            Console.WriteLine(str5);












        }


    }
}
