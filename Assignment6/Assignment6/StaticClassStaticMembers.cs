using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    public static class StaticClassStaticMembers
    {
        public static string FirstName { get; set; }
        public static string LastName { get; set; }

        static StaticClassStaticMembers()
        {
            Console.WriteLine("Static constructor invoked. ");
        }

        public static string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public static int Add(this int FN, int SN)
        {
            return FN + SN;
        }
    }
}
