using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.  
///Test Data : 135
///Expected Output: 
///The person is Dwarf.
/// </summary>
namespace Assignment4
{
    class Program7
    {
        public Program7()
        {
            int Height;

            Console.WriteLine("Enter your height: ");
            Height = int.TryParse(Console.ReadLine(), out Height) ? Height : 0;

            if (Height > 0 && Height <= 135)
            {
                Console.WriteLine("The person is Dwarf");
            }
            else if (Height > 135 && Height <= 170)
            {
                Console.WriteLine("The person is short");
            }
            else if (Height > 170 && Height <= 180)
            {
                Console.WriteLine("The person is tall");
            }
            else
            {
                Console.WriteLine("The person is tallest");
            }
        }
    }
}
