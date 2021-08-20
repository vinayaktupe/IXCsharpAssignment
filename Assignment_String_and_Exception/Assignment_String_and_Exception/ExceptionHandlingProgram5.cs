using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assignment_String_and_Exception
{
    class ExceptionHandlingProgram5
    {
        public ExceptionHandlingProgram5()
        {
            StreamReader reader = null;

            try
            {
                string filePath = @"D:\Vinayak\Csharp\Assignment\Assignment_String_and_Exception\Assignment_String_and_Exception\Data.txt";
                reader = new StreamReader(filePath);

                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block called");
                reader.Close();
            }
        }
    }
}
