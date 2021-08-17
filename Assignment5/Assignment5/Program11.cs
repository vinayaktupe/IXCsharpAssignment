using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class Program11
    {
        public Program11()
        {
            int Number;

            Console.WriteLine("Enter a number: ");
            Number = int.TryParse(Console.ReadLine(), out Number) ? Number : 0;
            int k = 1;
            for (int i = 0; i < Number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(k + " "); k++;
                }
                Console.WriteLine();
            }
        }
    }
}
