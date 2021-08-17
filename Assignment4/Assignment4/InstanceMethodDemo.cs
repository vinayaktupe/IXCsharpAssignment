using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class InstanceMethodDemo
    {
        public int Add(int FN, params int[] SN)
        {
            foreach (int item in SN)
            {
                FN += item;
            }

            return FN;
        }

        public int Multiply(int FN, params int[] SN)
        {
            foreach (int item in SN)
            {
                FN *= item;
            }

            return FN;
        }
    }
}
