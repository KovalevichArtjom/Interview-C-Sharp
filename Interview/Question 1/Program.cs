using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    // There are the following class A and B class declarations:
    class A
    {
        public virtual void Foo()
        {
            Console.Write("Class A");
        }
    }
    class B : A
    {
        public override void Foo()
        {
            Console.Write("Class B");
        }

        public void Bike()
        {
            Console.Write("Bike");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // What will be output to the console by such calls to the Foo () method: 

            //B obj1 = new A(); //Error 
            //obj1.Foo();

            B obj2 = new B(); 
            obj2.Foo(); // "Class B"

            Console.WriteLine();

            A obj3 = new B(); 
            //obj3.Bike(); Not contain
            obj3.Foo(); // "Class B"

            Console.ReadKey();
        }
    }
}
