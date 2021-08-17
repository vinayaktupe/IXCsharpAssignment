using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    public delegate void HelloDel();
    public class MultipleClassDelegateCall
    {
        public MultipleClassDelegateCall()
        {
            HelloDel del = new HelloDel(A.Hello);
            del += new HelloDel(B.Hello);
            del();
        }
    }

    public class A
    {
        public static void Hello()
        {
            Console.WriteLine("Hello from A");
        }
    }
    public class B
    {
        public static void Hello()
        {
            Console.WriteLine("Hello from B");
        }
    }
}
