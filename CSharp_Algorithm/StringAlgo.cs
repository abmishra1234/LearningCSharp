using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Algorithm
{
    internal class StringAlgo
    {
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



    }
}
