using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.  
/// Test Data: 21
/// Expected Output: 
/// Congratulation! You are eligible for casting your vote. 
/// </summary>
namespace Assignment4
{
    class Program5
    {
        public Program5()
        {
            int Age;

            Console.WriteLine("Enter your Age: ");
            Age = int.TryParse(Console.ReadLine(), out Age) ? Age : 0;

            if (Age >= 0)
            {
                if (Age >= 18)
                {
                    Console.WriteLine("Congratulation! You are eligible for casting your vote.");
                }
                else
                {
                    Console.WriteLine("You are not eligible for casting your vote.");
                }
            }
            else
            {
                Console.WriteLine("Age cannot be negative");
            }
        }
    }
}
