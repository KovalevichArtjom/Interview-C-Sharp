using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Which will output the following code to the console: 
            var s1 = string.Format("{0}{1}", "abc", "cba");
            var s2 = "abc" + "cba";
            var s3 = "abccba";

            Console.WriteLine(s1 == s2); // true
            //String interning: https://habr.com/ru/post/224281/
            Console.WriteLine((object)s1 == (object)s2); // false 
            Console.WriteLine(s2 == s3); //true
            Console.WriteLine((object)s2 == (object)s3); //true
        }
    }
}
