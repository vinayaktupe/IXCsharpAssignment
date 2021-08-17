using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class StaticMethodDemo
    {
        public static float Pi = 3.14f;
        public static void Area(float radius)
        {
            Console.WriteLine($"Area: {Pi*radius*radius}");
        }
    }
}
