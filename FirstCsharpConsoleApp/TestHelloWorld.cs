using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstCsharpConsoleApp;
using HelloWorld;

//---------------------------------------------

namespace FirstCsharpConsoleApp
{
    internal class TestHelloWorld
    {
        static void Main(string[]args)
        {
            //Console.WriteLine("Welcome to the C# basic language learning!!!");

            //Solution sln = new Solution();
            //sln.Enquiry();

            //VariableDemoClass vdc = new VariableDemoClass(5, 23456.456, 
            //    "Abinash Mishra", "9971003216", 8534369, "Noida 201301");

            //Console.WriteLine(vdc.getExpYear());
            //Console.WriteLine();
            //Console.WriteLine(vdc.getExpYear());

            //vdc.testMethod();

            //ProgramFlowDemo pf = new ProgramFlowDemo();
            //pf.Demo();

            ExceptionHandler exc = new ExceptionHandler();
            exc.DemoException();

        }
    }
}