using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_String_and_Exception
{
    class ExceptionHandlingProgram3_3
    {
        public ExceptionHandlingProgram3_3()
        {
            try
            {
                int Number;
                Console.WriteLine("Enter a Number: ");
                Number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Please enter a number of type 32-bit Integer.\n{ex.Message}");
            }
        }
    }
}
