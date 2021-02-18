using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //What will be displayed on the console as a result of the following operations: 
            int i = 1;
            object obj = i;
            ++i;
            Console.WriteLine(i); // 2
            Console.WriteLine(obj); // 1
            //Console.WriteLine((short)obj); //Erorr

            Console.ReadKey();
        }
    }
}
