using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class VirtualMethodDemo
    {
        public virtual void Print()
        {
            Console.WriteLine("Print Method in Super class");
        }
    }
    public class Child : VirtualMethodDemo
    {
        public override void Print()
        {
            Console.WriteLine("Print Method in Child class");
        }
    }
}
