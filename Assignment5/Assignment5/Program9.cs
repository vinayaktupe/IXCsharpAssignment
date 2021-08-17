using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
///Write a program in C# Sharp to accept a grade and declare the equivalent description: 
///Grade
///E - Excellent 
///V - Very Good 
///G - Good 
///A - Average 
///F - Fail 
///Test Data: 
///Input the grade: a
///Expected Output: 
///You have chosen: Average
/// </summary>

namespace Assignment4
{
    class Program9
    {
        public Program9()
        {
            string Grade;

            Console.WriteLine("Input the grade: ");
            Grade = Console.ReadLine().ToLower();

            switch (Grade)
            {
                case "e":
                    Console.WriteLine("You have chosen: Excellent");
                    break;
                case "v":
                    Console.WriteLine("You have chosen: Very Good");
                    break;
                case "g":
                    Console.WriteLine("You have chosen: Good");
                    break;
                case "a":
                    Console.WriteLine("You have chosen: Average");
                    break;
                case "f":
                    Console.WriteLine("You have chosen: Fail");
                    break;
                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        }
    }
}
