using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class VarAndDynamic
    {
        /// <summary>
        /// variables declared with var must be initialized immediately
        /// var variables datatype is decided at compile time
        /// var cannot be used in method parameter
        /// variables declared with dynamic can be initialized later
        /// dynamic variables datatype is decided at run time
        /// dynamic can be used in method parameter
        /// </summary>
        public VarAndDynamic()
        {
            var x = 10;
            dynamic y;

            y = 25;
            Console.WriteLine($"x: {x}");
            Console.WriteLine($"y: {y}");

            Print("Hey this is a string");
            Print(10);
            Print(10.45f);
        }

        public void Print(/*var x*/dynamic x)
        {
            Console.WriteLine(x);
        }
    }
}
