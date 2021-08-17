using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public partial class PartialMethodDemo
    {
        partial void PartialPrint();

        public void Print()
        {
            PartialPrint();
        }

    }
}
