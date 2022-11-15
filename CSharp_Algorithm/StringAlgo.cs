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




    }
}
