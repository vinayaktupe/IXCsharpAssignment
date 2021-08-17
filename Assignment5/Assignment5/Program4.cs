using System;
using System.Collections.Generic;
using System.Text;

/*
 Write a C# Sharp program to find whether a given year is a leap year or not.  
Test Data: 2016 
Expected Output: 
2016 is a leap year. 
 */

namespace Assignment4
{
    class Program4
    {

        public Program4()
        {
            int Year;

            Console.WriteLine("Enter Year: ");
            Year = int.TryParse(Console.ReadLine(), out Year) ? Year : 0;

            if (Year < 0)
            {
                Console.WriteLine("Year cannot be negative.");
            }
            else
            {
                if (Year % 4 == 0)
                {
                    if (Year % 100 == 0 && Year % 400 == 0)
                    {
                        Console.WriteLine($"{Year} is not a leap year.");

                    }
                    else
                    {
                        Console.WriteLine($"{Year} is a leap year.");
                    }
                }
                else
                {
                    Console.WriteLine($"{Year} is not a leap year.");

                }
            }
        }
    }
}
