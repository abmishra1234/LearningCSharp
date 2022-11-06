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

        public int getExpYear()
        {
            return mExpYear;
        }


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
