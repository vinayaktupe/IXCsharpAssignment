using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_String_and_Exception
{
    class StringDemo
    {
        public StringDemo()
        {
            string name = "John Doe";
            string nameClone = (string)name.Clone();
            string nameCopy = "";

            Console.WriteLine($"String Clone: {nameClone}");
            Console.WriteLine($"String Compare: John Doe == John Doe: {string.Compare(name, 0, nameClone, 0, Math.Max(name.Length, nameClone.Length))}");
            Console.WriteLine($"String CompareOrdinal: John Doe == John Doe: {string.CompareOrdinal(name, nameClone)}");
            Console.WriteLine($"String CompareTo: John Doe == John Doe: {name.CompareTo(nameClone)}");
            Console.WriteLine($"String Concat: {"Hello! " + name}");
            Console.WriteLine($"String Contains John: {name.Contains("John")}");


            Console.WriteLine($"String CopyTo:");
            string strSource = "changed";
            char[] destination = "This is initial array".ToCharArray();
            Console.WriteLine(destination);
            strSource.CopyTo(0, destination, 4, strSource.Length);
            Console.WriteLine(destination);

            Console.WriteLine($"String EndsWith John: {name.EndsWith("John")}");
            Console.WriteLine($"String Equals Mary Jane: {name.Equals("Mary Jane")}");
            Console.WriteLine("String Format: " + String.Format("It is now {0:d} at {0:t}", DateTime.Now));
            Console.WriteLine("String GetEnumerator:");
            CharEnumerator enumerator = name.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current);
            }
            Console.WriteLine($"\nString GetHashCode: {name.GetHashCode()}");
            Console.WriteLine($"String GetType: {name.GetType()}");
            Console.WriteLine($"String GetTypeCode: {name.GetTypeCode()}");
            Console.WriteLine($"String IndexOf O: {name.IndexOf("o")}");
            Console.WriteLine($"String Insert Hello! at zero index: {name.Insert(0, "Hello! ")}");
            Console.WriteLine($"String Intern: {string.Intern(name)}");
            Console.WriteLine($"String IsInterned: {string.IsInterned(name)}");
            Console.WriteLine($"String IsNormalized: {name.IsNormalized()}");
            Console.WriteLine($"String IsNullOrEmpty: {string.IsNullOrEmpty(name)}");
            Console.WriteLine($"String IsNullOrWhiteSpace: {string.IsNullOrWhiteSpace(name)}");
            Console.WriteLine($"String Join : {string.Join("_", name.ToCharArray())}");
            Console.WriteLine($"String LastIndexOf O: {name.LastIndexOf("o")}");
            Console.WriteLine($"String LastIndexOfAny J and O: {name.LastIndexOfAny(new char[] { 'j', 'o' })}");
            Console.WriteLine($"String Normalize: {name.Normalize()}");
            Console.WriteLine($"String PadLeft: {name.PadLeft(5)}");
            Console.WriteLine($"String PadRight: {name.PadRight(5)}");
            Console.WriteLine($"String Remove: {name.Remove(4)}");
            Console.WriteLine($"String Replace: {name.Replace('J','H')}");
            string[] nameArr = name.Split(" ");
            Console.WriteLine($"String Split :");
            foreach (string nameHalf in nameArr)
            {
                Console.WriteLine(nameHalf);
            }
            Console.WriteLine($"String StartsWith Doe: {name.StartsWith("Doe")}");
            Console.WriteLine($"String Substring: {name.Substring(3)}");
            Console.WriteLine($"String ToLower: {name.ToLower()}");
            Console.WriteLine($"String ToLowerInvariant: {name.ToLowerInvariant()}");
            Console.WriteLine($"String ToUpper: {name.ToUpper()}");
            Console.WriteLine($"String Trim: {name.Trim()}");
            Console.WriteLine($"String TrimEnd: {name.TrimEnd()}");
            Console.WriteLine($"String TrimStart: {name.TrimStart()}");

        }
    }
}
