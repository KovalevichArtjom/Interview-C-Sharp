using System;

namespace Question_2
{
    //There is the following structure: 
    public struct S : IDisposable
    {
        private bool dispose;
        public void Dispose()
        {
            dispose = true;
        }
        public bool GetDispose()
        {
            return dispose;
        }
    }

    class Program
    {
        //FYI: http://sergeyteplyakov.blogspot.com/2012/12/2.html
        //What will be displayed in the following case: 
        static void Main(string[] args)
        {
            var s = new S();
            using (s)
            {
                Console.WriteLine(s.GetDispose()); // False
            }
            Console.WriteLine(s.GetDispose()); //False

            Console.ReadKey();
        }
    }
}
