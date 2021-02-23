using System;
using System.Collections.Generic;
using System.Linq;

namespace Question_8
{
    class Program
    {

        /*
        //What will output on the console in the result complete the following code?
        //https://metanit.com/sharp/tutorial/4.12.php
        //https://www.youtube.com/watch?v=VjXFSvp0fEM
        //Answer:
        1
        4
        9
        Count 3
        Sum 14
        16
        25
        36
        Count 3
        49
        64
        81
        Sum 194
         */
        static IEnumerable<int> Square(IEnumerable<int> a)
        {
            foreach (var r in a)
            {
                Console.WriteLine(r * r);
                yield return r * r;
            }
        }
        class Wrap
        {
            private static int init = 0;
            public int Value
            {
                get { return ++init; }
            }
        }

        static void Main(string[] args)
        {
            var w = new Wrap();
            var wraps = new Wrap[3];

            for (int i = 0; i < wraps.Length; i++)
            {
                wraps[i] = w;
            }

            var values = wraps.Select(x => x.Value);
            var results = Square(values);
            int sum = 0;
            int count = 0;

            foreach (var r in results)
            {
                count++;
                sum += r;
            }
            Console.WriteLine("Count {0}", count);
            Console.WriteLine("Sum {0}", sum);

            Console.WriteLine("Count {0}", results.Count());
            Console.WriteLine("Sum {0}", results.Sum());
        }
    }
}
