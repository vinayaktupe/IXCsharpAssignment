using System;

namespace SealedClassDemo
{
    public class Printer
    {
        public virtual void PrintPreview()
        {
            Console.WriteLine("Page Dimensions: 6X6");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printer printing...");
        }
    }

    /*sealed*/ public class Laserjet : Printer
    {
        public sealed override void PrintPreview()
        {
            Console.WriteLine("Page Dimensions: 12X12");

        }

        public override void Print()
        {
            Console.WriteLine("Laserjet printing...");
        }
    }

    public class Officejet : Laserjet
    {
        //public sealed override void PrintPreview()
        //{
        //    Console.WriteLine("Page Dimensions: 12X12");

        //}

        public override void Print()
        {
            Console.WriteLine("Officejet printing...");
        }
    }
}
