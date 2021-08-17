using System;
using System.Collections.Generic;
using System.Text;

/*
 Write a C# Sharp program to check whether a given number is even or odd.  
Test Data: 15 
Expected Output: 
15 is an odd integer 
 */

namespace Assignment4
{
    class Program2
    {
        public Program2()
        {
            int Number;

            Console.WriteLine("Enter a number: ");
            Number = int.TryParse(Console.ReadLine(), out Number) ? Number : 0;

            string result = Number % 2 == 0 ? "even" : "odd";

            Console.WriteLine($"{Number} is an {result} integer");
        }
    }
}
