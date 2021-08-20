using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_String_and_Exception
{
    class ExceptionHandlingProgram3_1
    {
        public ExceptionHandlingProgram3_1()
        {
            try
            {
                int Numerator, Denominator;
                Console.WriteLine("Enter a Numerator: ");
                Numerator = int.TryParse(Console.ReadLine(), out Numerator) ? Numerator : 0;

                Console.WriteLine("Enter a Denominator: ");
                Denominator = int.TryParse(Console.ReadLine(), out Denominator) ? Denominator : 0;

                Console.WriteLine($"Result: {Numerator / Denominator}");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Denominator cannot be zero\n{ex.Message}");
            }
        }
    }
}
