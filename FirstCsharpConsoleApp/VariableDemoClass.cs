using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FirstCsharpConsoleApp
{
    internal class VariableDemoClass
    {
        int mExpYear;
        double mSalary; // monthly
        string mName;
        string mPhone;
        int mEmpUniqueNum;
        string mAddress;

        public VariableDemoClass(int mExpYear, double mSalary, string mName, 
            string mPhone, int mEmpUniqueNum, string mAddress)
        {
            this.mExpYear = mExpYear;
            this.mSalary = mSalary;
            this.mName = mName;
            this.mPhone = mPhone;
            this.mEmpUniqueNum = mEmpUniqueNum;
            this.mAddress = mAddress;

        }

        public void testMethod()
        {

            object obj = null;
            Console.WriteLine(obj);

            // Demo for implicit conversion
            int i = 25;
            long bignum = i;
            Console.WriteLine(bignum);

            // Demo for Explicit conversion
            float itof = i;
            Console.WriteLine(itof);

            // Learn two operator here which is not incase of C++ / Java
//            string str = null;
            string str = "Hello Abinash!!!";

            Console.WriteLine(str ?? "Unknown String");

            str ??= "New String";

            Console.WriteLine(str);






        }



        public int getExpYear()
        {
            return mExpYear;
        }

        public 


        // How do we get all these attribute outside this class?
        void Summary()
        {
            Console.WriteLine(mName);
            Console.WriteLine(mExpYear);
            Console.WriteLine(mSalary);
            Console.WriteLine(mPhone);
            Console.WriteLine(mEmpUniqueNum);
            Console.WriteLine(mAddress);
        }
    }
}
