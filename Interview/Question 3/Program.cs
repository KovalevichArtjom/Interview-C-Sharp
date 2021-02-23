using System;
using System.Collections.Generic;

namespace Question_3
{

    class Program
    {
        static void Main(string[] args)
        {
            //There is the following code: 
            List<Action> actions = new List<Action>();
            for (var count = 0; count < 10; count++)
            {
                actions.Add(() => Console.WriteLine(count));
            }

            foreach (var action in actions)
            {
                action();
            }
            /*           
             *  https://jonskeet.uk/csharp/csharp2/delegates.html#captured.variables
                What will be displayed on the console? Answer options:

                1) 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
                2) 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 //true
                3) The code will throw an exception 
                4) 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            */
            Console.ReadKey();
        }
    }
}
