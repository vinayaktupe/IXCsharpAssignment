using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Collections
{
    class DictionaryDemo : IEqualityComparer<int>
    {
        public DictionaryDemo()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.TryAdd("One", 1);
            dict.TryAdd("One", 1);
            dict.TryAdd("Two", 2);
            dict.TryAdd("Three", 3);
            dict.TryAdd("Four", 4);
            dict.TryAdd("Five", 5);

            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Console.WriteLine($"Does dictioonary has key Three? {dict.ContainsKey("Three")}");
            Console.WriteLine($"Ensure Capacity: {dict.EnsureCapacity(2)}");

            IEqualityComparer<string> equalityComparer = dict.Comparer;

        }

        public bool Equals([AllowNull] int x, [AllowNull] int y)
        {
            return x.Equals(y);
        }

        public int GetHashCode([DisallowNull] int obj)
        {
            return obj.GetHashCode();
        }
    }
}
