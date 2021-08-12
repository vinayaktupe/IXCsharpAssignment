using System;
using AbstractClassDemo;
using SealedClassDemo;
using ExtensionMethodDemo;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////WAYS OF CREATING OBJECTS
            ////1. Using 'new' keyword
            //Printer P = new Printer();
            //P.PrintPreview();
            //P.Print();
            //Console.WriteLine();

            ////2.Creating Reference to Existing Object
            //P = new Laserjet();
            //P.PrintPreview();
            //P.Print();
            //Console.WriteLine();

            //P = new Officejet();
            //P.PrintPreview();
            //P.Print();

            ////3.Creating an Array of objects
            //Printer[] printers = new Printer[3];
            //Console.WriteLine("\n\n");
            //printers[0] = new Printer();
            //printers[1] = new Printer();
            //printers[2] = new Printer();

            //foreach (Printer printer  in printers)
            //{
            //    printer.Print();

            //}

            //Console.WriteLine("\n\n");
            //Animal animal = new Dog();
            //animal.Voice();

            //animal = new Cat();
            //animal.Voice();
            Console.WriteLine(10.Sum(20));

        }
    }
}
