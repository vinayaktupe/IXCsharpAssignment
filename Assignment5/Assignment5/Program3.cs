using System;
using System.Collections.Generic;
using System.Text;


/*
 Write a C# Sharp program to check whether a given number is positive or negative. 
Test Data: 14 
Expected Output: 
14 is a positive number 
*/

namespace Assignment4
{
    class Program3
    {
        public Program3()
        {
            int Number;

            Console.WriteLine("Enter a number: ");
            Number = int.TryParse(Console.ReadLine(), out Number) ? Number : 0;

            if (Number > 0)
            {
                Console.WriteLine($"{Number} is positive number.");
            }
            else
            {
                Console.WriteLine($"{Number} is negative number.");
            }
        }

    }
}
