using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class StackDemo
    {
        public StackDemo()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine($"Element on top of stack is: {stack.Peek()}");

            IEnumerator<int> enumerator = stack.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + " ");
            }

            Console.WriteLine($"\n\nPopping element: {stack.Pop()}");
            int poppedElement;
            stack.TryPop(out poppedElement);
            Console.WriteLine($"\nTrying to pop element: {poppedElement}");
            Console.WriteLine($"\nTotal Count: {stack.Count}");
            Console.WriteLine($"\nDoes stack have 5? {stack.Contains(5)}");
        }
    }
}
