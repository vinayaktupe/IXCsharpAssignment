using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Assignment_MultiThreading
{
    class ThreadMethodsDemo
    {
        public ThreadMethodsDemo()
        {
            try
            {
                Thread fooThread = new Thread(Foo);
                Thread barThread = new Thread(Bar);

                fooThread.IsBackground = true;
                fooThread.Name = "Foo Method Thread";
                barThread.Name = "Bar Method Thread";

                fooThread.Start();
                Console.WriteLine($"Is Yield Successful? {Thread.Yield()}");
                barThread.Start();


                if (fooThread.IsAlive)
                {
                    fooThread.Interrupt();
                    barThread.Join();
                    //Thread.Sleep(1500);
                    Console.WriteLine($"Is Alive? {fooThread.IsAlive}");
                    //Thread.ResetAbort();
                    fooThread.Start();
                    //barThread.Resume();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exception Caught: {ex.Message}");
            }
        }

        public static void Foo()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        public void Bar()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}
