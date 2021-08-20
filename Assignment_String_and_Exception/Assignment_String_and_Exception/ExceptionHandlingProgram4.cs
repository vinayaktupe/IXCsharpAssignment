using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_String_and_Exception
{
    class ExceptionHandlingProgram4
    {
        public ExceptionHandlingProgram4()
        {
            try
            {
                int Numerator, Denominator, Index;
                Console.WriteLine("Enter a Numerator: ");
                Numerator = int.TryParse(Console.ReadLine(), out Numerator) ? Numerator : 0;

                Console.WriteLine("Enter a Denominator: ");
                Denominator = int.TryParse(Console.ReadLine(), out Denominator) ? Denominator : 0;

                Console.WriteLine($"Result: {Numerator / Denominator}");
                int[] arr = new int[5];

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"Enter number for arr[{i}]: ");
                    arr[i] = int.TryParse(Console.ReadLine(), out arr[i]) ? arr[i] : 0;
                }

                Console.WriteLine("Enter Array Index to access element of array: ");
                Index = int.TryParse(Console.ReadLine(), out Index) ? Index : 0;

                Console.WriteLine($"Element at location {Index}: {arr[Index]}");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Denominator cannot be zero\n{ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Please enter a number of type 32-bit Integer.\n{ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Accessing element which is not within range of array.\n{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}
