using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Algorithm
{
    internal class StringAlgo
    {
        // Validating the string methods

        // verification code for all Upper ?
        public Boolean IsUpperCase(string s)
        {
            return s.All(char.IsUpper);
        }
        
        // Verification code for all lower?
        public Boolean IsLowerCase(string s)
        {
            return s.All(char.IsLower);
        }

        // verification code for password
        public Boolean IsPasswordComplex(string s)
        {
            return s.Any(char.IsLower) && s.Any(char.IsUpper)
                && s.Any(char.IsNumber);
        }

        //----------------------------------
        // Normalize String in C#
        public string NormalizeString(string input)
        {
            return input.ToLower().Trim().Replace(",", "");
        }


        // Algorithm driven sample code
        // O(string length)
        public string Reverse(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder sb = new StringBuilder();
            
            for(int i=input.Length-1; i>=0; --i)
            {
                sb.Append(input[i]);
            }

            return sb.ToString();
        }

        public string Reverse2(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public string ReverseEachWord(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder sb = new StringBuilder();

            input = Reverse2(input);

            var words = input.Split(' ');
            foreach(var word in words)
            {
                sb.Append(Reverse2(word));
                sb.Append(' ');
            }

            return sb.ToString();
        }

        /*
            Searching the data into array if the data is not oredred
            Optimized way of usage with Demo Method
        */

        Boolean SearchLinearly(int []array, int elem)
        {
            foreach(int i in array)
            {
                if(i == elem)
                    return true;
            }
            return false;
        }


        public void Demo2(int []inArr, int item)
        {
            //return SearchLinearly(inArr, elem);
            var elem = Array.Find(inArr, element=> element == item);
            Console.WriteLine(elem);

            // if you have multiple item into the Array , in that case how to do?

            var elemArr = Array.FindAll(inArr, element=> element == item);
            Array.ForEach(elemArr, element=> Console.WriteLine(element));

        }
    }
}
