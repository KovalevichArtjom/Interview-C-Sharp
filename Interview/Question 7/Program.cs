using System;

namespace Question_7
{
    //Given the following classes:
    public class A
    {
        public virtual void Print1()
        {
            Console.Write("A");
        }
        public void Print2()
        {
            Console.Write("A");
        }
    }
    public class B : A
    {
        public override void Print1()
        {
            Console.Write("B");
        }
    }
    public class C : B
    {
        new public void Print2()
        {
            Console.Write("C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //What result will the following code lead to:
            //Answer: ABC
            var c = new C();
            A a = c;

            a.Print2();
            a.Print1();
            c.Print2();
        }
    }
}
