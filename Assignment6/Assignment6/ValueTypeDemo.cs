using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class ValueTypeDemo
    {
        public ValueTypeDemo()
        {
            bool flag = false;
            int x = 10;
            int b;
            b = x;

            //byte 
            Console.WriteLine($"Byte Min Value: {byte.MinValue}");
            Console.WriteLine($"Byte Max Value: {byte.MaxValue}");

            //int
            Console.WriteLine($"int Min Value: {int.MinValue}");
            Console.WriteLine($"int Max Value: {int.MaxValue}");

            //float
            Console.WriteLine($"float Min Value: {float.MinValue}");
            Console.WriteLine($"float Max Value: {float.MaxValue}");

            //double
            Console.WriteLine($"double Min Value: {double.MinValue}");
            Console.WriteLine($"double Max Value: {double.MaxValue}");

            //long
            Console.WriteLine($"long Min Value: {long.MinValue}");
            Console.WriteLine($"long Max Value: {long.MaxValue}");



        }
    }
}
