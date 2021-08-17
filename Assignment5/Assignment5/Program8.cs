using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Write a C# Sharp program to find the largest of three numbers.  
///Test Data : 
///0Input the 1st number :25
///Input the 2nd number :63
///Input the 3rd number :10
///Expected Output: 
///The 2nd Number is the greatest among three 
/// </summary>

namespace Assignment4
{
    class Program8
    {

        public Program8()
        {
            int FN, SN, TN;

            Console.WriteLine("Enter the 1st number: ");
            FN = int.TryParse(Console.ReadLine(), out FN) ? FN : 0;

            Console.WriteLine("Enter the 2nd number: ");
            SN = int.TryParse(Console.ReadLine(), out SN) ? SN : 0;

            Console.WriteLine("Enter the 3rd number: ");
            TN = int.TryParse(Console.ReadLine(), out TN) ? TN : 0;

            if (FN > SN && FN > TN)
            {
                Console.WriteLine("The 1st is the greatest among three");
            }
            else if (SN > FN && SN > TN)
            {
                Console.WriteLine("The 2nd is the greatest among three");
            }
            else if (TN > FN && TN > SN)
            {
                Console.WriteLine("The 3rd is the greatest among three");
            }
            else
            {
                Console.WriteLine("All are equal.");
            }
        }
    }
}
