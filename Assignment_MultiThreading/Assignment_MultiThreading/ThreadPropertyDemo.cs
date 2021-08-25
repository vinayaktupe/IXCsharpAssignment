using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Assignment_MultiThreading
{
    /// <summary>
    /// Write a c# program to use all thread property and print result on console 
    /// </summary>
    class ThreadPropertyDemo
    {
        public ThreadPropertyDemo()
        {
            try
            {


                Thread thread1 = new Thread(new ThreadStart(this.Foo));
                Thread thread2 = new Thread(new ThreadStart(this.Bar));

                thread1.Start();
                thread2.Start();

                Thread currentThread = Thread.CurrentThread;

                Console.WriteLine($"Thread ID: {currentThread.ManagedThreadId}");
                Console.WriteLine($"Is current thread a background thread?: {currentThread.IsBackground}");
                Console.WriteLine($"Priority: {currentThread.Priority}");
                Console.WriteLine($"Thread Name: {currentThread.Name}");
                Console.WriteLine($"Culture: {currentThread.CurrentCulture.Name}");
                Console.WriteLine($"UI Culture: {currentThread.CurrentUICulture.Name}");
                Console.WriteLine($"Is Thread 1 alive? {thread1.IsAlive}");
                Console.WriteLine($"Thread 1 state: {thread1.ThreadState}");
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine($"ThreadAbortException Caught: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Caught: {ex.Message}");
            }
        }

        public void Foo()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Foo Printing..{i}");
                Thread.Sleep(1000);
            }
        }

        public void Bar()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine($"Bar Printing..{i}");
                Thread.Sleep(1000);
            }
        }

    }
}
