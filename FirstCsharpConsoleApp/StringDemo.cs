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
            string str1 = "This is my first string based assign to this fellow is my Mishra";
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

            // demo for the Contains, return bool
            bool result = str1.Contains("babita"); // return false
            Console.WriteLine(result);

            result = str1.Contains("first"); // return false
            Console.WriteLine(result);

            // demo for EndsWith
            result = str1.EndsWith(str2);
            Console.WriteLine(result);

            // demo for the IndexOf
            string indStr = "This is my testing string and this is also hope that";
            int ansInd = indStr.IndexOf("string");
            Console.WriteLine(ansInd); // 19



            // demo for the LastIndexOf















        }


    }
}
