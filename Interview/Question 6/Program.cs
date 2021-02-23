using System;

namespace Question_6
{
    class Program
    {
        //What results will the following code output: 
        //Answer: Will print a world
        private static Object syncObject = new Object();
        private static void Write()
        {
            lock (syncObject)
            {
                Console.WriteLine("test");
            }
        }

        static void Main(string[] args)
        {
            lock (syncObject)
            {
                Write();
            }
        }
    }
}
