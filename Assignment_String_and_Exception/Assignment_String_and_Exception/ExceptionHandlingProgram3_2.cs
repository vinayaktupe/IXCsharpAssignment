using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_String_and_Exception
{
    class ExceptionHandlingProgram3_2
    {

        public ExceptionHandlingProgram3_2()
        {
            try
            {
                int[] arr = new int[5];
                arr[0] = 1;
                arr[1] = 2;
                arr[2] = 3;
                arr[3] = 4;
                arr[4] = 5;

                Console.WriteLine(arr[0]);
                Console.WriteLine(arr[1]);
                Console.WriteLine(arr[2]);
                Console.WriteLine(arr[3]);
                Console.WriteLine(arr[4]);
                Console.WriteLine(arr[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Accessing element which is not within range of array.\n{ex.Message}");
            }

        }
    }
}
