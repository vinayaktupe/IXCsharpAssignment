using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    class AnonymousMethod
    {
        public delegate void PrintDelegate(string Msg);
        public delegate bool IsEven(int Number);
        public AnonymousMethod()
        {
            PrintDelegate printDel = delegate (string Msg)
              {
                  Console.WriteLine($"Message: {Msg}");
              };

            printDel("Hello from anonymous method delegate");

            IsEven isEvenDel = delegate (int Number)
            {
                return Number % 2 == 0;
            };

            EvenOdd(2, isEvenDel);
            EvenOdd(3, isEvenDel);
            EvenOdd(4, isEvenDel);
            EvenOdd(5, isEvenDel);
            EvenOdd(6, delegate (int Number)
            {
                return Number % 2 == 0;
            });
        }


        //public void Print(string Message)
        //{
        //    Console.WriteLine(Message);
        //}

        public void EvenOdd(int Number, IsEven isEvenDel)
        {
            if (isEvenDel(Number))
            {
                Console.WriteLine($"{Number} is even.");
            }
            else
            {
                Console.WriteLine($"{Number} is odd.");
            }
        }

    }
}
