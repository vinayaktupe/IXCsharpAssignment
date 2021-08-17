using System;
using System.Collections.Generic;
using System.Text;

/*
 Write a C# Sharp program to accept two integers and check whether they are equal or not. 
Test Data : 
Input 1st number: 5 
Input 2nd number: 5 
Expected Output: 
5 and 5 are equal 
 */

namespace Assignment4
{

    class Program1
    {
        public Program1()
        {
            int FN, SN;

            Console.WriteLine("Enter first number: ");
            FN = int.TryParse(Console.ReadLine(), out FN) ? FN : 0;

            Console.WriteLine("Enter second number: ");
            SN = int.TryParse(Console.ReadLine(), out SN) ? SN : 0;

            if (FN == SN)
            {
                Console.WriteLine($"{FN} and {SN} are equal");
            }
            else
            {
                Console.WriteLine($"{FN} and {SN} are not equal");
            }
        }
    }
}