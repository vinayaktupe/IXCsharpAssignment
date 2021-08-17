using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Write a program in C# Sharp to read any digit, display in the word.  
///Test Data : 
///4
///Expected Output: 
///Four
/// </summary>

namespace Assignment4
{
    class Program10
    {

        public Program10()
        {
            int Number;

            Console.WriteLine("Enter a number: ");
            Number = int.TryParse(Console.ReadLine(), out Number) ? Number : 0;

            switch (Number)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        }
    }
}
