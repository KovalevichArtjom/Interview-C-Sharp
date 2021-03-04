using System;
using System.Threading;

namespace Question_13
{
    class Program
    {
        //What will be the result of calling the following code: 
        static void Main(string[] args)
        {
            object sync = new object();
            var thread = new Thread(() =>
            {
                try
                {
                    Work();
                }
                finally
                {
                    lock (sync)
                    {
                        Monitor.PulseAll(sync);
                    }
                }
            });
            thread.Start();
            lock (sync)
            {
                Monitor.Wait(sync);
            }
            Console.WriteLine("test");
        }
        private static void Work()
        {
            Thread.Sleep(1000);
        }

/*         
        Answer options:    
        1. SynchronizationLockException will be thrown
        2. The word "test" will not be printed as a deadlock will occur
        3. In some cases, the word "test" may be printed, and in others, a deadlock may occur.
        4. The word "test" will always be printed

        Correct: 4

        */
    }
}
