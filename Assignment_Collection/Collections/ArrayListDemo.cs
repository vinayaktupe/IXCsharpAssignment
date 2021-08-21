using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class ArrayListDemo
    {
        /// <summary>
        /// ArrayList can store any type of data
        /// </summary>
        public ArrayListDemo()
        {
            ArrayList arrayList = new ArrayList(100);
            arrayList.Add(2);
            arrayList.Add(1);
            //arrayList.Add("Hello");
            arrayList.Add(4);
            //arrayList.Add(1.11);
            arrayList.Add(3);
            arrayList.Insert(0, 15);
            arrayList.InsertRange(4, new int[] { 12, 13, 16, 17 });
            //arrayList.Add("World");
            //arrayList.Add(3.141f);

            Console.WriteLine("Before sorting");
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine($"\n\nDoes arrayList contains 5? {arrayList.Contains(5)}");

            arrayList.AddRange(new int[] { 9, 6, 5, 0 });

            Console.WriteLine($"Does arrayList contains 5? {arrayList.Contains(5)}\n");

            arrayList.Sort();

            Console.WriteLine("\nafter sorting in ascending order");
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }

            arrayList.Reverse();
            Console.WriteLine("\n\nafter sorting in decending order");
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine($"\n\narrayList length before trim: {arrayList.Capacity}");
            arrayList.TrimToSize();
            Console.WriteLine($"arrayList length after trim: {arrayList.Capacity}");

            Console.WriteLine($"\nWhat is the index of number 12? {arrayList.IndexOf(12)}");

            ArrayList repeatedList = ArrayList.Repeat(arrayList, 2);

            Console.WriteLine("\nArrayList repeated 2 times");
            foreach (dynamic list in repeatedList)
            {
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
