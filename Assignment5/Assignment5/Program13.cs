using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class Program13
    {
        public Program13()
        {
            int Number;

            Console.WriteLine("Enter a number: ");
            Number = int.TryParse(Console.ReadLine(), out Number) ? Number : 0;


            int l = 1, k = 0, Spaces = Number;

            for (int i = 0; i < Number; i++)
            {
                k = 0;
                while (k < Spaces)
                {
                    Console.Write(" ");
                    k++;
                }
                Spaces--;
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{l} ");
                    l++;
                }
                Console.WriteLine();
            }
        }
    }
}
