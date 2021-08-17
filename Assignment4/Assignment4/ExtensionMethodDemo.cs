using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public static class ExtensionMethodDemo
    {

        public static int Add(this int FN,params int[] SN)
        {
            foreach (int item in SN)
            {
                FN += item;
            }

            return FN;
        }

        public static int Multiply(this int FN, params int[] SN)
        {
            foreach (int item in SN)
            {
                FN *= item;
            }

            return FN;
        }

    }
}
