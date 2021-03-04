using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_14
{
    class Program
    {
        //What is the result of the execution of the following code:
        class MyCustomException : DivideByZeroException
        {

        }
        static void Main(string[] args)
        {
            try
            {
                Calc();
            }
            catch (MyCustomException)
            {
                Console.WriteLine("Catch MyCustomException 1");
                throw;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Catch Exception 1");
            }
            Console.ReadLine();
        }

        private static void Calc()
        {
            int result = 0;
            var x = 5;
            int y = 0;
            try
            {
                result = x / y;
            }
            catch (MyCustomException)
            {
                Console.WriteLine("Catch DivideByZeroException 2");
                throw;
            }
            catch (Exception)
            {
                Console.WriteLine("Catch Exception 2");
            }
            finally
            {
                throw new MyCustomException();
            }

            /*
             Answer options:
                1. Catch DivideByZeroException, Catch MyCustomException
                2. Catch Exception, Catch MyCustomException
                3. Catch DivideByZeroException, Catch DivideByZeroException
                4. Catch Exception, Catch DivideByZeroException

             Correct: 2
             FYI:
             Division by zero in the try block throws a DivideByZeroException,
             so the second catch is caught first, and the Catch Exception is thrown.
             Further, in the Finaly block, an exception MyCustomExceprion is thrown and climbed
             up the stack to the place where the Calc method was called, thereby triggering a catch
             with MyCustomException and outputting to the console Catch MyCustomException.
             But also in this block there is an additional throw, which an exception is re-created,
             which will not be handled. 
             */
        }
    }
}
