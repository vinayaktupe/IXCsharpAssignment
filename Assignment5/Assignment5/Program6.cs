using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0. 
///Test Data : -5
///Expected Output: 
///The value of n = -1 
/// </summary>
/// 
namespace Assignment4
{
    class Program6
    {
        public Program6()
        {
            int Number;

            Console.WriteLine("Enter a number: ");
            Number = int.TryParse(Console.ReadLine(), out Number) ? Number : 0;


            if (Number > 0)
            {
                Console.WriteLine($"The value of n = 1");
            }
            else if (Number < 0)
            {
                Console.WriteLine($"The value of n = -1");
            }
            else
            {
                Console.WriteLine($"The value of n = 0");
            }
        }
    }
}
