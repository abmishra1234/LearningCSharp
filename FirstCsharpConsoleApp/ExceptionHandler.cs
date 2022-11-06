using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCsharpConsoleApp
{
    internal class ExceptionHandler
    {
        public void DemoException()
        {
            int x = 1005, y = 10;
            try
            {
                if(x > 1000)
                {
                    throw new ArgumentOutOfRangeException("The value must be less than 1000");
                }

                int res = x / y;
                Console.WriteLine(res);


            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Alert!!!!");
                Console.WriteLine(e.Message);

            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Whoops!!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Your Finally block executed now!!!");
            }

        }
    }
}
