using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_String_and_Exception
{
    class StringBuilderDemo
    {
        public StringBuilderDemo()
        {
            StringBuilder name = new StringBuilder("Sam Smith");

            Console.WriteLine($"String Append : {name.Append(" is my name.")}");
            Console.WriteLine($"String AppendFormat  : {name.AppendFormat("My Height is {0:C} cm",176)}");
            Console.WriteLine($"String Insert: {name.Insert(0,"Hi! ")}");
            Console.WriteLine($"String Remove: {name.Remove(name.Length-7,6)}");
            Console.WriteLine($"String Replace: {name.Replace('S','J')}");

        }
    }
}
