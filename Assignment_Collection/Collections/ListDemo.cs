using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class ListDemo
    {
        public ListDemo()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 5, 6, 3, 2, 3, 7, 2, 8, 1, 9, 0 });

            Console.WriteLine("List Items:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine($"\n\nFind first index of 1: {list.IndexOf(1)}");
            Console.WriteLine($"Find last index of 1: {list.LastIndexOf(1)}");

            Console.WriteLine($"\nIndex of 7 using IndexOf(): {list.IndexOf(2)}");
            Console.WriteLine($"Index of 7 using FindIndex(): {list.FindIndex(item => item == 2)}");

            Comparison<int> comparison = delegate (int x, int y)
            {
                return x.CompareTo(y);
            };

            list.Sort(comparison);
            Console.WriteLine("\nSorting in Ascending:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            list.Sort((int x, int y) => y.CompareTo(x));

            Console.WriteLine("\n\nSorting in Decending:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine($"\n\nRemoving element 1 from list: {list.Remove(1)}");
            Console.WriteLine($"\n\nRemoving all element 3 from list: {list.RemoveAll(x => x == 3)}");

            Console.WriteLine("\nDifference between exists and contains:");
            Console.WriteLine("Exists uses an predicate to find an element in list and returns boolean result such as:");
            Console.WriteLine($"Does element 9 in list? {list.Exists(x => x == 9)}");
            Console.WriteLine("\nWhereas Contains does not require an predicate we just need to pass the element to look for such as:");
            Console.WriteLine($"Does element 9 in list? {list.Contains(9)}");

            Console.WriteLine($"\nLength of list before removing all elements: {list.Count}");
            list.Clear();
            Console.WriteLine($"Length of list after removing all elements: {list.Count}");
        }
    }
}
