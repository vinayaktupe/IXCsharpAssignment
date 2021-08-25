using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Assignment_MultiThreading
{
    /// <summary>
    /// Write a c# program using Thread.Join() for multiple threads  
    //Thread one contains table of 2  
    //Thread one contains table of 3 
    //Thread one contains table of 4  
    //and output becomes as below 
    //Output 1- Print table of 2 then table of 3 and then table of 4 
    //Output 2- Print table of 4 then table of 3 and then table of 2 
    /// </summary>
    class ThreadJoinDemo
    {
        Thread thread2, thread3, thread4;
        public ThreadJoinDemo()
        {
            thread2 = new Thread(new ThreadStart(Tables.TableTwo));
            thread3 = new Thread(new ThreadStart(Tables.TableThree));
            thread4 = new Thread(new ThreadStart(Tables.TableFour));


        }

        public void Output1()
        {
            thread2.Start();
            thread2.Join();

            thread3.Start();
            thread3.Join();

            thread4.Start();
            thread4.Join();
        }

        public void Output2()
        {
            thread4.Start();
            thread4.Join();

            thread3.Start();
            thread3.Join();

            thread2.Start();
            thread2.Join();
        }
    }

    class Tables
    {

        public static void Table(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        public static void TableTwo()
        {
            Console.WriteLine("\nTable of 2");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"2 x {i} = {2 * i}");
            }
        }

        public static void TableThree()
        {
            Console.WriteLine("\nTable of 3");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"3 x {i} = {3 * i}");
            }
        }

        public static void TableFour()
        {
            Console.WriteLine("\nTable of 4");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"4 x {i} = {4 * i}");
            }
        }
    }
}
